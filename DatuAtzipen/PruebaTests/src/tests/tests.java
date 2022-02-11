package tests;

import static org.junit.jupiter.api.Assertions.*;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.util.Scanner;

import org.junit.jupiter.api.Test;

import program.Prueba1;

public class tests {

	@Test
	void testSuma() {
	 	Prueba1 pr = new Prueba1();
	 	int resul = pr.Suma(3,7);
		 assertEquals(10, resul);
	}
	
	@Test
	public void testRecogerOpcionFloat4() {
		Prueba1 pr = new Prueba1();
		
		float resultadoFloat;
		String texto = "Introduzca un número";
		float valorMin = 0f;
		float valorMax = 10f;
		String input = "a \n 4 \n";
		InputStream in = new ByteArrayInputStream(input.getBytes());
		System.setIn(in);
	    Scanner reader = new Scanner(System.in); 
	    resultadoFloat = pr.RecogerOpcionFloat(reader, valorMin, valorMax,texto);
	    assertEquals(4, resultadoFloat, 0.0);
	
	}
	
	@Test
	public void testRecogerOpcionFloat2() {
		Prueba1 pr = new Prueba1();

		float resultadoFloat;
		String texto = "Introduzca un número";
		float valorMin = 0f;
		float valorMax = 10f;
		String input = "15 \n 4 \n";
		InputStream in = new ByteArrayInputStream(input.getBytes());
		System.setIn(in);
	    Scanner reader = new Scanner(System.in); 
	    resultadoFloat = pr.RecogerOpcionFloat(reader, valorMin, valorMax,texto);
	    assertEquals(4, resultadoFloat, 0.0);
	
	}

}
