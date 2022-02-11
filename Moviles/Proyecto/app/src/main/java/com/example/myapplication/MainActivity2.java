package com.example.myapplication;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.google.android.material.navigation.NavigationView;

public class MainActivity2 extends AppCompatActivity  {
    private Button btn1,btn2;
    private String contraseña, usuario;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        btn1 = findViewById(R.id.button2);
        btn2 = findViewById(R.id.button3);

        Bundle bundle = getIntent().getExtras();
        contraseña = bundle.getString("contra");
        usuario = bundle.getString("usuario");
    }
    public void crear(View v){
        Intent i = new Intent(this, NuevaTarea.class);
        startActivity(i);
    }
    public void lista(View v){
        Intent i = new Intent(this, ListaTareas.class);
        i.putExtra("contra", contraseña);
        i.putExtra("usuario",usuario);
        startActivity(i);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menuopciones, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item){
        int id = item.getItemId();

        if(id==R.id.opcion1) {
            LinearLayout layout = new LinearLayout(MainActivity2.this);
            layout.setOrientation(LinearLayout.VERTICAL);
            final EditText editTextContraseña = new EditText(MainActivity2.this);
            editTextContraseña.setHint(R.string.contraseña);
            layout.addView(editTextContraseña);
            final EditText editTextNuevaContraseña = new EditText(MainActivity2.this);
            editTextNuevaContraseña.setInputType(EditorInfo.TYPE_TEXT_VARIATION_PASSWORD);
            editTextNuevaContraseña.setHint(R.string.contraseñaNueva);
            layout.addView(editTextNuevaContraseña);
            final AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity2.this);
            builder
                    .setTitle(R.string.cambiocontra)
                    .setNegativeButton(R.string.cancelar, null)
                    .setPositiveButton(R.string.cambio, new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            SharedPreferences preferencias =
                                    getSharedPreferences("agenda", MODE_PRIVATE);
                            String contraseñaVieja = editTextContraseña.getText().toString();
                            if (contraseña.equals(contraseñaVieja)) {
                                String contraseñaNueva = editTextNuevaContraseña.getText().
                                        toString();
                                SharedPreferences.Editor editor=preferencias.edit();
                                editor.remove(usuario);
                                editor.putString(usuario, contraseñaNueva);
                                editor.commit();
                                Toast.makeText(MainActivity2.this,
                                        R.string.exito,
                                        Toast.LENGTH_SHORT).show();
                            }else {
                                Toast.makeText(MainActivity2.this, R.string.contraMal,
                                        Toast.LENGTH_SHORT).show();
                            }
                        }
                    });
            final AlertDialog alertDialogPersonalizado = builder.create();
            alertDialogPersonalizado.setView(layout);
            alertDialogPersonalizado.show();
        }
        if(id==R.id.opcion2){
            Intent i = new Intent(this, MainActivityAcercaDe.class);
            startActivity(i);
        }
        if(id==R.id.opcion3){
            Intent i = new Intent(this, NuevaTarea.class);
            startActivity(i);
        }
        if (id == R.id.app1) {
            Uri uri = Uri.parse("https://www.google.com/intl/es/gmail/about/#");
            Intent intent = new Intent(Intent.ACTION_VIEW, uri);
            startActivity(intent);
        }
        if (id == R.id.app2) {
            btn1.setBackgroundColor(Color.parseColor("#827717"));
            btn2.setBackgroundColor(Color.parseColor("#827717"));
        }
        if (id == R.id.app3) {
            Intent i = new Intent(this, MainActivity.class);
            startActivity(i);
        }
        return super.onOptionsItemSelected(item);
    }
}