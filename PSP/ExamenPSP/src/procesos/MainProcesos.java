package procesos;

import java.io.File;
import java.io.IOException;
import java.io.OutputStream;
import java.util.Scanner;

public class MainProcesos {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
			
		ProcessBuilder pb = new ProcessBuilder("java","procesos.SumadorRestador");
		pb.directory(new File("bin"));
		pb.redirectOutput(new File("salida.txt"));
		Scanner sc = new Scanner(System.in);
		Process p;
		try {
			p = pb.start();
		
		System.out.println("PID: "+p.pid());
		System.out.println("PID Padre: "+p.toHandle().parent().get().pid());
		
		System.out.println("¿Qué quiere hacer?");
		System.out.println("1-. Sumar");
		System.out.println("2-. Restar");
		int i = sc.nextInt();
		System.out.println("Operador 1:");
		int op1 = sc.nextInt();
		System.out.println("Operador 2:");
		int op2 = sc.nextInt();
		
		OutputStream os = p.getOutputStream();
		
		String texto = i + "\n " + op1 + "\n "+ op2 + "\n";
		os.write(texto.getBytes());
		os.flush();
		
		
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		sc.close();
	}

}
