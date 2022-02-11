import java.io.Serializable;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class Persona implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String nif;
	private String nombre;
	private String apellido;
	private Date fechaNacimento;
	private char genero;
	public String getNif() {
		return nif;
	}
	public void setNif(String nif) {
		this.nif = nif;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public String getApellido() {
		return apellido;
	}
	public void setApellido(String apellido) {
		this.apellido = apellido;
	}
	public Date getFechaNacimento() {
		return fechaNacimento;
	}
	public void setFechaNacimento(int anyo, int mes, int dia) {
		
		Calendar cal = new GregorianCalendar(anyo,mes-1,dia);
		
		this.fechaNacimento = cal.getTime();
	}
	public char getGenero() {
		return genero;
	}
	public void setGenero(char genero) {
		this.genero = genero;
	}
	@Override
	public String toString() {
		return "Persona [nif=" + nif + ", nombre=" + nombre + ", apellido=" + apellido + ", fechaNacimento="
				+ fechaNacimento + ", genero=" + genero + "]";
	}
	
	

}
