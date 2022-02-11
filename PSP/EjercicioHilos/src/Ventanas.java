


import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;


import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.SwingConstants;

public class Ventanas extends JFrame implements ActionListener{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JButton btn_P1m;
	private JButton btn_P1Mas;
	private JButton btn_P1fin;
	private JButton btn_P2m;
	private JButton btn_P2Mas;
	private JButton btn_P2fin;
	private JButton btn_P3m;
	private JButton btn_P3Mas;
	private JButton btn_P3fina;
	private JButton btn_final;
	private JLabel lbl_h1;
	private JLabel lbl_p1;
	private JLabel lbl_h2;
	private JLabel lbl_p2;
	private JLabel lbl_h3;
	private JLabel lbl_p3;
	
	HiloPrioridad h1;
	HiloPrioridad h2;
	HiloPrioridad h3;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Ventanas frame = new Ventanas();
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
	public Ventanas() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 493, 467);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		btn_P1m = new JButton("--");
		btn_P1m.addActionListener(this);
		btn_P1m.setBounds(28, 30, 89, 23);
		contentPane.add(btn_P1m);
		
		btn_P1fin = new JButton("Fin hilo 1");
		btn_P1fin.addActionListener(this);
		btn_P1fin.setBounds(185, 30, 89, 23);
		contentPane.add(btn_P1fin);
		
		btn_P1Mas = new JButton("++");
		btn_P1Mas.addActionListener(this);
		btn_P1Mas.setBounds(328, 30, 89, 23);
		contentPane.add(btn_P1Mas);
		
		btn_P2m = new JButton("--");
		btn_P2m.addActionListener(this);
		btn_P2m.setBounds(28, 75, 89, 23);
		contentPane.add(btn_P2m);
		
		btn_P2fin = new JButton("Fin hilo 2");
		btn_P2fin.addActionListener(this);
		btn_P2fin.setBounds(185, 75, 89, 23);
		contentPane.add(btn_P2fin);
		
		btn_P2Mas = new JButton("++");
		btn_P2Mas.addActionListener(this);
		btn_P2Mas.setBounds(328, 75, 89, 23);
		contentPane.add(btn_P2Mas);
		
		btn_P3m = new JButton("--");
		btn_P3m.addActionListener(this);
		btn_P3m.setBounds(28, 120, 89, 23);
		contentPane.add(btn_P3m);
		
		btn_P3fina = new JButton("Fin hilo 3");
		btn_P3fina.addActionListener(this);
		btn_P3fina.setBounds(185, 120, 89, 23);
		contentPane.add(btn_P3fina);
		
		btn_P3Mas = new JButton("++");
		btn_P3Mas.addActionListener(this);
		btn_P3Mas.setBounds(328, 120, 89, 23);
		contentPane.add(btn_P3Mas);
		
		btn_final = new JButton("Finalizar todos");
		btn_final.addActionListener(this);
		btn_final.setBounds(165, 182, 137, 36);
		contentPane.add(btn_final);
		
		lbl_h1 = new JLabel("Hilo 1: 0");
		lbl_h1.setHorizontalAlignment(SwingConstants.CENTER);
	
		lbl_h1.setBounds(28, 235, 165, 36);
		contentPane.add(lbl_h1);
		
		lbl_h2 = new JLabel("Hilo 2: 0");
		lbl_h2.setHorizontalAlignment(SwingConstants.CENTER);
	
		lbl_h2.setBounds(28, 285, 165, 36);
		contentPane.add(lbl_h2);
		
		lbl_h3 = new JLabel("Hilo 3: 0");
	
		lbl_h3.setHorizontalAlignment(SwingConstants.CENTER);
		lbl_h3.setBounds(28, 335, 165, 36);
		contentPane.add(lbl_h3);
		
		lbl_p1 = new JLabel("Pri: 5");
		lbl_p1.setHorizontalAlignment(SwingConstants.CENTER);
	
		lbl_p1.setBounds(286, 235, 137, 36);
		contentPane.add(lbl_p1);
		
		lbl_p2 = new JLabel("Pri: 5");
		lbl_p2.setHorizontalAlignment(SwingConstants.CENTER);
		
		lbl_p2.setBounds(286, 285, 137, 36);
		contentPane.add(lbl_p2);
		
		lbl_p3 = new JLabel("Pri: 5");
	
		lbl_p3.setHorizontalAlignment(SwingConstants.CENTER);
		lbl_p3.setBounds(286, 335, 137, 36);
		contentPane.add(lbl_p3);
		
		
		h1 = new HiloPrioridad(lbl_h1,lbl_p1,"Hilo1");
		h2 = new HiloPrioridad(lbl_h2,lbl_p2,"Hilo2");
		h3 = new HiloPrioridad(lbl_h3,lbl_p3,"Hilo3");
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		if(e.getSource().equals(btn_P1fin)) {
	
			h1.terminar();
			
			
		}
		if(e.getSource().equals(btn_P2fin)) {
			
			h2.terminar();
			
		}
		if(e.getSource().equals(btn_P3fina)) {
			
			h3.terminar();
			
		}
		if(e.getSource().equals(btn_final)) {
		
			h1.terminar();
			h2.terminar();
			h3.terminar();
			
		}
		if(e.getSource().equals(btn_P1m)) {
			h1.decrecentar();
		}
		if(e.getSource().equals(btn_P2m)) {
			h2.decrecentar();
		}
		if(e.getSource().equals(btn_P3m)) {
			h3.decrecentar();
		}
		if(e.getSource().equals(btn_P1Mas)) {
		h1.incrementar();
		}
		if(e.getSource().equals(btn_P2Mas)) {
			h2.incrementar();
		}
		if(e.getSource().equals(btn_P3Mas)) {
			h3.incrementar();
		}
		
	}
}
