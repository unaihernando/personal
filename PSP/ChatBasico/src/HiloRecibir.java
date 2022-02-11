import java.io.DataInputStream;
import java.io.IOException;
import java.net.Socket;

public class HiloRecibir extends Thread{
	
	Socket cliente = null;
	boolean seguir = true;
	
	public HiloRecibir(Socket cliente)
	{
		this.cliente = cliente;
	}
	
	public void run()
	{
		DataInputStream dis;
		try {
			dis = new DataInputStream(cliente.getInputStream());
		
		while(seguir)
		{
		
			String texto;
			
				texto = dis.readUTF();
			
			System.out.println(texto);
			
			if(texto.equalsIgnoreCase("salir"))
				seguir = false;
			
			
		}
		System.out.println("salgo recibir");
		
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void terminar()
	{
		seguir = false;
		System.exit(0);
	}

}
