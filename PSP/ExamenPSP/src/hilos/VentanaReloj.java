package hilos;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JLabel;

public class VentanaReloj extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	Thread t = null;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaReloj frame = new VentanaReloj();
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
	public VentanaReloj() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		
		JLabel lblCrono = new JLabel("New label");
		lblCrono.setBounds(117, 60, 190, 34);
		contentPane.add(lblCrono);
		
		JLabel lblHora = new JLabel("New label");
		lblHora.setBounds(270, 108, 100, 14);
		contentPane.add(lblHora);
		
		JLabel lblMensajes = new JLabel("New label");
		lblMensajes.setBounds(35, 180, 225, 14);
		contentPane.add(lblMensajes);
		
		HiloCronometro cr = new HiloCronometro(lblCrono,lblMensajes);
		
		
		JButton btnNewButton = new JButton("Iniciar");
		JButton btnNewButton_1 = new JButton("Pausar");
		JButton btnNewButton_2 = new JButton("Parar");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if(cr.getEstado() == 2)
					cr.setEstado(0);
					
					t = new Thread(cr);
					t.setPriority(5);
					t.start();
				
				btnNewButton.setEnabled(false);
				btnNewButton_1.setEnabled(true);
				btnNewButton_2.setEnabled(true);
			}
		});
		btnNewButton.setBounds(74, 133, 89, 23);
		contentPane.add(btnNewButton);
		
		
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(cr.getEstado() == 0)
				{
					cr.setEstado(1);
					btnNewButton_1.setText("Reanudar");
					btnNewButton_2.setEnabled(false);
					
				}
				else
				{
					cr.setEstado(0);
					btnNewButton_1.setText("Pausar");
					btnNewButton_2.setEnabled(true);
				}
			}
		});
		btnNewButton_1.setBounds(171, 133, 89, 23);
		contentPane.add(btnNewButton_1);
		
		
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				cr.setEstado(2);
				btnNewButton.setEnabled(true);
				btnNewButton_1.setEnabled(false);
				btnNewButton_2.setEnabled(false);
			}
		});
		btnNewButton_2.setBounds(270, 133, 89, 23);
		contentPane.add(btnNewButton_2);
		
		btnNewButton_1.setEnabled(false);
		 btnNewButton_2.setEnabled(false);
		
		HiloHora hh = new HiloHora(lblHora,lblMensajes);
		
		JButton btnNewButton_3 = new JButton("Salir");
		btnNewButton_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				cr.setEstado(2);
		        hh.terminar();
		        
		        while(hh.isAlive())
		        {
		        	System.out.println("Terminando..");
		        }
		        if(t!= null)
		        {
		        	  while(t.isAlive())
				        {
				        	System.out.println("Terminando..");
				        }
		        }
		        System.exit(0);
			}
		});
		btnNewButton_3.setBounds(270, 176, 89, 23);
		contentPane.add(btnNewButton_3);
		
	this.addWindowListener(new java.awt.event.WindowAdapter() {
		    @Override
		    public void windowClosing(java.awt.event.WindowEvent windowEvent) {
		        cr.setEstado(2);
		        hh.terminar();
		        while(hh.isAlive() || t.isAlive())
		        {
		        	System.out.println("Terminando..");
		        }
		        System.exit(0);
		    }
		});
	}
}
