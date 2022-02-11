import java.io.DataOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {
	


	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			final int TAM= 1024;
			
			ServerSocket server = new ServerSocket(5003);
			System.out.println("Servidor a la escucha");
			Socket cliente = server.accept();
			
			DataOutputStream dos = new DataOutputStream(cliente.getOutputStream());
			
			File archivoE = new File("faro.jpg");
			int tam = (int) archivoE.length();
			dos.writeInt(tam);
			
			// Calculamos el numero de paquetes. TAM_PAQUETE es una constante entera.
			int veces = (int) (tam / TAM);
			// Calculamos el tamaño del ultimo paquete de tamaño variable
			int resto = (int) (tam - veces * TAM);
			// Declaramos un array de bytes para almacenar los bytes leídos del fichero
			byte leido[] = new byte[TAM];
			InputStream f = new FileInputStream(archivoE);
			// Comienza el proceso de lectura del fichero y escritura del mismo en el socket
			for (int i = 0; i < veces; i++) {
			f.read(leido); // Leemos un paquete de tamaño TAM_PAQUETE bytes
			dos.write(leido); // Lo escribimos en el Socket
			}
			if (resto != 0) {
			f.read(leido, 0, resto); // Leemos el ultimo paquete (resto bytes)
			dos.write(leido, 0, resto); // Lo escribimos en el socket
			}
			f.close();
			System.out.println("Foto enviada");
			cliente.close();
			server.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
