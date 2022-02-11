import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.Scanner;

public class HiloEnviar extends Thread{
	
	Socket cliente = null;
	boolean seguir = true;
	
	
	
	public HiloEnviar(Socket cliente)
	{
		this.cliente = cliente;
	}
	
	public void run()
	{
		try {
			DataOutputStream dos = new DataOutputStream(cliente.getOutputStream());
			Scanner sc = new Scanner(System.in);
		while(seguir)
		{
		
			String texto = sc.nextLine();
			dos.writeUTF(texto);
			if(texto.equalsIgnoreCase("salir"))
				seguir = false;
		}
		
		sc.close();
		
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("salgo enviar");
		
	}
	
	public void terminar()
	{
		seguir = false;
		
	}

}
