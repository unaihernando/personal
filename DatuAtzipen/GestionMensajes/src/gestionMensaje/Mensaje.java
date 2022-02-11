package gestionMensaje;

import java.util.Date;

public class Mensaje {
	private String de;
	private String para;
	private String asunto;
	private String contenido;
	private Date fecha;
	
	public Mensaje()
	{}
	
	public Mensaje(String de,String para,String asunto,String contenido,Date fecha) {
		this.de = de;
		this.para = para;
		this.asunto = asunto;
		this.contenido = contenido;
		this.fecha = fecha;
	}
	
	public String getDe() {
		return de;
	}
	public void setDe(String de) {
		this.de = de;
	}
	public String getPara() {
		return para;
	}
	public void setPara(String para) {
		this.para = para;
	}
	public String getAsunto() {
		return asunto;
	}
	public void setAsunto(String asunto) {
		this.asunto = asunto;
	}
	public String getContenido() {
		return contenido;
	}
	public void setContenido(String contenido) {
		this.contenido = contenido;
	}
	public Date getFecha() {
		return fecha;
	}
	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}
	

}
