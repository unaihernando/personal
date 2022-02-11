import java.util.Random;

public class HiloRellena extends Thread {
	
	Bolsa bolsa;
	String letras = "abcdefghijklmnopqrstuvwxz";
	
	public HiloRellena(Bolsa bolsa)
	{
		this.bolsa = bolsa;
	}
	
	public void run()
	{
		while(true)
		{
			Producto p = new Producto();
			Random rd = new Random();
			p.setNombre("Producto "+letras.charAt(rd.nextInt(21)));
			
			bolsa.addProducto(p);
		}
	}

}
