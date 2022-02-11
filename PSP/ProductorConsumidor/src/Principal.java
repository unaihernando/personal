
public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Buffer bf = new Buffer();
		HiloConsumidor consu = new HiloConsumidor(bf);
		HiloProductor produ = new HiloProductor(bf);
		produ.start();
		consu.start();
	}

}
