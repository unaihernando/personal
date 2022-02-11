package testXML;

import java.io.IOException;
import java.util.ArrayList;

import javax.xml.parsers.ParserConfigurationException;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

import org.xml.sax.SAXException;

public class ApliXML {

	public static void main(String[] args) {
		
		try {
			SAXParserFactory factory =SAXParserFactory.newInstance();
			MiHandler miHandler = new MiHandler();
			SAXParser parser = factory.newSAXParser();
			parser.parse("test.xml", miHandler);
			
			
			ArrayList<Ciclo> misCiclos = miHandler.obtenerCiclos();
			
			for( Ciclo ciclo: misCiclos)
			{
				System.out.println("Nombre " + ciclo.getNombre() );
				System.out.println("Grado " + ciclo.getGrado() );
			}
			
		} catch (ParserConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SAXException e ) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
		
		

	}

}
