package com.example.eventos;

import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private Button bt;
    private TextView tv;
    private int cont = 0;
    private String reinString = "¿Desea reiniciar el contador?";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        bt = findViewById(R.id.boton);
        tv = findViewById(R.id.textview);
        

        bt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                cont = cont + 1;
                tv.setText(String.valueOf(cont));
            }
        });
        bt.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View view) {
                cont = 0;
                tv.setText(String.valueOf(cont));
                return false;
            }
        });
    }
}