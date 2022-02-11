
public class HiloDetector extends Thread {
	
	HiloCaballo h1;
	HiloCaballo h2;
	HiloCaballo h3;
	HiloCaballo h4;
	
	public HiloDetector(HiloCaballo h1,HiloCaballo h2,HiloCaballo h3,HiloCaballo h4)
	{
		this.h1 = h1;
		this.h2 = h2;
		this.h3 = h3;
		this.h4 = h4;
	}
	public void run()
	{
		while(h1.isAlive() && h2.isAlive() && h3.isAlive() && h4.isAlive())
		{
			
		}
		h1.terminar();
		h2.terminar();
		h3.terminar();
		h4.terminar();
	}

}
