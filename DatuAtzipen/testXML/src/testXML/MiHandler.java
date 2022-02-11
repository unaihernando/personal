package testXML;

import java.util.ArrayList;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class MiHandler extends DefaultHandler{
	
	boolean nombre = false;
	boolean grado = false;
	 private ArrayList<Ciclo> ciclos = new ArrayList<Ciclo>();
	 Ciclo miciclo = new Ciclo();
	 @Override
	    public void startElement(String uri, String localName, String Name, Attributes attributos) throws SAXException {
	       	if(Name.equals("nombre"))
	       		nombre = true;
	    	if(Name.equals("grado"))
	       		grado = true;
		 
	    }
	 
	 
	  public ArrayList<Ciclo> obtenerCiclos(){
		  return ciclos;
	  }
	 
	    @Override
	    public void characters(char[] ch, int start, int length) throws SAXException {
	    
	        if(nombre)
	        {
	        	miciclo.setNombre(new String(ch, start, length));
	        	nombre = false;
	        }
	        
	        if(grado)
	        {
	        	miciclo.setGrado(new String(ch, start, length));
	        	grado = false;
	        }
	        
	        	
	    }
	 
	    @Override
	    public void endElement(String uri, String localName, String qName) throws SAXException {
	    	if(qName.equals("ciclo"))
	    	{
		    	ciclos.add(miciclo);
		    	miciclo = new Ciclo();
	    	}	
	       
	    }
	 

}
