package gestionMensaje;



import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JTextArea;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.awt.event.ActionEvent;

public class NuevoMensaje extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField textFieldDia;
	private JTextField tf_De;
	private JTextField tf_Para;
	private JTextField tf_Asunto;

	/**
	 * Launch the application.
	 */


	/**
	 * Create the frame.
	 */
	public NuevoMensaje(ArrayList<Mensaje> mensajes) {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 461, 323);
		contentPane = new JPanel();
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		JLabel lblNewLabel = new JLabel("Fecha");
		lblNewLabel.setBounds(10, 20, 45, 13);
		contentPane.add(lblNewLabel);
		
		textFieldDia = new JTextField();
		textFieldDia.setBounds(61, 17, 36, 16);
		contentPane.add(textFieldDia);
		textFieldDia.setColumns(10);
		
		JLabel lblNewLabel_1 = new JLabel("Hora");
		lblNewLabel_1.setBounds(10, 52, 45, 13);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("De");
		lblNewLabel_2.setBounds(10, 131, 45, 13);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Para");
		lblNewLabel_3.setBounds(10, 154, 45, 13);
		contentPane.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Asunto");
		lblNewLabel_4.setBounds(10, 177, 45, 13);
		contentPane.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Contenido");
		lblNewLabel_5.setBounds(10, 211, 58, 13);
		contentPane.add(lblNewLabel_5);
		
		tf_De = new JTextField();
		tf_De.setBounds(81, 129, 155, 16);
		contentPane.add(tf_De);
		tf_De.setColumns(10);
		
		tf_Para = new JTextField();
		tf_Para.setBounds(81, 152, 155, 16);
		contentPane.add(tf_Para);
		tf_Para.setColumns(10);
		
		tf_Asunto = new JTextField();
		tf_Asunto.setBounds(81, 175, 155, 16);
		contentPane.add(tf_Asunto);
		tf_Asunto.setColumns(10);
		
		JTextArea ta_Contenido = new JTextArea();
		ta_Contenido.setBounds(78, 205, 182, 37);
		contentPane.add(ta_Contenido);
		
		JComboBox<String> cB_Mes = new JComboBox<String>();
		cB_Mes.setModel(new DefaultComboBoxModel<String>(new String[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}));
		cB_Mes.setBounds(115, 16, 100, 21);
		contentPane.add(cB_Mes);
		
		JComboBox<Integer> cB_anyo = new JComboBox<Integer>();
		cB_anyo.setModel(new DefaultComboBoxModel<Integer>(new Integer[] {19, 20, 21, 22, 23}));
		cB_anyo.setBounds(238, 16, 50, 21);
		contentPane.add(cB_anyo);
		
		JComboBox<Integer> cB_hora = new JComboBox<Integer>();
		cB_hora.setModel(new DefaultComboBoxModel<Integer>(new Integer[] {01, 02, 03, 04, 05, 06, 07, 8, 9, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 00}));
		cB_hora.setBounds(61, 48, 50, 21);
		contentPane.add(cB_hora);
		
		JComboBox<Integer> cB_minutos = new JComboBox<Integer>();
		cB_minutos.setModel(new DefaultComboBoxModel<Integer>(new Integer[] {00, 10, 20, 30, 40, 50}));
		cB_minutos.setBounds(115, 48, 50, 21);
		contentPane.add(cB_minutos);
		
		JButton btnNewButton = new JButton("OK");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Calendar myCal = Calendar.getInstance();
				myCal.set(Calendar.YEAR, (int) cB_anyo.getSelectedItem() + 2000);
				myCal.set(Calendar.MONTH, cB_Mes.getSelectedIndex()+1);
				myCal.set(Calendar.DAY_OF_MONTH,Integer.valueOf(textFieldDia.getText()));
				myCal.set(Calendar.HOUR_OF_DAY,(int) cB_hora.getSelectedItem());
				myCal.set(Calendar.MINUTE,(int) cB_minutos.getSelectedItem());
				
				Date fecha = myCal.getTime();
				Mensaje men = new Mensaje(tf_De.getText(),tf_Para.getText(),tf_Asunto.getText(),ta_Contenido.getText(),fecha);
				mensajes.add(men);
				
				contentPane.getParent().getParent().getParent().setVisible(false);
			}
		});
		btnNewButton.setBounds(283, 255, 58, 21);
		contentPane.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("Cancel");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				contentPane.getParent().getParent().getParent().setVisible(false);
			}
		});
		btnNewButton_1.setBounds(351, 255, 85, 21);
		contentPane.add(btnNewButton_1);
		
	
	}
}
