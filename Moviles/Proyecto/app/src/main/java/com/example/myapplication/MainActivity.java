package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.content.Context;
import android.content.SharedPreferences;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    private EditText ed1,ed2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ed1 = findViewById(R.id.editTextTextPersonName);
        ed2 = findViewById(R.id.editTextTextPassword);
    }

    public void onClick(View v) {
        String usuario = ed1.getText().toString();
        String contraseña = ed2.getText().toString();
        if (usuario.equals("") || contraseña.equals(""))
            Toast.makeText(this, R.string.errorUsuario, Toast.LENGTH_LONG).show();
        else {
            SharedPreferences preferencias = getSharedPreferences("agenda", Context.MODE_PRIVATE);
            if (preferencias.contains(usuario)) {
                String d = preferencias.getString(usuario, "");
                if (contraseña.equals(d)) {
                    Intent i = new Intent(this, MainActivity2.class);
                    i.putExtra("contra", contraseña);
                    i.putExtra("usuario", usuario);
                    startActivity(i);
                } else {
                    Toast.makeText(this, getString(R.string.errorUsuario),
                            Toast.LENGTH_LONG).show();
                    ed1.setText("");
                    ed2.setText("");
                }
            } else {
                SharedPreferences.Editor editor = preferencias.edit();
                editor.putString(usuario, contraseña);
                editor.commit();
                Toast.makeText(this, getString(R.string.usuarioCreado), Toast.LENGTH_LONG).show();
            }
        }
    }
}