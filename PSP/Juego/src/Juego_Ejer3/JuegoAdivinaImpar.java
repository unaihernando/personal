package Juego_Ejer3;

import java.util.Scanner;

public class JuegoAdivinaImpar extends JuegoAdivinaNumero implements Jugable {
	public static Scanner sc = new Scanner (System.in);
private int numeroAdivinar;
	
	public JuegoAdivinaImpar(int numVidas, int numero) {
		super(numVidas,numero);
	}

	@Override
	public void Juega() {
		// TODO Auto-generated method stub
		
		
		int numero = -1;
		super.ReiniciaPartida();
		int vidas = 0;
		boolean validado = true;
		do {
			do{
				System.out.println("Escribe un numero del 0 al 10");
				numero = sc.nextInt();
				validado = ValidaNumero(numero);
			} while (validado == false);
			
			if(numero == this.numeroAdivinar) {
				System.out.println("Acertaste!!");
				super.ActualizaRecord();
			}
			else 
			{
				super.QuitaVida();
				if (numero > this.numeroAdivinar)
					System.out.println("El número es mas bajo");
				else
				System.out.println("El número es mas alto");
			}
			vidas = super.getNumVidas();
		}while (numero != this.numeroAdivinar && vidas >0);

	}
	
	public boolean ValidaNumero(int numero) {
		boolean validado = true;
		if (numero%2 == 0) {
			validado = false;
			System.out.println("El número debe ser impar");
		} 
		return validado;
		
	}
	
	public void MuestraNombre() {
		System.out.println("3- Adivina un número impar"); 

		
	}
	
	public void MuestraInfo() {
		System.out.println("Debes adivinar un número impar");
	}
}
