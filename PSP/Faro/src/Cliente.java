
import java.awt.EventQueue;
import java.io.DataInputStream;

import java.io.FileOutputStream;
import java.io.IOException;

import java.net.Socket;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;

public class Cliente extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Cliente frame = new Cliente();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public Cliente() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);
		String urlFoto="no-disponible.jpg";
		try {
			Socket cliente = new Socket("localhost",5003);
			final int TAM = 1024;
			DataInputStream dis = new DataInputStream(cliente.getInputStream());
			
			int tam = dis.readInt();
			
			int veces = (int) (tam / TAM);
			// Calculamos el tamaño del ultimo paquete de tamaño variable
			int resto = (int) (tam - veces * TAM);
			// Declaramos un array de bytes para almacenar los bytes leídos del fichero
			byte leido[] = new byte[TAM];
			
			
			FileOutputStream f = new FileOutputStream("faroRecibido.jpg");
			
			
			for (int i = 0; i < veces; i++) {
				dis.read(leido); // Leemos del socket
			
				f.write(leido); // Escribimos en el stream que representa nuestro fichero en disco
				}
				if (resto != 0) {
				dis.read(leido, 0, resto); // Leemos el ultimo paquete (resto bytes)
				f.write(leido, 0, resto); //Lo escribimos en el stream que representa nuestro fichero
				}
				
				
				f.close();
				cliente.close();
				
				
				urlFoto="faroRecibido.jpg"; //cli.descargarImagen();
						
				
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
		System.out.println("Problema con el servidor: "+e.getMessage());
		}
		
		
		ImageIcon fotoE=new ImageIcon(urlFoto);
		JLabel lblNewLabel=new JLabel(fotoE);
		
		lblNewLabel.setBounds(34, 27, 300, 206);
		contentPane.add(lblNewLabel);

	}
}
