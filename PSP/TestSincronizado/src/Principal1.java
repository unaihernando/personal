
public class Principal1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Cuenta c = new Cuenta(40);
		Persona h1 = new Persona(c, "Mikel");
		Persona h2 = new Persona(c, "Ana");
	
		h1.start();
	
	}

}
