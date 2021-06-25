
#ifndef USUARIO_H_
#define USUARIO_H_

class Usuario {
	char * contrasenya;
	char * dni;

public:
	Usuario();
	Usuario(const char * dni,const char * contrasenya);
	Usuario (const Usuario &u);
	char * getContrasenya() const;
	char * getDni() const;
	void setContrasenya(char * contrasenya);
	void setDni(char * dni);
	void imprimir();
	virtual ~Usuario();
};

#endif /* USUARIO_H_ */
