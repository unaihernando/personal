#include <iostream>
#include "Usuario.h"
#include "Prenda.h"
#include "Sudadera.h"
#include "Camiseta.h"
#include "Pantalon.h"
#include "BD.h"
#include <string.h>
#include "Pedido.h"
#include "BasicFashion.h"
using namespace std;

void menuTalla(Prenda p){
	int opcion;

	cout<<"1)XS: "<<endl;
	cout<<"2)S: "<<endl;
	cout<<"3)M: "<<endl;
	cout<<"4)L: "<<endl;
	cout<<"Selecciona una opcion: "<<endl;

	cin>>opcion;
	if(opcion == 1){
		p.setTalla("XS");
	}else if(opcion == 2){
		p.setTalla("S");
	}else if(opcion == 3){
		p.setTalla("M");
	}else{
		p.setTalla("L");
	}
}

void menuColor(Prenda p){
	int opcion;
	cout<<"1)Rojo: "<<endl;
	cout<<"2)Negro: "<<endl;
	cout<<"3)Blanco: "<<endl;
	cout<<"4)Azul: "<<endl;
	cout<<"Selecciona una opcion: "<<endl;

	cin>>opcion;
	if(opcion == 1){
		p.setColor("ROJO");
	}else if(opcion == 2){
		p.setColor("NEGRO");
	}else if(opcion == 3){
		p.setColor("BLANCO");
	}else{
		p.setColor("AZUL");
	}
}
int main(){
	BasicFashion bf();
	BD bd("BaseDeDatos.db");
	bd.crearBD();
	bd.abrirBD();
	//bd.insertarUsuario("111A","a");
	//bd.insertarUsuario("a","a");
	bd.abrirBD();
	bd.mostrarTodosLasPersonas();
	char usu[10],con[10];
	int resul ;
	do{
		cout<<"Introduce nombre de usuario: ";
		cin>>usu;
		cout<<"Introduce la contraseña: ";
		cin>>con;
		resul = bd.comprobarLogin(usu,con);
		if(resul == 0)
			cout<<"El nick no es correcto"<<endl;
		else if(resul==1)
			cout<<"Contreña incorrecta"<<endl;
		else{
			cout<<"Usuario logeado"<<endl;
			Usuario u(usu, con);
			Prenda ** prendas;
			Pedido p(&u,prendas,0);
			int opcion2;
			char opcion3;
			do{
				cout<<"Que prenda quieres comprar : "<<endl;
				cout<<"1)CAMISETA: "<<endl;
				cout<<"2)SUDADERA: "<<endl;
				cout<<"3)PANTALON: "<<endl;
				cout<<"4)Salir: "<<endl;
				cout<<"Selecciona una opcion: "<<endl;
				cin>>opcion2;
				if(opcion2 == 1){
					Camiseta c;
					int opcionMangaCamiseta;
					cout<<"MANGA: "<<endl;
					cout<<"1)CORTA "<<endl;
					cout<<"2)LARGA"<<endl;
					cout<<"Selecciona una opcion: "<<endl;
					cin>>opcionMangaCamiseta;
					if(opcionMangaCamiseta == 1){
						c.setMangaLarga(false);
					}else{
						c.setMangaLarga(true);
					}
					menuTalla((Prenda)c);
					menuColor((Prenda)c);
					p.anyadirPrenda(&c);

				}else if(opcion2 == 2){
					Sudadera s;
					int opcionApertura,opcionCapucha;
					cout<<"APERTURA: "<<endl;
					cout<<"1)ABIERTA "<<endl;
					cout<<"2)CERRADA"<<endl;
					cout<<"Selecciona una opcion: "<<endl;
					cin>>opcionApertura;
					if(opcionApertura == 1){
						s.setCerrada(false);
					}else{
						s.setCerrada(true);
					}
					cout<<"CAPUCHA: "<<endl;
					cout<<"1)SIN CAPUCHA "<<endl;
					cout<<"2)CON CAPUCHA"<<endl;
					cout<<"Selecciona una opcion: "<<endl;
					cin >> opcionCapucha;
					if(opcionCapucha == 1){
						s.setCapucha(false);

					}else{
						s.setCapucha(true);
					}
					menuTalla((Prenda)s);
					menuColor((Prenda)s);
					p.anyadirPrenda(&s);
				}else{
					Pantalon pa;
					int opcion;
					cout<<"MANGA: "<<endl;
					cout<<"1)CORTA "<<endl;
					cout<<"2)LARGA"<<endl;
					cout<<"Selecciona una opcion: "<<endl;
					cin>>opcion;
					if(opcion == 1){
						pa.setLargo(false);
					}else{
						pa.setLargo(true);
					}
					menuTalla((Prenda)pa);
					menuColor((Prenda)pa);
					p.anyadirPrenda(&pa);
				}
				cout<<"Desea seguir comprando (s/n)?"<<endl;
				cin>>opcion3;
			}while(opcion3 != 'n');
			cout<<"Su pedido ha terminado"<<endl;
		}
	}while(resul!=2);
	return 0;
}
