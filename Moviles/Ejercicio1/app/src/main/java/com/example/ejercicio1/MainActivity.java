package com.example.ejercicio1;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private EditText edt1;
    private EditText edt2;
    private TextView tv1;
    private Spinner sp1;
    private String[] lista = {"Vizcaya", "Gipuzkoa", "Araba"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edt1 = findViewById(R.id.editTextTextMultiLine);
        edt2 = findViewById(R.id.editTextPhone);
        tv1 = findViewById(R.id.textViewDatos);
        sp1 = findViewById(R.id.spinner);

        ArrayAdapter <String> adapter =
                new ArrayAdapter<String>(this,android.R.layout.simple_list_item_1, lista);
        sp1.setAdapter(adapter);


    }
    @SuppressLint("SetTextI18n")
    public void resultado(View view){
        tv1.setText(
                "Identificador: "+edt1.getText().toString()+
                "\nTelefono: "+edt2.getText().toString()+
                "\nProvincia: "+sp1.getSelectedItem().toString()
        );
        String texto = "Identificador: "+edt1.getText().toString()+
                "\nTelefono: "+edt2.getText().toString()+
                "\nProvincia: "+sp1.getSelectedItem().toString();

        Toast notificacion = Toast.makeText(this, texto, Toast.LENGTH_SHORT);
        notificacion.show();
    }


}