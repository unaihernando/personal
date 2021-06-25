
#include "Pedido.h"
#include <iostream>
#include <string.h>
using namespace std;

int Pedido::codPedido = 0;

Pedido::Pedido() {

	this->numPrendas = 0;
	codPedido++;

}
Pedido::Pedido(Usuario *u,Prenda ** prendas,int numPrendas){
	this->usuario = u;

	this->numPrendas = numPrendas;

	this->prendas = new Prenda*[numPrendas];

	for(int i = 0; i<numPrendas;i++){
		this->prendas[i] = prendas[i];
	}
	codPedido++;
}

Pedido::~Pedido() {
	delete [] this->prendas;
	codPedido--;//Si se cancela un pedido lo borramos
}

double Pedido::getPrecioTotal(){
	double precioTotal = 0.0;
	for(int i = 0;i<numPrendas;i++){
		precioTotal+= prendas[i]->getPrecio();
	}
	return precioTotal;
}
void Pedido::imprimir(){
	cout<<"PEDIDO: "<<"CODPEDIDO: "<<this->codPedido<<endl;
	this->usuario->imprimir();
	for(int i = 0;i<numPrendas;i++){
		prendas[i]->imprimir();
	}
	cout<<"TOTAL DE PRENDAS: "<<this->numPrendas<<endl;

}
void Pedido::anyadirPrenda(Prenda *p){
	if(numPrendas==0){
		prendas = new Prenda*[1];
		prendas[0] = p;
		numPrendas++;
	}else{
		Prenda ** aux = new Prenda*[numPrendas];
		for(int i = 0;i<numPrendas;i++){
			aux[i] = prendas[i];
		}
		delete [] prendas;
		prendas = new Prenda*[numPrendas+1];
		for(int i = 0;i<numPrendas;i++){
			prendas[i] = aux[i];
		}
		prendas[numPrendas] = p;
		numPrendas++;
		delete [] aux;

	}

}

Pedido & Pedido::operator=(const Pedido &p){
    this->numPrendas = p.numPrendas;
    this->prendas = new Prenda*[numPrendas];
    for(int i = 0; i<numPrendas;i++){
    		this->prendas[i] = p.prendas[i];
    	}
    this->usuario = p.usuario;
    return (*this);
}

