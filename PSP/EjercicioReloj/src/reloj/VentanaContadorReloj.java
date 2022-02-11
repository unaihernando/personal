package reloj;


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class VentanaContadorReloj extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	
	RelojThread reloj = null;
	EtiquetaThread t1 = null;
	EtiquetaThread t2 = null;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaContadorReloj frame = new VentanaContadorReloj();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
	private void Salir() {
		
		if(reloj != null)
			reloj.setEstado(2);
		
		if(t1 != null)
			t1.estado = 2;
		
		if(t2 != null)
			t2.estado = 2;
		
		
		try {
			Thread.sleep(5000);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		System.exit(0);
		
	}
	/**
	 * Create the frame.
	 */
	public VentanaContadorReloj() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 585, 342);
		contentPane = new JPanel();
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		JLabel labelReloj = new JLabel("00:00");
		labelReloj.setFont(new Font("Tahoma", Font.PLAIN, 51));
		labelReloj.setBounds(194, 77, 151, 80);
		contentPane.add(labelReloj);
		
		JLabel label1 = new JLabel("<<");
		label1.setFont(new Font("Tahoma", Font.PLAIN, 50));
		label1.setBounds(76, 77, 75, 80);
		contentPane.add(label1);
		
		JLabel label2 = new JLabel(">>");
		label2.setFont(new Font("Tahoma", Font.PLAIN, 50));
		label2.setBounds(370, 74, 85, 80);
		contentPane.add(label2);
		
		JButton btnParar = new JButton("Parar");
		JButton btnReiniciar = new JButton("Reiniciar");
		JButton btnNewButton = new JButton("Pausar");
		
		JButton btnIniciar = new JButton("Iniciar");
		btnIniciar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
		
				if (reloj == null || reloj.getEstado() == 2)
					reloj = new RelojThread(labelReloj);
				else
					reloj.setEstado(0);
				
				if(!reloj.isAlive())
					reloj.start();
				
				btnIniciar.setEnabled(false);
				btnParar.setEnabled(true);
				btnReiniciar.setEnabled(true);
				btnNewButton.setEnabled(true);
			}
		});
		btnIniciar.setBounds(36, 210, 85, 21);
		contentPane.add(btnIniciar);
		
		
		btnParar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				reloj.setEstado(2);
				btnParar.setEnabled(false);
				btnReiniciar.setEnabled(false);
				btnNewButton.setEnabled(false);
				btnIniciar.setEnabled(true);
				
			}
		});
		btnParar.setBounds(223, 210, 85, 21);
		btnParar.setEnabled(false);
		contentPane.add(btnParar);
		

		btnReiniciar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				reloj.reiniciar();
			}
		});
		btnReiniciar.setBounds(326, 210, 85, 21);
		btnReiniciar.setEnabled(false);
		contentPane.add(btnReiniciar);
		
		JButton btnSalir = new JButton("Salir");
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Salir();
			}
		});
		btnSalir.setBounds(421, 210, 85, 21);
		contentPane.add(btnSalir);
		
		
		
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				reloj.setEstado(1);
				btnParar.setEnabled(false);
				btnReiniciar.setEnabled(false);
				btnNewButton.setEnabled(false);
				btnIniciar.setEnabled(true);
			}
		});
		btnNewButton.setBounds(128, 210, 85, 21);
		btnNewButton.setEnabled(false);
		contentPane.add(btnNewButton);

		t1 = new EtiquetaThread(label1);
		t2 = new EtiquetaThread(label2);
		
		
	}
}
