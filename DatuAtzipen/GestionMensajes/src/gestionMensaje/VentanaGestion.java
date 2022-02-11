package gestionMensaje;


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.awt.event.ActionEvent;

public class VentanaGestion extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private ArrayList<Mensaje> mensajes = new ArrayList<Mensaje>();
	private String path = "Mensajes.txt";
	 File fic = new File(path);
     BufferedReader fichero = null;
     Calendar cal = Calendar.getInstance();
    
     String var;
     Date fecha;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaGestion frame = new VentanaGestion();
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
	public VentanaGestion() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		JButton btnCargar = new JButton("Cargar mensajes");
		btnCargar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				mensajes = new ArrayList<Mensaje>();
				try {
					fichero = new BufferedReader(new FileReader(fic));
					Mensaje men = new Mensaje();
			      
			     
			      String linea; 
			      while((linea = fichero.readLine())!=null) 
			      {
			        if(linea.contains("****"))
			        {
			        	mensajes.add(men);
			        	men = new Mensaje();
			        }
			        else
			        {
			    	  System.out.println(linea);
			    	  var = linea.split(":")[1];
			    	  if(linea.contains("fecha"))
			    	  {
			    		  cal.set(Calendar.YEAR,Integer.valueOf(var.split("-")[0]));
			    		  cal.set(Calendar.MONTH,Integer.valueOf(var.split("-")[1])-1);
			    		  cal.set(Calendar.DAY_OF_MONTH,Integer.valueOf(var.split("-")[2]));
			    		  fecha = cal.getTime();
			    	  }
			    	  if(linea.contains("hora"))
			    	  {
			    		  cal.set(Calendar.HOUR_OF_DAY,Integer.valueOf(var));
			    		  cal.set(Calendar.MINUTE,Integer.valueOf(linea.split(":")[2]));
			    		  fecha = cal.getTime();
			    		  men.setFecha(fecha);
			    		  
			    	  }
			    	  if(linea.contains("de:"))
			    		  men.setDe(var);
			    	  if(linea.contains("para:"))
			    		  men.setPara(var);
			    	  if(linea.contains("asunto:"))
			    		  men.setAsunto(var);
			    	  if(linea.contains("contenido:"))
			    		  men.setContenido(var);
			        
			        }
			      }
			      
				} catch (FileNotFoundException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				} catch (IOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				} 
				finally {
			      try {
					fichero.close();
				} catch (IOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				} 
				}
				JOptionPane.showMessageDialog(null, "Se han cargado " + mensajes.size()+ " mensajes");
			}
		});
		btnCargar.setBounds(34, 41, 111, 31);
		contentPane.add(btnCargar);
		
		JButton btnAd = new JButton("A\u00F1adir mensajes");
		btnAd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				NuevoMensaje nmensaje = new NuevoMensaje(mensajes);
				nmensaje.setVisible(true);
			}
		});
		btnAd.setBounds(34, 161, 111, 21);
		contentPane.add(btnAd);
		
		JButton btnGuardar = new JButton("Guardar mensajes");
		btnGuardar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				DateFormat formatoFecha = new SimpleDateFormat("yyyy-MM-dd");
				DateFormat formatoHora = new SimpleDateFormat("hh:mm:ss");
				try{      
				      BufferedWriter fichero = new BufferedWriter
				    		  (new FileWriter(path));
				      for (Mensaje mensa : mensajes) {
				    	  
					    fichero.write("fecha:"+formatoFecha.format(mensa.getFecha())); 
					    fichero.newLine();
					    fichero.write("hora:"+formatoHora.format(mensa.getFecha())); 
					    fichero.newLine();
					    fichero.write("para:"+mensa.getPara()); 
					    fichero.newLine();
					    fichero.write("de:"+mensa.getDe()); 
					    fichero.newLine();
					    fichero.write("asunto:"+mensa.getAsunto()); 
					    fichero.newLine();
					    fichero.write("contenido:"+mensa.getContenido()); 
					    fichero.newLine();
					    fichero.write("******************"); 
					    fichero.newLine();
				      }
				      fichero.close(); 
				      }
					catch (FileNotFoundException fn ){                      
				               System.out.println("No se encuentra el fichero");}
					catch (IOException io) {
				               System.out.println("Error de E/S ");}
				
				JOptionPane.showMessageDialog(null,
						"Los mensajes en memoria, han sido guardados en el fichero MENSAJES.TXT",
						"éxito!",
						JOptionPane.INFORMATION_MESSAGE);
			}
		});
		btnGuardar.setBounds(279, 40, 122, 32);
		contentPane.add(btnGuardar);
		
		JButton btnImp = new JButton("Imprimir mensajes");
		btnImp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ListadoMensaje lista = new ListadoMensaje(mensajes);
				lista.setVisible(true);
			}
		});
		btnImp.setBounds(279, 93, 122, 21);
		contentPane.add(btnImp);
		
		JButton btnSalir = new JButton("Salir");
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnSalir.setBounds(316, 213, 85, 21);
		contentPane.add(btnSalir);
	}

}
