
#include "Camiseta.h"
#include "Prenda.h"
#include <string.h>
#include <iostream>
using namespace std;

//CONSTRUCTORES
Camiseta::Camiseta():Prenda() {

	this->talla = new char[1];
	this->talla[0] = '\0';

	this->color = new char[1];
	this->color[0] = '\0';

	this->precio = 0.0;

	this->mangaLarga = false;


}
Camiseta::Camiseta(const char * talla,const char * color,double precio,bool mangaLarga):Prenda(talla, color, precio){

	this->talla = new char[strlen(talla)+1];
	strcpy(this->talla,talla);

	this->color = new char[strlen(color)+1];
	strcpy(this->color,color);

	this->precio = precio;

	this->mangaLarga = mangaLarga;
}
Camiseta::Camiseta(const Camiseta &c):Prenda(c){
	this->mangaLarga = c.mangaLarga;
}

//GETTERS Y SETTERS
bool Camiseta::getMangaLarga() const{
	return this->mangaLarga;

}
void Camiseta::setMangaLarga(bool mangaLarga){
	this->mangaLarga = mangaLarga;
}

//DESTRUCTOR
Camiseta::~Camiseta() {
	// TODO Auto-generated destructor stub
}

//METODOS
void Camiseta::imprimir(){
	Prenda::imprimir();
	const char * str;
	if(this->mangaLarga == false){
		str = "CAMISETA DE MANGA CORTA";
	}else{
		str = "CAMISETA DE MANGA LARGA";
	}
	cout<<str<<endl;
}

