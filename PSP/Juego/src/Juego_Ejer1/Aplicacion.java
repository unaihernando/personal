package Juego_Ejer1;

public class Aplicacion {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Juego juego1= new Juego(5);
		Juego juego2 = new Juego(5);
		
		juego1.MuestraVidasRestantes();
		juego2.MuestraVidasRestantes();
		juego1.QuitaVida();
		
		juego1.MuestraVidasRestantes();
		
		juego1.ReiniciaPartida();
		juego1.MuestraVidasRestantes();
		
		juego1.ActualizaRecord();
		juego2.ActualizaRecord();
	}

}
