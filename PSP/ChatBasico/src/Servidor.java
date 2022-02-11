import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		try {
			ServerSocket servidor = new ServerSocket(5004);
			System.out.println("Esperando clientes");
			Socket cli = servidor.accept();
			
			HiloEnviar hiloE = new HiloEnviar(cli);
			hiloE.start();
			HiloRecibir hiloR = new HiloRecibir(cli);
			hiloR.start();
			
			
			while(hiloE.isAlive() && hiloR.isAlive())
			{
				
			}
			System.out.println("hola he terminado");
			hiloE.terminar();
			hiloR.terminar();
			
			
			cli.close();
			servidor.close();
			
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
