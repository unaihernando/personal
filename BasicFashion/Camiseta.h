
#ifndef CAMISETA_H_
#define CAMISETA_H_
#include "Prenda.h"

class Camiseta:public Prenda {
protected:
	bool mangaLarga;//Por defecto la camiseta sera de manga corta
public:
	Camiseta();
	Camiseta(const char * talla,const char * color,double precio,bool mangaLarga);
	Camiseta(const Camiseta &c);
	bool getMangaLarga() const;
	void setMangaLarga(bool mangaLarga);
	void imprimir();
	virtual ~Camiseta();
};

#endif /* CAMISETA_H_ */
