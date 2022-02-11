import java.util.Random;

import javax.swing.JLabel;
import javax.swing.JProgressBar;

public class HiloCaballo extends Thread{
	
	private JProgressBar jp;
	private JLabel ganador;
	boolean seguir = true;
	
	
	public HiloCaballo(JProgressBar jp, String nombre, JLabel ganador)
	{
		this.jp = jp;
		this.setName(nombre);
		this.ganador= ganador;
	
	}
	
	public void run()
	{
		int i = 0;
		while(seguir)
		{
			try {
				Thread.sleep(200);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
			if(i < jp.getMaximum())
			{
				Random rd = new Random();
				i = i + rd.nextInt(3);
				jp.setValue(i);
			}
			else
			{
				seguir = false;
				ganador.setText("Ganador: "+ this.getName());
			}
		}
	}
	public void terminar()
	{
		seguir = false;
	}

}
