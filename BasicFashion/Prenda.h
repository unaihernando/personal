

#ifndef PRENDA_H_
#define PRENDA_H_

class Prenda {
protected:
	char * talla;
	char * color;
	double precio;
public:
	Prenda();
	Prenda(const char * talla,const char * color,double precio);
	Prenda(const Prenda& p);
	virtual char * getTalla() const;
	virtual char * getColor() const;
	virtual float getPrecio() const;
	virtual void setTalla(const char * talla);
	virtual void setColor(const char * color);
	virtual void setPrecio(double precio);
	virtual void imprimir();
	virtual ~Prenda();
};

#endif /* PRENDA_H_ */
