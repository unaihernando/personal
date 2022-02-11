package paquete;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Scanner;

public class Cliente {
	private final int PUERTO = 4000;
	private final String IP = "localhost";
	
	public static void main(String[] args) {
		
		Cliente c1 = new Cliente();
		c1.iniciar();
		
		}

	public void iniciar() {
		
		Scanner teclado = new Scanner (System.in);
		Socket cliente = null;
		ObjectInputStream entrada = null;
		ObjectOutputStream salida = null;
		
		try {
			String frase = new String();
			String resumenCliente;
			cliente = new Socket(IP, PUERTO);
			entrada = new ObjectInputStream(cliente.getInputStream());
			salida = new ObjectOutputStream(cliente.getOutputStream());
			System.out.println("Conexión realizada con servidor");
			System.out.println(entrada.readObject());
			frase = teclado.nextLine();
			salida.writeObject(frase);
			System.out.println(entrada.readObject());
			System.out.println(resumen(frase));
			resumenCliente = teclado.nextLine();
			salida.writeObject(resumenCliente);
			System.out.println(entrada.readObject());
				
		} catch (IOException e) {
			System.out.println("Error: " + e.getMessage());
		} catch (Exception e) {
			System.out.println("Error: " + e.getMessage());
		} finally {
			try {
				if (cliente != null)
					cliente.close();
				if (entrada != null)
					entrada.close();
				if (salida != null)
					salida.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
			System.out.println("Fin cliente");
		}
		
		teclado.close();
	}
	
	public String resumen(String texto) {
		
		String resumenString = new String();
		
		try {
			MessageDigest md = MessageDigest.getInstance("SHA");
			byte dataBytes[] = texto.getBytes();
			md.update(dataBytes);
			byte resumen[] = md.digest();
			resumenString = new String(resumen);
		} catch (NoSuchAlgorithmException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return resumenString;

	}

}
