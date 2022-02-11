package procesos;

import java.io.BufferedReader;
import java.io.InputStreamReader;

public class LeerTexto {
	public static void main(String[] args) {
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader br = new BufferedReader(in);
		String texto;
		try {
			texto = br.readLine();

			System.out.println("Cadena escrita: " + texto);
			in.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}