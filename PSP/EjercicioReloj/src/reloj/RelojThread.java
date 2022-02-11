package reloj;

import javax.swing.JLabel;

public class RelojThread extends Thread {

	private JLabel etiqueta = new JLabel();
	private int min = 0;
	private int seg = 0;

	private int estado = 0;

	public RelojThread(JLabel etiqueta) {
		this.etiqueta = etiqueta;
		this.setPriority(5);
	}

	@Override
	public void run() {
		while (estado == 0 || estado == 1) {

			if (estado == 0) {
				incrementar();
				mostrar();

			}

			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("Se ha terminado el reloj");

	}

	public void reiniciar() {
		seg = 0;
		min = 0;
	}

	public void setEstado(int nuevoEstado) {
		estado = nuevoEstado;
	}
	
	public int getEstado()
	{
		return estado;
	}

	public void mostrar() {
		String segStr = Integer.toString(seg);
		String minStr = Integer.toString(min);
		if (seg < 10)
			segStr = "0" + segStr;
		if (min < 10)
			minStr = "0" + minStr;

		this.etiqueta.setText(minStr + ":" + segStr);
	}

	public void incrementar() {
		seg++;
		if (seg == 60) {
			min++;
			seg = 0;
		}
		if (min == 60)
			min = 0;
	}

}
