

#include "BasicFashion.h"

BasicFashion::BasicFashion() {
	// TODO Auto-generated constructor stub

}
void BasicFashion::anyadirPedido(Pedido *p){
	if(numPedidos==0){
		pedidos = new Pedido*[1];
		pedidos[0] = p;
		numPedidos++;
	}else{
		Pedido ** aux = new Pedido*[numPedidos];
		for(int i = 0;i<numPedidos;i++){
			aux[i] = pedidos[i];
		}
		delete [] pedidos;
		pedidos = new Pedido*[numPedidos+1];
		for(int i = 0;i<numPedidos;i++){
			pedidos[i] = aux[i];
		}
		pedidos[numPedidos] = p;
		numPedidos++;
		delete [] aux;

	}
}

BasicFashion::~BasicFashion() {
	delete [] pedidos;
	numPedidos--;
}

