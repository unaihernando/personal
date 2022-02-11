import java.util.Random;

public class HiloProductor extends Thread{
	
	Buffer f ;
	String abc = "abcdefghijklmnopqrstuvwxyz";
	
	public HiloProductor(Buffer f)
	{
		this.f = f;
	}
	
	public void run()
	{
		for(int i =0;i<10;i++)
		{
			Random r = new Random();
			char l = abc.charAt(r.nextInt(23));
			f.poner(l);
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			System.out.println("Productor: "+l);
		}
	}

}
