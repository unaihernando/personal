
#ifndef PEDIDO_H_
#define PEDIDO_H_
#include "Prenda.h"
#include "Usuario.h"

class Pedido {
protected:
	Usuario * usuario;
	Prenda ** prendas;
	int numPrendas;
	static int codPedido;
public:

	Pedido();
	Pedido(Usuario *u,Prenda ** prendas,int numPrendas);
	Pedido & operator=(const Pedido &p);
	double getPrecioTotal();
	void imprimir();
	void anyadirPrenda(Prenda *p);
	virtual ~Pedido();
};

#endif /* PEDIDO_H_ */
