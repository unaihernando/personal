package Juego_Ejer2;

import java.util.Scanner;

public class Aplicacion {
	static Scanner sc = new Scanner (System.in);
	public static void main(String[] args) {
		// TODO Auto-generated method stub
				
		int vidas= 4;
		
		
		int numeroRandom = (int) (Math.random()*10);
		JuegoAdivinaNumero juego = new JuegoAdivinaNumero(vidas, numeroRandom);
		numeroRandom = (int) (Math.random()*10);
		if(numeroRandom%2!=0) 
			numeroRandom = numeroRandom+1;
		JuegoAdivinaPar juegoPar = new JuegoAdivinaPar(vidas, numeroRandom);
		numeroRandom = (int) (Math.random()*10);
		if(numeroRandom%2==0) 
			numeroRandom = numeroRandom-1;
		JuegoAdivinaImpar juegoImpar = new JuegoAdivinaImpar(vidas, numeroRandom);
		
		juego.Juega();
		juegoPar.Juega();
		juegoImpar.Juega();


	}
	
}
	
