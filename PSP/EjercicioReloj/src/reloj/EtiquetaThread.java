package reloj;

import java.awt.Color;

import javax.swing.JLabel;

public class EtiquetaThread implements Runnable {

	private JLabel etiqueta = new JLabel();
	
	
	int estado = 0;

	public EtiquetaThread(JLabel etiqueta) {
		this.etiqueta = etiqueta;
		
		Thread t = new Thread(this);
		t.setPriority(1);
		t.start();
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		try {
			while(estado == 0)
			{
				this.etiqueta.setForeground(new Color((int) (Math.random() * 0x1000000)));
				Thread.sleep(2000);
			}
			
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println("Final de hilo etiqueta" );

	}


}
