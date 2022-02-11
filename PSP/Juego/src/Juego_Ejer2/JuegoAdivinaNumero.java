package Juego_Ejer2;

import java.util.Scanner;

public class JuegoAdivinaNumero extends Juego{
	public static Scanner sc = new Scanner (System.in);
	private int numeroAdivinar;

	public JuegoAdivinaNumero(int numVidas, int numeroAdivinar) {
		super(numVidas);
		this.numeroAdivinar = numeroAdivinar;
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
		return validado;
		
	}
	
	
}
