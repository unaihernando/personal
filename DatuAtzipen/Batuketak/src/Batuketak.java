import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

public class Batuketak extends JFrame {

	private JPanel contentPane;
	private JTextField zenbaki1;
	private JTextField zenbaki2;
	private JTextField emaitza;
	private JScrollPane scrollPane;
	private JTable taula;
	private int id= 1;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Batuketak frame = new Batuketak();
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
	public Batuketak() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		JLabel lblNewLabel = new JLabel("1. Zenbakia");
		lblNewLabel.setBounds(31, 21, 69, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("2. Zenbakia");
		lblNewLabel_1.setBounds(31, 46, 69, 14);
		contentPane.add(lblNewLabel_1);
		
		zenbaki1 = new JTextField();
		zenbaki1.setBounds(110, 18, 86, 20);
		contentPane.add(zenbaki1);
		zenbaki1.setColumns(10);
		
		zenbaki2 = new JTextField();
		zenbaki2.setBounds(110, 43, 86, 20);
		contentPane.add(zenbaki2);
		zenbaki2.setColumns(10);
		
		JButton btnBatuketa = new JButton("Batuketa");
		btnBatuketa.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int zen1 = Integer.parseInt(zenbaki1.getText());
				int zen2 = Integer.parseInt(zenbaki2.getText());
				emaitza.setText((zen1 + zen2) + "");
				DefaultTableModel oModeloa = (DefaultTableModel) taula.getModel();
				oModeloa.addRow(new Object[] {id++, zen1, zen2, emaitza.getText()});
			}
		});
		btnBatuketa.setBounds(314, 17, 89, 23);
		contentPane.add(btnBatuketa);
		
		emaitza = new JTextField();
		emaitza.setBounds(314, 43, 86, 20);
		contentPane.add(emaitza);
		emaitza.setColumns(10);
		
		scrollPane = new JScrollPane();
		scrollPane.setBounds(0, 0, 2, 2);
		contentPane.add(scrollPane);
		
		taula = new JTable();
		taula.setModel(new DefaultTableModel(
			new Object[][] {
				{"zkia", "Zenbaki 1", "Zenbaki 2", "Emaitza"},
			},
			new String[] {
				"zkia", "Zenbaki 1", "Zenbaki 2", "Emaitza"
			}
		));
		taula.setBounds(31, 97, 370, 126);
		contentPane.add(taula);
	}
}
