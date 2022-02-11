import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		final int puerto = 5002;
		
		try {
			ServerSocket servidor = new ServerSocket(puerto);
			System.out.println("Servidor iniciado");
			Socket cliente = servidor.accept();
			
			Persona p = new Persona();
			p.setNif("16078123X");
			p.setNombre("Pepito");
			p.setApellido("Grillo");
			p.setFechaNacimento(1990,12,12);
			p.setGenero('M');
			
			ObjectOutputStream oos = new ObjectOutputStream( cliente.getOutputStream());
			oos.writeObject(p);
			
			ObjectInputStream ois = new ObjectInputStream(cliente.getInputStream());
			Persona p2 = (Persona) ois.readObject();
			
			System.out.println(p2.toString());
			
			oos.close();
			ois.close();
			cliente.close();
			servidor.close();
			
			
		} catch (IOException | ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}

}
