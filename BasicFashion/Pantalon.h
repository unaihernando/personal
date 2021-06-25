
#ifndef PANTALON_H_
#define PANTALON_H_
#include "Prenda.h"
class Pantalon:public Prenda {
protected:
	bool largo;//Por defecto los pantalones son cortos
public:
	Pantalon();
	Pantalon(const char * talla,const char * color,double precio,bool largo);
	Pantalon(const Pantalon &pa);
	bool getLargo() const;
	void setLargo(bool largo);
	void imprimir();
	virtual ~Pantalon();
};

#endif /* PANTALON_H_ */
