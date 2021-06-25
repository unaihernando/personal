
#ifndef SUDADERA_H_
#define SUDADERA_H_
#include "Prenda.h"
class Sudadera:public Prenda {
protected:
	//Por defecto las sudaderas son abiertas y sin capucha
	bool cerrada;
	bool capucha;
public:
	Sudadera();
	Sudadera(const char * talla,const char * color,double precio,bool cerrada,bool capucha);
	Sudadera(const Sudadera &s);
	bool getCerrada();
	bool getCapucha();
	void setCerrada(bool cerrada);
	void setCapucha(bool capucha);
	void imprimir();
	virtual ~Sudadera();
};

#endif /* SUDADERA_H_ */
