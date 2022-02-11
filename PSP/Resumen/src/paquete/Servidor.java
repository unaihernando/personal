package paquete;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Servidor {

	private final int PUERTO = 4000;

	public static void main(String[] args) {

		Servidor s1 = new Servidor();
		s1.iniciar();
	}

	public void iniciar() {

		ServerSocket servidor = null;
		Socket cliente = null;
		ObjectInputStream entrada = null;
		ObjectOutputStream salida = null;

		try {
			
			servidor = new ServerSocket(PUERTO);
			System.out.println("Esperando conexiones del cliente...");
			cliente = servidor.accept();
			System.out.println("Cliente conectado");
			salida = new ObjectOutputStream(cliente.getOutputStream());
			entrada = new ObjectInputStream(cliente.getInputStream());
			salida.writeObject("Cuál es la frase?");
			String frase = entrada.readObject().toString();
			System.out.println(frase);
			salida.writeObject("Cuál es la función resumen?");
			String resumenCliente = entrada.readObject().toString();
			String resumenServidor = resumen(frase);
			System.out.println(resumenCliente);
			System.out.println(resumenServidor);
					
			if (resumenCliente.equals(resumenServidor)) {
				
				salida.writeObject("La función es correcta");
				
			} else {
				
				salida.writeObject("La función es incorrecta");
			}

		} catch (IOException e) {
			System.out.println("Error: " + e.getMessage());
		} catch (Exception e) {
			System.out.println("Error: " + e.getMessage());
		} finally {
			try {
				if (servidor != null)
					servidor.close();
				if (cliente != null)
					cliente.close();
				if (entrada != null)

					entrada.close();
				if (salida != null)
					salida.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
			System.out.println("Fin servidor");
		}

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
