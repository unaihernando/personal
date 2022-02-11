
public class Buffer {
	private char caracter;
	private boolean bufferlleno = false;

	public Buffer() {
	}

	public synchronized char recoger() {
		while (!bufferlleno) {
			try {
				wait();
			} catch (InterruptedException ex) {
			}
		}
		bufferlleno = false;
		
		notify();
		
		return caracter;
		
	}

	public synchronized void poner(char valor) {
		while (bufferlleno) {
			try {
				wait();
			} catch (InterruptedException ex) {
			}
		}
		caracter = valor;
		bufferlleno = true;
		notify();
	}

}