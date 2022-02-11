package com.example.checkbox;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText et1,et2;
    private TextView tv;
    private CheckBox ch1,ch2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et1 = findViewById(R.id.editTextNumber);
        et2 = findViewById(R.id.editTextNumber2);
        tv = findViewById(R.id.textView);
        ch1 = findViewById(R.id.checkBox);
        ch2 = findViewById(R.id.checkBox2);
    }

    public void operar(View view){
        String resultado = "";
        if(ch1.isChecked() == true){
            int suma = Integer.parseInt(et1.getText().toString()) +
                    Integer.parseInt(et2.getText().toString());
            resultado = "La suma es: "+suma;
        }
        if(ch2.isChecked() == true){
            int resta = Integer.parseInt(et1.getText().toString()) -
                    Integer.parseInt(et2.getText().toString());
            resultado = "La resta es: "+resta;
        }
        tv.setText(resultado);
    }
}