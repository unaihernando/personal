package Juego_Ejer3;

import java.util.Scanner;


public class Aplicacion {
	static Scanner sc = new Scanner (System.in);
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		char cont = 'n';		
		do {
			Jugable juego = EligeJuego();
			juego.MuestraNombre();
			juego.MuestraInfo();
			juego.Juega();
			
			do {
				System.out.println("¿Quiere continuar?");
				cont = sc.next().charAt(0);
			} while ((cont!='S') && (cont!='s') && (cont!='N') && (cont!='n'));
			
		} while((cont=='S') || (cont=='s'));




	}
	

	
	public static Jugable EligeJuego() {
		int vidas= 4;
		int elegido = 0;
		Jugable juegoElegido = null;
		int numeroRandom = (int) (Math.random()*10);
		JuegoAdivinaNumero juego =new JuegoAdivinaNumero(vidas, numeroRandom);
		numeroRandom = (int) (Math.random()*10);
		if(numeroRandom%2!=0) 
			numeroRandom = numeroRandom+1;
		JuegoAdivinaPar juegoPar = new JuegoAdivinaPar(vidas, numeroRandom);
		numeroRandom = (int) (Math.random()*10);
		if(numeroRandom%2==0) 
			numeroRandom = numeroRandom-1;
		JuegoAdivinaImpar juegoImpar = new JuegoAdivinaImpar(vidas, numeroRandom);
		
		Jugable juegos[] = new Jugable[3];
		
		juegos[0] = juego;
		juegos[1] = juegoPar;
		juegos[2] = juegoImpar;
		
		do {
			System.out.println("Elige un juego: ");
			juegos[0].MuestraNombre();
			juegos[1].MuestraNombre();
			juegos[2].MuestraNombre();
			elegido = sc.nextInt();
				
		} while(elegido < 1 || elegido > 3);

		juegoElegido =juegos[elegido-1];
		return juegoElegido;
	}

}
