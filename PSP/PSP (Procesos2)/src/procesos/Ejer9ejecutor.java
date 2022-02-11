package procesos;

import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.util.Scanner;

public class Ejer9ejecutor {

	private static Scanner sc = new Scanner(System.in);

	public static void main(String[] args) {

		for (int i = 0; i < 5; i++) {
			ProcessBuilder pb = new ProcessBuilder("java", "procesos.LeerTexto");
			pb.directory(new File("bin"));
			Process p = null;
			try {
				p = pb.start();
			} catch (IOException e) {
				e.printStackTrace();
			}
			System.out.println("Introduce una cadena....");

			OutputStream os = p.getOutputStream();
			try {
				os.write((cogerString() + "\n").getBytes());
				os.flush();
			} catch (IOException e) {
				e.printStackTrace();
			}

			InputStream er = p.getInputStream();
			BufferedReader brer = new BufferedReader(new InputStreamReader(er));
			String line = null;
			try {
				while ((line = brer.readLine()) != null)
					System.out.println(line);
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

	public static String cogerString() { // Coge por teclado un String
		String cadena = sc.nextLine();
		return cadena;
	}

}
