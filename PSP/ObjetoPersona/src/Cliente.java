import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;

public class Cliente {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		try {
			Socket cliente = new Socket("localhost",5002);
			System.out.println("Cliente conectado");
			
			ObjectInputStream ois = new ObjectInputStream(cliente.getInputStream());
			Persona p2 = (Persona) ois.readObject();
			
			p2.setNombre("Carmen");
			p2.setFechaNacimento(1983, 1, 1);
			
			ObjectOutputStream oos = new ObjectOutputStream( cliente.getOutputStream());
			oos.writeObject(p2);
			System.out.println("Persona enviada");
			
			oos.close();
			ois.close();
			
			cliente.close();
			
			
			
		} catch (IOException | ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}

}
