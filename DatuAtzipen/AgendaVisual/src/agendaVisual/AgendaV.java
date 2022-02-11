package agendaVisual;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.awt.event.ActionEvent;
import javax.swing.JTable;

public class AgendaV extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel panel;
	private JTextField textFieldNombre;
	private JTextField textFieldApellido;
	private JTextField textFieldDNI;
	private JTextField textFieldTel;
	private JTable table;
	private ArrayList<Contacto> contactos = new ArrayList<Contacto>();
	private JLabel lblErrorNombre;
	private JLabel lblErrorApellido;
	private JLabel lblErrorDNI;
	private JLabel lblErrorTel;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AgendaV frame = new AgendaV();
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
	public AgendaV() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	this.setSize(450,550);
		
		panel = new JPanel();
		panel.setLayout(null);
		getContentPane().add(panel);
		
		JLabel lblNombre = new JLabel("Nombre");
		lblNombre.setBounds(10, 10, 80, 25);
		panel.add(lblNombre);
		
		textFieldNombre = new JTextField();
		textFieldNombre.setBounds(100, 10, 160, 25);
		panel.add(textFieldNombre);
		textFieldNombre.setColumns(20);
		
		JLabel lblApellido = new JLabel("Apellido");
		lblApellido.setBounds(10, 40, 80, 25);
		panel.add(lblApellido);
		
		textFieldApellido = new JTextField();
		textFieldApellido.setBounds(100, 40, 160, 25);
		panel.add(textFieldApellido);
		textFieldApellido.setColumns(30);
		
		JLabel lblDNI = new JLabel("DNI");
		lblDNI.setBounds(10, 70, 80, 25);
		panel.add(lblDNI);
		
		textFieldDNI = new JTextField();
		textFieldDNI.setBounds(100, 70, 160, 25);
		panel.add(textFieldDNI);
		textFieldDNI.setColumns(10);
		
		JLabel lblTel = new JLabel("Telefono");
		lblTel.setBounds(10,100, 80, 25);
		panel.add(lblTel);
		
		textFieldTel = new JTextField();
		textFieldTel.setBounds(100, 100, 160, 25);
		panel.add(textFieldTel);
		textFieldTel.setColumns(9);
		
		JButton btnNewButton = new JButton("Añadir");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				anadir();
			}

			
		});
		btnNewButton.setBounds(175, 135, 85, 21);
		panel.add(btnNewButton);
	
		table = new JTable();
		panel.add(table);
		
		lblErrorNombre = new JLabel("Nombre incorrecto");
		lblErrorNombre.setBounds(270, 10, 133, 25);
		lblErrorNombre.setVisible(false);
		panel.add(lblErrorNombre);
		
		lblErrorApellido = new JLabel("Apellido incorrecto");
		lblErrorApellido.setBounds(270, 46, 164, 13);
		lblErrorApellido.setVisible(false);
		panel.add(lblErrorApellido);
		
		lblErrorDNI = new JLabel("DNI incorrecto");
		lblErrorDNI.setBounds(270, 76, 154, 13);
		lblErrorDNI.setVisible(false);
		panel.add(lblErrorDNI);
		
		lblErrorTel = new JLabel("Telefono incorrecto");
		lblErrorTel.setBounds(270, 106, 154, 13);
		lblErrorTel.setVisible(false);
		panel.add(lblErrorTel);
		
	}
	
	private void anadir() {
		// TODO Auto-generated method stub
		String nombre = textFieldNombre.getText();
		String apellido = textFieldApellido.getText();
		String DNI = textFieldDNI.getText();
		String tel = textFieldTel.getText();
		lblErrorNombre.setVisible(false);
		lblErrorApellido.setVisible(false);
		lblErrorDNI.setVisible(false);
		lblErrorTel.setVisible(false);
		boolean correcto = true;
		
		if(!Utilidades.validar("[a-z A-Z]{1,20}", nombre))
		{
			correcto = false;
			lblErrorNombre.setVisible(true);
		}
		if(!Utilidades.validar("[a-z A-Z]{1,30}", apellido))
		{
			correcto = false;
			lblErrorApellido.setVisible(true);
		}
		if(!Utilidades.validar("[0-9]{8}[a-zA-Z]", DNI))
		{
			correcto = false;
			lblErrorDNI.setVisible(true);
		}	
		if(!Utilidades.validar("[0-9]{9}", tel))
		{
			correcto = false;
			lblErrorTel.setVisible(true);
		}	
		
			
		if(correcto)
		{
			textFieldNombre.setText("");
			textFieldApellido.setText("");
			textFieldDNI.setText("");
			textFieldTel.setText("");
		
			
			Contacto contac = new Contacto(nombre,apellido,DNI,tel);
			contactos.add(contac);
			String data[][]= new String[contactos.size()][5];
			int indice= 0;
			
			for (Contacto contacto : contactos) {
				
				data[indice][0] =String.valueOf(indice+1);
				data[indice][1] = contacto.getNombre();
				data[indice][2] = contacto.getApellidos();
				data[indice][3] = contacto.getDNI();
				data[indice][4] = contacto.getTelefono();
				indice++;
			}
			
			panel.remove(table);
		    String column[]= {"","","","",""};  
			table = new JTable(data,column);
	
			table.setBounds(10, 180, 343, 258);
	
			panel.add(table);
			panel.updateUI();
		}
		
		
	}
}
