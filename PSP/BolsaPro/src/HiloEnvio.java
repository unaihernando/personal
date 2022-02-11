import java.util.Random;

public class HiloEnvio extends Thread {
	Bolsa bolsa;

	public HiloEnvio(Bolsa bolsa)
	{
		this.bolsa = bolsa;
	}
	
	public void run()
	{
		while(true)
		{
			
			
			bolsa.getListaProductos();
		}
	}
}
