import java.io.IOException;
import java.net.Socket;

public class Cliente {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			Socket cliente = new Socket("localhost",5004);
			System.out.println("Cliente conectado");
			HiloEnviar hiloE = new HiloEnviar(cliente);
			hiloE.start();
			HiloRecibir hiloR = new HiloRecibir(cliente);
			hiloR.start();
			
			while(hiloE.isAlive() && hiloR.isAlive())
			{
				
			}
			System.out.println("hola he terminado");
			hiloE.terminar();
			hiloR.terminar();
			
			cliente.close();
			
			
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}

}
