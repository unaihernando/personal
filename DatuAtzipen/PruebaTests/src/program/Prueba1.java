package program;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Prueba1 {

	
	public int Suma(int par1, int par2) {
		int resul = par1+ par2;
		return resul;
	}
	


	public float RecogerOpcionFloat(Scanner reader, float valorMin, float valorMax, String texto) {
		// TODO Auto-generated method stub
		//Declaracion e inicialización de variables
				float opcion = 0;
				boolean opcionCorrecta = false; 
				//Inicio de programa
				while(!opcionCorrecta)
				{
					try
					{
						System.out.println(texto);
						opcion=reader.nextFloat();
						while(opcion < valorMin || opcion > valorMax)
						{
							System.out.println("Introduce un valor numérico entre "+valorMin+" y "+valorMax);
							opcion=reader.nextFloat();
						}
						reader.nextLine();
						opcionCorrecta = true;
					}
					catch(InputMismatchException ex)
					{
						System.out.println("Introduce un valor numérico entre "+valorMin+" y "+valorMax);
						reader.nextLine();
					}
					
				}
				return opcion;
			}
	}
