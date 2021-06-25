
#include "Pantalon.h"
#include <string.h>
#include <iostream>
using namespace std;
//CONSTRUCTORES
Pantalon::Pantalon():Prenda() {

	this->talla = new char[1];
	this->talla[0] = '\0';

	this->color = new char[1];
	this->color[0] = '\0';

	this->precio = 0.0;

	this->largo = false;

}
Pantalon::Pantalon(const char * talla,const char * color,double precio,bool largo):Prenda(talla, color, precio){

	this->talla = new char[strlen(talla)+1];
	strcpy(this->talla,talla);

	this->color = new char[strlen(color)+1];
	strcpy(this->color,color);

	this->precio = precio;

	this->largo = largo;
}
Pantalon::Pantalon(const Pantalon &pa):Prenda(pa){
	this->largo = pa.largo;
}
bool Pantalon::getLargo() const{
	return this->largo;
}
void Pantalon::setLargo(bool largo){
	this->largo = largo;
}

//DESTRUCTOR
Pantalon::~Pantalon() {
	// TODO Auto-generated destructor stub
}

//METODOS
void Pantalon::imprimir(){
	Prenda::imprimir();
	const char * str;
	if(this->largo == false){
		str = "PANTALON CORTO";
	}else{
		str = "PANTALON LARGO";
	}
	cout<<str<<endl;
}


