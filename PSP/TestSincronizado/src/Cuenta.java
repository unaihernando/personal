
public class Cuenta {
	private int saldo;
	
	
	public Cuenta(int saldo)
	{
		this.saldo = saldo;
	}

	public void Restar(int cantidad)
	{
		saldo-=cantidad;
	}
	
	public void retirarDinero(int cantidad, String nombre)
	{
		if(saldo>= cantidad) {
			System.out.println("Se va a retirar dinero. Actual: "+saldo);
		
			try {
				Thread.sleep(5000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			Restar(cantidad);
			System.out.println(nombre + " retira " + cantidad + " Actual: "+saldo);
			
		}
		else
			System.out.println(nombre + " retira no puede retirar dinero Actual: "+saldo);	
	}
	
	
}
