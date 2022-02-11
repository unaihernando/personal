package principal;


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JScrollPane;
import javax.swing.JList;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;
import javax.swing.JPasswordField;
import javax.swing.JRootPane;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import java.awt.Color;

import org.apache.commons.net.ftp.FTP;
import org.apache.commons.net.ftp.FTPClient;
import org.apache.commons.net.ftp.FTPFile;

import java.awt.event.ActionListener;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.SocketException;
import java.awt.event.ActionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.event.ListSelectionEvent;

public class VentanaFTP extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField tFieldUs;
	private JTextField tFieldIP;
	private JPasswordField tPass;
	private JList<String> lista;
	private JScrollPane scrollPane;
	private FTPClient cl;
	private String fichero;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaFTP frame = new VentanaFTP();
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
	public VentanaFTP() {
		
		cl = new FTPClient();
		
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
		setBounds(100, 100, 628, 610);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		scrollPane = new JScrollPane();
		scrollPane.setBounds(25, 134, 269, 375);
		contentPane.add(scrollPane);
		JButton btnEliminar = new JButton("ELIMINAR");
		btnEliminar.setVisible(false);
		lista = new JList<String>();
		lista.addListSelectionListener(new ListSelectionListener() {
			public void valueChanged(ListSelectionEvent e) {
				fichero = (String) lista.getSelectedValue();
				btnEliminar.setVisible(true);
				
			}
		});
		scrollPane.setViewportView(lista);
		
		JLabel lblUsuario = new JLabel("Usuario:");
		lblUsuario.setBounds(25, 37, 75, 14);
		contentPane.add(lblUsuario);
		
		JLabel lblContrasena = new JLabel("Contraña:");
		lblContrasena.setBounds(25, 79, 75, 14);
		contentPane.add(lblContrasena);
		
		tFieldUs = new JTextField();
		tFieldUs.setBounds(110, 34, 184, 20);
		contentPane.add(tFieldUs);
		tFieldUs.setColumns(10);
		
		JLabel lblServidor = new JLabel("Servidor FTP");
		lblServidor.setBounds(304, 37, 137, 14);
		contentPane.add(lblServidor);
		
		tFieldIP = new JTextField();
		tFieldIP.setBounds(463, 35, 116, 20);
		contentPane.add(tFieldIP);
		tFieldIP.setColumns(10);
		
		tPass = new JPasswordField();
		tPass.setBounds(110, 76, 184, 20);
		contentPane.add(tPass);
		
		
		JLabel lblError = new JLabel("");
		lblError.setBounds(25, 522, 256, 41);
		lblError.setForeground(Color.red);
		contentPane.add(lblError);
		
		JButton btnSubir = new JButton("SUBIR");
		btnSubir.setEnabled(false);
		btnSubir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					cl.setFileType(FTP.BINARY_FILE_TYPE);
					BufferedInputStream in = new BufferedInputStream( new FileInputStream("subida.txt"));
					cl.storeFile("subida.txt", in);
					in.close();
					cargarLista();
					lblError.setText("");
				} catch (IOException e1) {
					e1.printStackTrace();
					lblError.setText("Error de subida de archivos");
					
				}
			}
		});
		btnSubir.setBounds(378, 131, 201, 23);
		contentPane.add(btnSubir);
		
		JButton btnDescargar = new JButton("DESCARGAR");
		btnDescargar.setEnabled(false);
		btnDescargar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(fichero != null ) { 
					try {
						cl.setFileType(FTP.BINARY_FILE_TYPE);
						BufferedOutputStream out = new BufferedOutputStream(new FileOutputStream(fichero));
						cl.retrieveFile(fichero, out);
						out.close();
						cargarLista();
						lblError.setText("");
				
					} catch (IOException e1) {
						e1.printStackTrace();
						lblError.setText("No se ha podido descargar");
					
					}
				}
			}
		});
		btnDescargar.setBounds(378, 164, 201, 23);
		contentPane.add(btnDescargar);
		
		JButton btnSalir = new JButton("SALIR");
		
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					cl.disconnect();
				} catch (IOException e1) {
					System.out.println(e1.getMessage());
					System.out.println("No se ha podido desconectar");
				}
				System.exit(0);
			}
		});
		btnSalir.setBounds(378, 233, 201, 23);
		contentPane.add(btnSalir);
		

		btnEliminar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					cl.deleteFile(fichero);
					lblError.setText("");
					cargarLista();
				} catch (IOException e1) {
					e1.printStackTrace();
					lblError.setText("Ha habido un error al eliminar el archivo");
				}
			}
		});
		btnEliminar.setBounds(378, 197, 201, 23);
		contentPane.add(btnEliminar);
		
		JButton btnConectar = new JButton("CONECTAR");
		btnConectar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String ip = tFieldIP.getText().toString();
				String us = tFieldUs.getText().toString();
				String pass = "";
				for(int i = 0; i < tPass.getPassword().length; i++) {
					pass = pass + tPass.getPassword()[i];
				}
				if(ip.equals("") || us.equals("") || pass.equals("")) {
					lblError.setText("Error, introduzca todos los datos");
				}else {
					try {
						
						cl.connect(ip);
						boolean conOK = cl.login(us, pass);
						if(conOK) {
							cargarLista();
							btnDescargar.setEnabled(true);
							btnSubir.setEnabled(true);
							btnEliminar.setVisible(true);
							lblError.setText("");
							btnConectar.setEnabled(false);
						}
						else {
							lblError.setText("No se ha conectado correctamente");
							cl.disconnect();
						}
					} catch (SocketException e1) {
						e1.printStackTrace();
						lblError.setText(e1.getMessage());
					} catch (IOException e1) {
						e1.printStackTrace();
						lblError.setText(e1.getMessage());
					}
				}
			}
		});
		btnConectar.setBounds(378, 75, 201, 23);
		contentPane.add(btnConectar);
		
		JRootPane rootPane = SwingUtilities.getRootPane(btnConectar); 
		rootPane.setDefaultButton(btnConectar);
	
		
	}
	
	private void cargarLista() {
	
		DefaultListModel<String> dlm = new DefaultListModel<String>();
		try {
			
			FTPFile[] archivos = cl.listFiles();
			for(int i = 0; i < archivos.length; i++) {
				if(!dlm.contains("/" + archivos[i].getName())) {
					if(archivos[i].isFile())
				
					dlm.addElement(archivos[i].getName());
				}
			}
			lista.setModel(dlm);
			} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
