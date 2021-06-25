
#include "Prenda.h"
#include <string.h>
#include <iostream>
using namespace std;

//CONSTRUCTORES
Prenda::Prenda() {

	this->talla = new char[1];
	this->talla[0] = '\0';

	this->color = new char[1];
	this->color[0] = '\0';

	this->precio = 0.0;


}
Prenda::Prenda(const char * talla,const char * color,double precio){

	this->talla = new char[strlen(talla)+1];
	strcpy(this->talla,talla);

	this->color = new char[strlen(color)+1];
	strcpy(this->color,color);

	this->precio = precio;
}

Prenda::Prenda(const Prenda& p){

	this->talla = new char[strlen(p.talla)+1];
	strcpy(this->talla,p.talla);

	this->color = new char[strlen(p.color)+1];
	strcpy(this->color,p.color);

	this->precio = p.precio;
}
//GETTERS Y SETTERS

char * Prenda::getTalla() const{
	return this->talla;
}
char * Prenda::getColor() const{
	return this->color;
}
float Prenda::getPrecio() const{
	return this->precio;
}
void Prenda::setTalla(const char * talla){
	delete [] this->talla;
	this->talla = new char[strlen(talla)+1];
	strcpy(this->talla,talla);
}
void Prenda::setColor(const char * color){
	delete [] this->color;
	this->color = new char[strlen(color)+1];
	strcpy(this->color,color);
}
void Prenda::setPrecio(double precio){
	this->precio = precio;
}
//DESTRUCTOR
Prenda::~Prenda() {
	delete [] this->color;
	delete [] this->talla;

}
//METODOS
void Prenda::imprimir(){
	cout<<"[ PRENDA: "<<" TALLA: "<<this->talla<<" COLOR: "<<this->color<<" PRECIO: "<<this->precio<<" ]"<<endl;
}

