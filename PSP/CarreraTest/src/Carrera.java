import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import jdk.internal.misc.FileSystemOption;

import javax.swing.JProgressBar;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JLabel;
import java.awt.Color;

public class Carrera extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
 
	HiloCaballo h1; 
	HiloCaballo h2;
	HiloCaballo h3;
	HiloCaballo h4;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Carrera frame = new Carrera();
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
	public Carrera() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 343);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);

		JProgressBar progressBar = new JProgressBar();
		contentPane.add(progressBar, BorderLayout.CENTER);
		progressBar.setStringPainted(true);
		progressBar.setValue(60);

		JProgressBar progressBar_1 = new JProgressBar();
		progressBar_1.setForeground(Color.PINK);
		progressBar_1.setStringPainted(true);
		progressBar_1.setBounds(84, 42, 295, 39);
		contentPane.add(progressBar_1);

		JProgressBar progressBar_1_1 = new JProgressBar();
		progressBar_1_1.setStringPainted(true);
		progressBar_1_1.setBounds(84, 92, 295, 39);
		contentPane.add(progressBar_1_1);

		JProgressBar progressBar_1_1_1 = new JProgressBar();
		progressBar_1_1_1.setForeground(Color.MAGENTA);
		progressBar_1_1_1.setStringPainted(true);
		progressBar_1_1_1.setBounds(84, 142, 295, 39);
		contentPane.add(progressBar_1_1_1);

		JProgressBar progressBar_1_1_1_1 = new JProgressBar();
		progressBar_1_1_1_1.setForeground(Color.GREEN);
		progressBar_1_1_1_1.setStringPainted(true);
		progressBar_1_1_1_1.setBounds(84, 194, 295, 39);
		contentPane.add(progressBar_1_1_1_1);

		JLabel lblNewLabel = new JLabel("Caballo 1");
		lblNewLabel.setForeground(Color.PINK);
		lblNewLabel.setBounds(10, 46, 64, 28);
		contentPane.add(lblNewLabel);

		JLabel lblCaballo = new JLabel("Caballo 2");
		lblCaballo.setForeground(Color.BLUE);
		lblCaballo.setBounds(10, 96, 64, 28);
		contentPane.add(lblCaballo);

		JLabel lblNewLabel_1_1 = new JLabel("Caballo 3");
		lblNewLabel_1_1.setForeground(Color.MAGENTA);
		lblNewLabel_1_1.setBounds(10, 146, 64, 28);
		contentPane.add(lblNewLabel_1_1);

		JLabel lblNewLabel_1_2 = new JLabel("Caballo 4");
		lblNewLabel_1_2.setForeground(Color.GREEN);
		lblNewLabel_1_2.setBounds(10, 198, 64, 28);
		contentPane.add(lblNewLabel_1_2);
		
		JLabel lblNewLabel_1 = new JLabel("New label");
		lblNewLabel_1.setBounds(127, 11, 204, 14);
		contentPane.add(lblNewLabel_1);

		h1 = new HiloCaballo(progressBar_1,"Caballo 1",lblNewLabel_1);
		h2 = new HiloCaballo(progressBar_1_1,"Caballo 2",lblNewLabel_1);
		h3 = new HiloCaballo(progressBar_1_1_1,"Caballo 3",lblNewLabel_1);
		h4 = new HiloCaballo(progressBar_1_1_1_1,"Caballo 4",lblNewLabel_1);
		
		
		JButton btnNewButton = new JButton("Empieza la carrera");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			
				System.out.println(h1.getPriority());
				System.out.println(h2.getPriority());
				System.out.println(h3.getPriority());
				System.out.println(h4.getPriority());
				h1.start();
				h2.start();
				h3.start();
				h4.start();
				
				HiloDetector d1 = new HiloDetector(h1,h2,h3,h4);
				d1.start();


			}
		});
		
		

		btnNewButton.setBounds(127, 257, 190, 23);
		contentPane.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			
				Trampas tr = new Trampas(h1,h2,h3,h4);
				tr.setVisible(true);
			}
		});
		btnNewButton_1.setBounds(411, 281, 23, 23);
		contentPane.add(btnNewButton_1);
		
		
	}
}
