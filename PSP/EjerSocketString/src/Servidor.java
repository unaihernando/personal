import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.*;
public class Servidor {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		final int puerto = 5000;
		
		try {
			ServerSocket server = new ServerSocket(puerto);
			
			for(int i =0;i<3;i++)
			{
				Socket cli = server.accept();
				InputStream is =cli.getInputStream();
				DataInputStream dis = new DataInputStream(is);
				String mensCliente = dis.readUTF();
				System.out.println("Recibido: "+mensCliente);
				
				OutputStream os = cli.getOutputStream();
				DataOutputStream dos = new DataOutputStream(os);
				dos.writeUTF("saludos desde servidor al cliente nº"+(i+1));
				
				dos.close();
				dis.close();
				cli.close();
				
				
				
			}
			System.out.println("Demasiados clientes por hoy");
			
			server.close();
			
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}

}
