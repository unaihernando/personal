import javax.swing.JLabel;

public class HiloPrioridad implements Runnable{
	
	private JLabel labelC ;
	private JLabel prioridad ;
	private int seguir=0;
	private int cont = 0;
	Thread t1 = null;
	
	public HiloPrioridad(JLabel labelC, JLabel prioridad,String nombre)
	{
		this.labelC = labelC;
		this.prioridad = prioridad;
		t1 = new Thread(this);
		t1.setPriority(5);
		t1.setName(nombre);
		t1.start();
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		while(seguir== 0)
		{
			incremetar();
			mostrar();
		}
		System.out.println("El "+t1.getName()+ " ha terminado");
	}

	private void mostrar() {
		// TODO Auto-generated method stub
		this.labelC.setText(t1.getName() +": "+String.valueOf(cont));
		this.prioridad.setText("Pri: "+t1.getPriority());;
	}

	private void incremetar() {
		cont++;
	}
	
	public void terminar()
	{
		seguir = 1;
	}
	
	public void incrementar()
	{
		if(t1.getPriority() < 10)
			t1.setPriority(t1.getPriority()+1);
	}
	
	public void decrecentar()
	{
		if(t1.getPriority() > 0)
			t1.setPriority(t1.getPriority()-1);
	}


}
