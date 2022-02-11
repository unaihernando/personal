package principal;


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JTextField;
import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.DESKeySpec;
import javax.crypto.spec.IvParameterSpec;
import javax.swing.JButton;
import javax.swing.JFileChooser;

import java.awt.Color;
import javax.swing.JSeparator;
import javax.swing.JTextPane;
import java.awt.event.ActionListener;
import java.io.DataInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.security.InvalidAlgorithmParameterException;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import java.security.spec.InvalidKeySpecException;
import java.awt.event.ActionEvent;

public class VentanaDecodificar extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField txtFichero;
	private JTextField txtClave;
	private String path;
	private JLabel lblError;
	private JTextPane txtTexto;
	private JTextField textFieldFichero;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaDecodificar frame = new VentanaDecodificar();
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
	public VentanaDecodificar() {
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 702, 511);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblSelecciona = new JLabel("Selecciona fichero");
		lblSelecciona.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblSelecciona.setBounds(10, 27, 144, 17);
		contentPane.add(lblSelecciona);
		
		txtFichero = new JTextField();
		txtFichero.setEnabled(false);
		txtFichero.setEditable(false);
		txtFichero.setBounds(164, 27, 268, 20);
		contentPane.add(txtFichero);
		txtFichero.setColumns(10);
		
		textFieldFichero = new JTextField();
		textFieldFichero.setEditable(false);
		textFieldFichero.setBounds(247, 443, 306, 19);
		contentPane.add(textFieldFichero);
		textFieldFichero.setColumns(10);
		
		JButton btnEscoger = new JButton("...");
		btnEscoger.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JFileChooser jfc = new JFileChooser();
				jfc.showOpenDialog(null);
				path = jfc.getSelectedFile().getAbsolutePath(); //Se guarda el path por si se escoge un fichero fuera del directorio del proyecto
				txtFichero.setText(jfc.getSelectedFile().getName());
				textFieldFichero.setText(jfc.getSelectedFile().getName());
			}
		});
		btnEscoger.setBounds(442, 26, 144, 23);
		contentPane.add(btnEscoger);
		
		JLabel lblClave = new JLabel("Clave:");
		lblClave.setFont(new Font("Tahoma", Font.PLAIN, 14));
		lblClave.setBounds(10, 72, 144, 17);
		contentPane.add(lblClave);
		
		txtClave = new JTextField();
		txtClave.setBounds(164, 72, 268, 20);
		contentPane.add(txtClave);
		txtClave.setColumns(10);
		
		lblError = new JLabel("");
		lblError.setForeground(Color.RED);
		lblError.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblError.setBounds(10, 370, 666, 31);
		contentPane.add(lblError);
		
		JButton btnDecodificar = new JButton("Decodificar fichero");
		btnDecodificar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String clave = txtClave.getText().toString();
				if(clave.length() < 8) {
					lblError.setText("La clave debe tener como mínimo 8 carácteres");
				}
				else {
					desencriptar(clave);
				}
			}
		});
		btnDecodificar.setBounds(442, 71, 144, 23);
		contentPane.add(btnDecodificar);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(10, 119, 666, 2);
		contentPane.add(separator);
		
		txtTexto = new JTextPane();
		txtTexto.setBounds(10, 132, 666, 227);
		contentPane.add(txtTexto);
		
		JLabel lblFichero = new JLabel("Fichero decodificado:");
		lblFichero.setBounds(38, 440, 161, 24);
		contentPane.add(lblFichero);
		
		
	}
	
	private void desencriptar(String clave) {
		try {
			SecretKeyFactory skf = SecretKeyFactory.getInstance("DES");
			DESKeySpec clavEspec = new DESKeySpec(clave.getBytes());
			SecretKey claveSecreta = skf.generateSecret(clavEspec);
			
			File f = new File(path);
			DataInputStream dis = new DataInputStream(new FileInputStream(f));
			byte[] iv = dis.readNBytes(8);
			byte[] mensajeCodificado = dis.readAllBytes();
			
			Cipher cipher = Cipher.getInstance("DES/CBC/PKCS5Padding");
			IvParameterSpec dps = new IvParameterSpec(iv);
			cipher.init(Cipher.DECRYPT_MODE, claveSecreta, dps);
			byte[] mensajeDecodificado = cipher.doFinal(mensajeCodificado);
			
			String mensajeDec = new String(mensajeDecodificado, StandardCharsets.UTF_8);
			txtTexto.setText(mensajeDec);
			dis.close();
		}catch (InvalidKeySpecException | InvalidKeyException | InvalidAlgorithmParameterException | IllegalBlockSizeException | BadPaddingException e) {
			lblError.setText("Hubo un error durante la desencriptacion");
			e.printStackTrace();
	
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (NoSuchAlgorithmException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (NoSuchPaddingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
