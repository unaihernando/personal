
#include <iostream>
#include "Usuario.h"
#include <string.h>
using namespace std;
//CONSTRUCTORES
Usuario::Usuario() {

	this->contrasenya = new char[1];
	this->contrasenya[0] = '\0';

	this->dni = new char[1];
	this->dni[0] = '\0';

}

Usuario::Usuario(const char * dni ,const char * contrasenya ){

	this->contrasenya = new char[strlen(contrasenya)+1];
	strcpy(this->contrasenya,contrasenya);

	this->dni = new char[strlen(dni)+1];
	strcpy(this->dni,dni);
}

Usuario::Usuario(const Usuario &u){

	this->contrasenya = new char[strlen(u.contrasenya)+1];
	strcpy(this->contrasenya,u.contrasenya);

	this->dni = new char[strlen(u.dni)+1];
	strcpy(this->dni,u.dni);
}
//GETTERS Y SETTERS

char * Usuario::getContrasenya() const{
	return this->contrasenya;
}
char * Usuario::getDni() const{
	return this->dni;
}

void Usuario::setContrasenya(char * contrasenya){
	delete [] this->contrasenya;
	this->contrasenya = new char[strlen(contrasenya)+1];
	strcpy(this->contrasenya,contrasenya);
}
void Usuario::setDni(char * dni){
	delete [] this->dni;
	this->dni = new char[strlen(dni)+1];
	strcpy(this->dni,dni);
}

//DESTRUCTOR
Usuario::~Usuario() {
	delete [] this->contrasenya;
	delete [] this->dni;
}
//METODOS
void Usuario::imprimir(){
	cout << "[ DNI USUARIO: " << this->dni << " CONTRASENYA: " << this->contrasenya <<" ]" << endl;
}

