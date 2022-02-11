import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;
import java.net.UnknownHostException;

public class Cliente {

	public static void main(String[] args) {
		
		final int puerto = 5000;
		// TODO Auto-generated method stub
			try {
				Socket cliente = new Socket("localhost",puerto);
				System.out.println("Conexión realizada con el servidor");
				
				OutputStream os = cliente.getOutputStream();
				DataOutputStream dos = new DataOutputStream(os);
				dos.writeUTF("Hola servidor, soy un cliente");
				
				InputStream is =cliente.getInputStream();
				DataInputStream dis = new DataInputStream(is);
				String mensServer = dis.readUTF();
				System.out.println(mensServer);
				
				dis.close();
				dos.close();
				
				cliente.close();
				
				
				
			} catch (UnknownHostException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
	}

}
