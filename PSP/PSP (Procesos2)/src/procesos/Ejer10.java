package procesos;

import java.io.File;
import java.io.IOException;

public class Ejer10 {

	public static void main(String[] args) {
		ProcessBuilder pb = new ProcessBuilder("java", "procesos.Frame1");
		pb.directory(new File("bin"));
		Process p = null;
		try {
			p = pb.start();
		} catch (IOException e) {
			e.printStackTrace();
		}
		try {
			p.waitFor();
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		System.out.println("Valor de salida: " + p.exitValue());

	}

}
