

#ifndef BASICFASHION_H_
#define BASICFASHION_H_
#include "Pedido.h"
class BasicFashion {
protected:
	Pedido ** pedidos;
	int numPedidos;
public:

	BasicFashion();
	void anyadirPedido(Pedido *p);
	virtual ~BasicFashion();
};

#endif /* BASICFASHION_H_ */
