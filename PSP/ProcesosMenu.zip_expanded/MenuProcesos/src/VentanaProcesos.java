import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.io.BufferedReader;
import java.io.File;
import java.io.OutputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.awt.event.ActionEvent;
import javax.swing.JTextPane;

public class VentanaProcesos extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JPanel contentPane;
	private JTextField textFieldPrograma;
	private JTextField textFieldComando;
	private JTextField textFieldTexto;
	

	
	

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaProcesos frame = new VentanaProcesos();
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
	public VentanaProcesos() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 603, 695);
		contentPane = new JPanel();
		contentPane.setLayout(null);
		setContentPane(contentPane);
		
		JLabel lblPID = new JLabel("PID");
		lblPID.setBounds(10, 189, 45, 13);
		contentPane.add(lblPID);
		
		JLabel lblPadrePID = new JLabel("PID Padre");
		lblPadrePID.setBounds(10, 230, 77, 13);
		contentPane.add(lblPadrePID);
		
		JLabel lblP2Pid = new JLabel("");
		lblP2Pid.setBounds(229, 189,77, 13);
		contentPane.add(lblP2Pid);
		
		JLabel lblP2PidPadre = new JLabel("");
		lblP2PidPadre.setBounds(229, 230, 77, 13);
		contentPane.add(lblP2PidPadre);
		
		JLabel lblP3PID = new JLabel("");
		lblP3PID.setBounds(354, 189, 225, 13);
		contentPane.add(lblP3PID);
		
		JLabel lblP3PidPadre = new JLabel("");
		lblP3PidPadre.setBounds(354, 230, 77, 13);
		contentPane.add(lblP3PidPadre);
		

		
		JLabel lblP1Pid = new JLabel("");
		lblP1Pid.setBounds(84, 189, 84, 13);
		contentPane.add(lblP1Pid);
		
		JLabel lblP1PidP = new JLabel("");
		lblP1PidP.setBounds(84, 230, 121, 13);
		contentPane.add(lblP1PidP);
		
		
		JTextPane textPane = new JTextPane();
		textPane.setBounds(163, 258, 202, 363);
		contentPane.add(textPane);
		
		JTextPane textPane_1 = new JTextPane();
		textPane_1.setBounds(375, 259, 204, 362);
		contentPane.add(textPane_1);
		

		JButton btnP1Start = new JButton("Start");
		btnP1Start.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
				ProcessBuilder bd = new ProcessBuilder(textFieldPrograma.getText());
				
					Process p = bd.start();
					lblP1Pid.setText(String.valueOf(p.pid()));
					lblP1PidP.setText(String.valueOf(p.toHandle().parent().get().pid()));
					
					
				} catch (IOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
			}
		});
		btnP1Start.setBounds(72, 140, 85, 21);
		contentPane.add(btnP1Start);
		
		JButton btnP2Start = new JButton("Start");
		btnP2Start.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					ProcessBuilder bd = new ProcessBuilder("cmd","/c",textFieldComando.getText());
					
						Process p = bd.start();
						lblP2Pid.setText(String.valueOf(p.pid()));
						lblP2PidPadre.setText(String.valueOf(p.toHandle().parent().get().pid()));
						
						InputStream er = p.getInputStream();
						BufferedReader brer = new BufferedReader(new
						InputStreamReader(er));
						String line =null;
						while ((line = brer.readLine()) != null)
							textPane.setText(textPane.getText()+ line+"\n");
						
						
						
						
					} catch (IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
			}
		});
		btnP2Start.setBounds(212, 140, 85, 21);
		contentPane.add(btnP2Start);
		
		JButton btnP3Start = new JButton("Start");
		btnP3Start.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					
					for(int i =0;i<5;i++)
					{
					ProcessBuilder bd = new ProcessBuilder("java","EjemploLectura");
					bd.directory(new File("bin"));
						Process p = bd.start();
						lblP3PID.setText(lblP3PID.getText() + " "+String.valueOf(p.pid()));
						lblP3PidPadre.setText(String.valueOf(p.toHandle().parent().get().pid()));
						
						OutputStream os = p.getOutputStream();
						os.write((textFieldTexto.getText()+"\n").getBytes());
						os.flush();

						
						
						
						InputStream er = p.getInputStream();
						BufferedReader brer = new BufferedReader(new
						InputStreamReader(er));
						String line =null;
						while ((line = brer.readLine()) != null)
							textPane_1.setText(textPane_1.getText()+ line+"\n");
						
						
						
					}
					} catch (IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				
					
			}
		});
		btnP3Start.setBounds(342, 140, 85, 21);
		contentPane.add(btnP3Start);
		
		textFieldPrograma = new JTextField();
		textFieldPrograma.setBounds(72, 100, 96, 19);
		contentPane.add(textFieldPrograma);
		textFieldPrograma.setColumns(10);
		
		textFieldComando = new JTextField();
		textFieldComando.setBounds(213, 100, 96, 19);
		contentPane.add(textFieldComando);
		textFieldComando.setColumns(10);
		
		textFieldTexto = new JTextField();
		textFieldTexto.setBounds(342, 100, 96, 19);
		contentPane.add(textFieldTexto);
		textFieldTexto.setColumns(10);
		
		JLabel lblResultado = new JLabel("Resultado");
		lblResultado.setBounds(10, 298, 64, 13);
		contentPane.add(lblResultado);
	
	
		
		
		
	}
}
