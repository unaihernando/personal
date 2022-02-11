package hilos;


import java.text.SimpleDateFormat;
import java.util.Date;

import javax.swing.JLabel;

public class HiloHora extends Thread {
	
	JLabel label;
	JLabel mensaje;
	boolean sigo = true;
	
	public HiloHora(JLabel label, JLabel mensaje)
	{
		this.label = label;
		this.mensaje = mensaje;
		this.setName("reloj");
		this.setPriority(NORM_PRIORITY);
		this.start();
		mensaje.setText("El hilo <<hora>> ha empezado");
	}
	
	public void run()
	{
		while(sigo)
		{
			Date date = (Date) new java.util.Date(); //Paquete java.util
			SimpleDateFormat sdf = new SimpleDateFormat("HH:mm:ss"); //Paquete java.text
			String horaActual = sdf.format(date);
			label.setText(horaActual);

		}
		mensaje.setText("El hilo <<hora>> ha terminado");
	}
	
	public void terminar()
	{
		sigo = false;
	}

}
