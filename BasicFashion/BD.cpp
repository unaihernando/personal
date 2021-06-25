#ifdef __cplusplus
extern "C" {
#include "sqlite3.h"
}
#endif

#include "BD.h"
#include <iostream>
#include <string.h>
using namespace std;

BD::BD(const char * nombreBD) {
	this->nombreBD = new char[strlen(nombreBD+1)];
	strcpy(this->nombreBD,nombreBD);

}

BD::~BD() {
	delete [] this->nombreBD;
}

void BD::crearBD()
{

	if (sqlite3_open(nombreBD, &db)) {
		cout << "ERROR!!" << endl;
	} else {
        const char *sentencia = "CREATE TABLE USUARIO(dni CHAR(10), contrasenya CHAR(20));";
		sqlite3_exec(db, sentencia, NULL, 0, 0);
	}
}
int BD::abrirBD(){
	int result = sqlite3_open(nombreBD, &db);
	if(result != SQLITE_OK){
            cout<<"ERROR!! No se ha podido abrir la Base de Datos";
	}

	return result;
}
int BD::existeUsuario(const char* dni){

    char query[100];
    int num;

    sprintf(query,"SELECT COUNT(*) FROM USUARIO WHERE dni='%s'",dni);
    sqlite3_prepare_v2(db, query, strlen(query) + 1, &stmt, NULL);
    sqlite3_step(stmt);
    num = sqlite3_column_int(stmt,0);
    sqlite3_finalize(stmt);

    return num;
}
void BD::insertarUsuario(const char *dni,const char * contrasenya){
    char query[100];
    int num;

    num = existeUsuario(dni);
    if(num==0)
    {
        sprintf(query,"INSERT INTO USUARIO(dni,contrasenya) VALUES ('%s','%s')", dni, contrasenya);
        sqlite3_prepare_v2(db, query, strlen(query) + 1, &stmt, NULL);
        sqlite3_step(stmt);
        sqlite3_finalize(stmt);
    }
}
int BD::comprobarLogin(const char *dni, const char *contrasenya){
    /*Devuelve 0 si el dni es incorrecto
    Devuelve 1 si el dni es correcto pero la contraseña no
    Devuelve 2 si dni y contraseña son correctos*/

    int resul = 2,r;
    char query[100];
    sprintf(query,"SELECT * FROM USUARIO WHERE dni='%s'",dni);
    sqlite3_prepare_v2(db, query, strlen(query) + 1, &stmt, NULL);
    r=sqlite3_step(stmt);
    if (r == SQLITE_ROW){
        char* con = (char*) sqlite3_column_text(stmt, 1);
        if(strcmp(con,contrasenya)!=0){
            resul = 1;
        }
    }else{
        resul = 0;
    }
    sqlite3_finalize(stmt);
    return resul;
}
void BD::mostrarTodosLasPersonas(){
    char query[100];
    int resul;

    sprintf(query,"SELECT * FROM USUARIO");
    sqlite3_prepare_v2(db, query, strlen(query) + 1, &stmt, NULL);

    do
    {
	resul = sqlite3_step(stmt);
	if (resul == SQLITE_ROW){
            char* dni = (char*) sqlite3_column_text(stmt, 0);
            char * contrasenya = (char*)sqlite3_column_text(stmt,1);
            cout<<dni<<" "<<contrasenya<<endl;
	}

    }while(resul==SQLITE_ROW);
    sqlite3_finalize(stmt);

}

