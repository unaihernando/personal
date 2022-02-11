import java.util.Random;

public class HiloConsumidor extends Thread{
	
	Buffer f ;
	
	
	public HiloConsumidor(Buffer f)
	{
		this.f = f;
	}
	
	public void run()
	{
		for(int i =0;i<10;i++)
		{
			try {
				Thread.sleep(200);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			char l = f.recoger();
			System.out.println("Consumidor: "+l);
			
			
		}
	}

}
