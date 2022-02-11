package Juego_Ejer3;

public abstract class Juego {

	private int numVidas;
	private int vidasIn;
	public int record = 0;

	public Juego(int numVidas) {
		
		this.numVidas = numVidas;
		this.vidasIn = numVidas;
	}
	
	
	public void  MuestraVidasRestantes() {
		System.out.println("Numero vidas restantes: "+numVidas);
	}
	
	
	public boolean QuitaVida() {
		boolean vidasRestantes = false;
		numVidas = numVidas-1;
		if(numVidas > 0)
			vidasRestantes = true;	
		return vidasRestantes;
		
	}
	
	
	public void ReiniciaPartida() {
		
		this.numVidas = this.vidasIn;
	}
	
	public void ActualizaRecord() {
		if (this.numVidas == this.record) 
			System.out.println("Se ha alcanzado el record!");
		else if (this.numVidas > this.record) {
			System.out.println("Has superado en antiguo record: " + this.record + " , este es el nuevo record: " + this.numVidas);
			this.record = this.numVidas;
		}

	}
	
	public int getNumVidas() {
		return numVidas;
	}


	public void setNumVidas(int numVidas) {
		this.numVidas = numVidas;
	}


	public int getVidasIn() {
		return vidasIn;
	}


	public void setVidasIn(int vidasIniciales) {
		this.vidasIn = vidasIniciales;
	}


	public int getRecord() {
		return record;
	}


	public void setRecord(int record) {
		this.record = record;
	}


	public abstract void Juega();
	
}
