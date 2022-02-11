import java.util.ArrayList;

public class Bolsa {
	
	private ArrayList<Producto> listaProductos = new ArrayList<Producto> ();
	
	public synchronized void addProducto(Producto p)
	{
		while(estaLlena())
		{
			try {
				wait();
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		
		System.out.println("Añado: "+p.getNombre());
		listaProductos.add(p);
		
		notify();
	}
	
	public synchronized ArrayList<Producto> getListaProductos()
	{
		
		while(!estaLlena())
		{
			try {
				wait();
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("La lista esta llena");
		for(int i = 0;i<listaProductos.size();i++)
		{
			System.out.println(listaProductos.get(i).getNombre());
		}
		
		listaProductos.clear();
		notify();
		return listaProductos;
		
	}
	
	public int getSize()
	{
		return listaProductos.size();
	}
	
	public boolean estaLlena()
	{
		return (listaProductos.size() == 5);
	}

}
