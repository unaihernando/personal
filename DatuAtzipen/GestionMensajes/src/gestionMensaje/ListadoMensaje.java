package gestionMensaje;


import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;


public class ListadoMensaje extends JFrame {


	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTable table;

	/**
	 * Launch the application.
	 */


	/**
	 * Create the frame.
	 */
	public ListadoMensaje(ArrayList<Mensaje> mensajes) {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 707, 261);
		contentPane = new JPanel();
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		table = new JTable();
		table.setEnabled(false);
		
		
		DateFormat formatoFecha = new SimpleDateFormat("yyyy-MM-dd");
		DateFormat formatoHora = new SimpleDateFormat("hh:mm:ss");
		
		String[] columnas = new String[] {
				"De", "Para", "Fecha", "Hora", "Asunto", "Contenido"};
		Object[][] modelo = new Object[mensajes.size()][6];
		int cont = 0;
		for(Mensaje men: mensajes)
		{
			modelo[cont][0] = men.getDe();
			modelo[cont][1] = men.getPara();
			modelo[cont][2] = formatoFecha.format(men.getFecha());
			modelo[cont][3] = formatoHora.format(men.getFecha());
			modelo[cont][4] = men.getAsunto();
			modelo[cont][5] = men.getContenido();
			cont++;
		}
		
		
		table.setModel(new DefaultTableModel(modelo,columnas));
			
		
		table.setBounds(47, 45, 340, 165);
		JScrollPane scrollPane = new JScrollPane(table);
		    scrollPane.setBounds(24, 37, 647, 73);
		    getContentPane().add(scrollPane);
	}
}

