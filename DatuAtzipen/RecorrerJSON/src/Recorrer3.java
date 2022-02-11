import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Iterator;

import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import com.google.gson.JsonPrimitive;

public class Recorrer3 {

	public static void main(String[] args) {
		try {
			JsonParser parser = new JsonParser();
			FileReader fr;
			fr = new FileReader("stocks.json");
			JsonElement datos = parser.parse(fr);
			dumpJSONElement(datos);
			
			

			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public static void dumpJSONElement(JsonElement elemento) {
	    if (elemento.isJsonObject()) {
	        System.out.println("Objeto");
	        JsonObject obj = elemento.getAsJsonObject();
	        java.util.Set<java.util.Map.Entry<String,JsonElement>> entradas = obj.entrySet();
	        java.util.Iterator<java.util.Map.Entry<String,JsonElement>> iter = entradas.iterator();
	        while (iter.hasNext()) {
	            java.util.Map.Entry<String,JsonElement> entrada = iter.next();
	            System.out.println("Atributo:  " + entrada.getKey());
	            dumpJSONElement(entrada.getValue());
	        }
	 
	    } else if (elemento.isJsonArray()) {
	        JsonArray array = elemento.getAsJsonArray();
	        System.out.println("Array. Numero de elementos: " + array.size());
	        java.util.Iterator<JsonElement> iter = array.iterator();
	        while (iter.hasNext()) {
	            JsonElement entrada = iter.next();
	            dumpJSONElement(entrada);
	        }
	    } else if (elemento.isJsonPrimitive()) {
	        JsonPrimitive valor = elemento.getAsJsonPrimitive();
	        if (valor.isBoolean()) {
	            System.out.println("       Boolean " + valor.getAsBoolean());
	        } else if (valor.isNumber()) {
	            System.out.println("       Numero: " + valor.getAsNumber());
	        } else if (valor.isString()) {
	            System.out.println("       Texto: " + valor.getAsString());
	        }
	    } else if (elemento.isJsonNull()) {
	        System.out.println("Es NULL");
	    } else {
	        System.out.println("Es otra cosa");
	    }
	}
}
