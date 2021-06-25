#ifndef BD_H
#define BD_H

#ifdef __cplusplus
extern "C" {
	#include "sqlite3.h"
}
#endif


class BD
{
    sqlite3 *db;
	sqlite3_stmt *stmt;
    char *nombreBD;


    public:
        BD(const char *nombreBD);
        void crearBD();
        int abrirBD();
        int existeUsuario(const char* dni);
        int comprobarLogin(const char *dni, const char *contrasenya);
        void insertarUsuario(const char *dni,const char * contrasenya);
        void mostrarTodosLasPersonas();
        virtual ~BD();

};

#endif // BD_H
