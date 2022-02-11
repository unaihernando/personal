
public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Bolsa bolsa = new Bolsa();
		HiloEnvio hiloE = new HiloEnvio(bolsa);
		HiloRellena hiloR = new HiloRellena(bolsa);
		hiloR.start();
		hiloE.start();
		
	}

}
