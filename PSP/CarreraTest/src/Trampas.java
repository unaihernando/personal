

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Trampas extends JFrame  implements ActionListener {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	

	private JButton btnNewButton;
 HiloCaballo h1;
 HiloCaballo h2;
 HiloCaballo h3;
 HiloCaballo h4;
	public Trampas( HiloCaballo h1,HiloCaballo h2,HiloCaballo h3,HiloCaballo h4 ) {
		
	this.h1 = h1;
	this.h2 = h2;
	this.h3 = h3;
	this.h4 = h4;
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		JLabel lblNewLabel = new JLabel("Caballo 1");
		lblNewLabel.setBounds(28, 22, 75, 14);
		JLabel lblNewLabel2 = new JLabel("Caballo 2");
		lblNewLabel2.setBounds(28, 47, 75, 14);
		JLabel lblNewLabel3 = new JLabel("Caballo 3");
		lblNewLabel3.setBounds(28, 72, 75, 14);
		JLabel lblNewLabel4 = new JLabel("Caballo 4");
		lblNewLabel4.setBounds(28, 95, 75, 14);
		contentPane.add(lblNewLabel);
		contentPane.add(lblNewLabel2);
		contentPane.add(lblNewLabel3);
		contentPane.add(lblNewLabel4);
		
		textField = new JTextField();
		textField.setBounds(113, 19, 86, 20);
		contentPane.add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setBounds(113, 44, 86, 20);
		contentPane.add(textField_1);
		textField_1.setColumns(10);
		
		textField_2 = new JTextField();
		textField_2.setBounds(113, 69, 86, 20);
		contentPane.add(textField_2);
		textField_2.setColumns(10);
		
		textField_3 = new JTextField();
		textField_3.setBounds(113, 92, 86, 20);
		contentPane.add(textField_3);
		textField_3.setColumns(10);
		
	
		btnNewButton = new JButton("Guardar");
		btnNewButton.addActionListener(this);
		
		btnNewButton.setBounds(110, 137, 89, 23);
		contentPane.add(btnNewButton);
	
	}
	
	public void actionPerformed(ActionEvent e) {
		if(e.getSource().equals(btnNewButton)) {
			this.h1.setPriority(Integer.parseInt(textField.getText()));
			this.h2.setPriority(Integer.parseInt(textField_1.getText()));
			this.h3.setPriority(Integer.parseInt(textField_2.getText()));
			this.h4.setPriority(Integer.parseInt(textField_3.getText()));
			
			dispose();
		}
		}

}
