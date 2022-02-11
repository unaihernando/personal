package principal;


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.Color;

import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.DESKeySpec;
import javax.swing.JButton;
import javax.swing.JTextPane;
import java.awt.event.ActionListener;

import java.io.DataOutputStream;
import java.io.File;

import java.io.FileOutputStream;
import java.io.IOException;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import java.security.spec.InvalidKeySpecException;
import java.awt.event.ActionEvent;

public class VentanaCodificar extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField txtNombre;
	private JTextField txtClave;
	private JTextPane txtTexto;
	private JLabel lblError;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaCodificar frame = new VentanaCodificar();
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
	public VentanaCodificar() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 630, 305);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		txtNombre = new JTextField();
		txtNombre.setBounds(98, 51, 159, 20);
		contentPane.add(txtNombre);
		txtNombre.setColumns(10);
		
		JLabel lblNombre = new JLabel("Nombre");
		lblNombre.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblNombre.setBounds(10, 49, 78, 20);
		contentPane.add(lblNombre);
		
		lblError = new JLabel("");
		lblError.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblError.setForeground(Color.RED);
		lblError.setBounds(45, 225, 378, 35);
		contentPane.add(lblError);
		
		JLabel lblClave = new JLabel("Clave");
		lblClave.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblClave.setBounds(267, 51, 78, 20);
		contentPane.add(lblClave);
		
		txtClave = new JTextField();
		txtClave.setColumns(10);
		txtClave.setBounds(312, 51, 159, 20);
		contentPane.add(txtClave);
		
		JButton btnEncriptar = new JButton("Encriptar");
		btnEncriptar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				boolean correcto = true;
				String nombre = txtNombre.getText().toString();
				if(nombre.equals("")) {
					lblError.setText("Hay que poner un nombre el fichero de guardado");
					correcto = false;
				}
				String clave = txtClave.getText().toString();
				if(clave.length() < 8) {
					lblError.setText("La clave tiene que tener 8 carácteres mínimo");
					correcto = false;
				}
				if(correcto) {
					encriptar(nombre, clave);
					lblError.setText("Encriptado correcto");
				}
			}
		});
		btnEncriptar.setBounds(499, 49, 89, 23);
		contentPane.add(btnEncriptar);
		
		txtTexto = new JTextPane();
		txtTexto.setBounds(45, 92, 426, 112);
		contentPane.add(txtTexto);
		
		
	}
	
	private void encriptar(String nombre, String clave) {
		try {
			SecretKeyFactory skf = SecretKeyFactory.getInstance("DES");
			DESKeySpec clavEspec = new DESKeySpec(clave.getBytes());
			SecretKey claveSecreta = skf.generateSecret(clavEspec);
			
			Cipher cipher = Cipher.getInstance("DES/CBC/PKCS5Padding");
			cipher.init(Cipher.ENCRYPT_MODE, claveSecreta);
			byte[] mensajeCodificado = cipher.doFinal(txtTexto.getText().toString().getBytes());
			byte[] iv = cipher.getIV();
			
			File f = new File(nombre + ".txt");
			DataOutputStream dos = new DataOutputStream(new FileOutputStream(f));
			dos.write(iv);
			dos.write(mensajeCodificado);
			lblError.setText("");
			dos.close();
		}catch (InvalidKeySpecException | NoSuchAlgorithmException | InvalidKeyException | NoSuchPaddingException | IllegalBlockSizeException | BadPaddingException | IOException e) {
			lblError.setText("Se ha generado un error");
			e.printStackTrace();
		}
		
		
		
	}
}
