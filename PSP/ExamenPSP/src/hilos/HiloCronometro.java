package hilos;

import javax.swing.JLabel;

public class HiloCronometro implements Runnable {
	JLabel crono;
	JLabel mensaje;
	int estado = 0;
	int hora = 1;
	int minutos = 30;
	int segundos = 0;
	
	public HiloCronometro(JLabel crono, JLabel mensaje)
	{
		this.crono = crono;
		this.mensaje = mensaje;
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		this.mensaje.setText("El hilo <<reloj>> ha comenzado");
		
		while(estado == 0 || estado == 1)
		{
			if(estado == 0)
			{
				decrementar();
				mostrar();
			}
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		this.mensaje.setText("El hilo <<reloj>> ha terminado");
		hora = 1;
		minutos = 30;
		segundos = 0;
	}

	private void mostrar() {
		// TODO Auto-generated method stub
		String min = String.valueOf(minutos);
		if(minutos < 10)
			min = "0"+minutos;
		String segun = String.valueOf(segundos);
		
		if(segundos < 10)
			segun = "0"+segundos;
		crono.setText(hora+":"+min+":"+segun);
	}

	private void decrementar() {
		// TODO Auto-generated method stub
		
		if(hora == 0 && minutos == 0 && segundos == 0)
			estado = 2;
		
		segundos = segundos- 1;
		
		
		
		if(segundos < 0)
		{
			segundos = 59;
			minutos = minutos- 1;
		}
		if(minutos < 0)
		{
			minutos = 59;
			hora = hora-1 ;
		}
		
		
	}
	
	public void setEstado(int es)
	{
		this.estado = es;
		
	}
	public int getEstado() {
		return this.estado;
	}

}
