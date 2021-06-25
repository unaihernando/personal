
#include "Sudadera.h"
#include "Prenda.h"
#include <iostream>
#include <string.h>
using namespace std;
//CONSTRUCTORES
Sudadera::Sudadera():Prenda() {

	this->talla = new char[1];
	this->talla[0] = '\0';

	this->color = new char[1];
	this->color[0] = '\0';

	this->precio = 0.0;

	this->capucha = false;
	this->cerrada = false;
}
Sudadera::Sudadera(const char * talla,const char * color,double precio,bool cerrada,bool capucha):Prenda(talla, color, precio){

	this->cerrada = cerrada;
	this->capucha = capucha;
}
Sudadera::Sudadera(const Sudadera &s):Prenda(s){

	this->talla = new char[strlen(s.talla)+1];
	strcpy(this->talla,s.talla);

	this->color = new char[strlen(s.color)+1];
	strcpy(this->color,s.color);

	this->precio = s.precio;

	this->capucha = s.capucha;
	this->cerrada = s.cerrada;

}

//GETTERS Y SETTERS
bool Sudadera::getCerrada(){
	return this->cerrada;
}
bool Sudadera::getCapucha(){
	return this->capucha;
}
void Sudadera::setCerrada(bool cerrada){
	this->cerrada = cerrada;
}
void Sudadera::setCapucha(bool capucha){
	this->capucha = capucha;
}

//DESTRUCTOR
Sudadera::~Sudadera() {
	// TODO Auto-generated destructor stub
}

//METODOS
void Sudadera::imprimir(){
	const char * str1;
	const char * str2;
	Prenda::imprimir();
	if(this->capucha == false){
		str1= "SUDADERA SIN CAPUCHA";
	}else{
		str1= "SUDADERA CON CAPUCHA";
	}
	if(this->cerrada == false){
		str2=" Y ABIERTA(con cremallera)";
	}else{
		str2=" Y CERRADA(sin cremallera)";
	}
	cout<<str1<<str2<<endl;
}

