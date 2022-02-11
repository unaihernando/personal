package com.example.menuscon;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.graphics.Color;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

        private Button btn;
       @Override
       protected void onCreate(Bundle savedInstanceState) {
           super.onCreate(savedInstanceState);
           setContentView(R.layout.activity_main);
           btn = findViewById(R.id.button);
           registerForContextMenu(btn);
       }
       @Override
       public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
           super.onCreateContextMenu(menu, v, menuInfo);
           menu.setHeaderTitle("Tipo de consulta");
           menu.add(0, v.getId(), 0, "Modificar");
           menu.add(0, v.getId(), 0, "Borrar");
       }
       @Override
       public boolean onContextItemSelected(MenuItem item) {

           if (item.getTitle() == "Modificar") {
               Toast.makeText(this, "Bien" , Toast.LENGTH_SHORT).show();
           }
           return true;
       }
}