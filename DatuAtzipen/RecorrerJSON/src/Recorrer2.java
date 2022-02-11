
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Iterator;
import java.util.Map;

import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import com.google.gson.JsonPrimitive;

public class Recorrer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JsonParser parser = new JsonParser();
		final String url = "stocks.json";

		try {

			FileReader fr = new FileReader(url);
			JsonElement datos = parser.parse(fr);

			JsonArray array = datos.getAsJsonArray();
			Iterator<JsonElement> iter = array.iterator();
			while (iter.hasNext()) {
				JsonElement entrada = iter.next();
				JsonObject objeto = entrada.getAsJsonObject();
				Iterator<Map.Entry<String, JsonElement>> iter2 = objeto.entrySet().iterator();
				JsonPrimitive valor = iter2.next().getValue().getAsJsonPrimitive();
				System.out.println("\tCompany: " + valor.getAsString());
				
				JsonPrimitive valor2 = iter2.next().getValue().getAsJsonPrimitive();
				System.out.println("\tDescription: " + valor2.getAsString());
				
				JsonPrimitive valor3 = iter2.next().getValue().getAsJsonPrimitive();
				System.out.println("\tInitial_price: " + valor3.getAsNumber());
				
				JsonPrimitive valor4 = iter2.next().getValue().getAsJsonPrimitive();
				System.out.println("\tprice_2002: " + valor4.getAsNumber());
				
				JsonPrimitive valor5 = iter2.next().getValue().getAsJsonPrimitive();
				System.out.println("\tprice_2007: " + valor5.getAsNumber());
				
				JsonPrimitive valor6 = iter2.next().getValue().getAsJsonPrimitive();
				System.out.println("\tsymbol: " + valor6.getAsString());
				
			}

		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
