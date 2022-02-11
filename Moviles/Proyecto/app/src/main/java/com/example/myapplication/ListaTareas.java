package com.example.myapplication;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Color;
import android.net.Uri;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.inputmethod.EditorInfo;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.Toast;

import com.google.android.material.navigation.NavigationView;

import java.util.ArrayList;

public class ListaTareas extends AppCompatActivity {
    private ListView lv;
    private String noHechas = "No Realizada", hechas = "Realizada", contraseña, usuario;
    private ArrayList<String> tareas = new ArrayList<>();
    private String str ="";
    private Button btn, btn1, btn2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista_tareas);

        btn = findViewById(R.id.button9);
        btn1 = findViewById(R.id.button7);
        btn2 = findViewById(R.id.button6);

        lv = findViewById(R.id.listView);
        registerForContextMenu(lv);

        Bundle bundle = getIntent().getExtras();
        contraseña = bundle.getString("contra");
        usuario = bundle.getString("usuario");


        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",
                null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        Cursor fila = bd.rawQuery(
                "select nombre from tareas", null);
        if (fila.moveToFirst()) {
            do {
                tareas.add(fila.getString(0));
            } while (fila.moveToNext());
        }
        bd.close();
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_list_item_1, tareas);
        lv.setAdapter(adapter);
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView adapterView, View view, int i, long l) {
                Intent intent = new Intent(view.getContext(),Tarea.class);
                intent.putExtra("nombre",tareas.get(i));
                startActivity(intent);
            }
        });
    }

    public void hechas(View v){
        ArrayList<String> tareas = new ArrayList<>();
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",
                null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        Cursor fila = bd.rawQuery(
                "select nombre from tareas where estado = '"+hechas+"'", null);
        if (fila.moveToFirst()) {
            do {
                tareas.add(fila.getString(0));
            } while (fila.moveToNext());
        }
        bd.close();
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_list_item_1, tareas);
        lv.setAdapter(adapter);
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView adapterView, View view, int i, long l) {
                Intent intent = new Intent(view.getContext(),Tarea.class);
                intent.putExtra("nombre",tareas.get(i));
                startActivity(intent);
            }
        });
    }

    public void nohechas(View v){
        ArrayList<String> tareas = new ArrayList<>();
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this, "administracion",
                null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        Cursor fila = bd.rawQuery(
                "select nombre from tareas where estado = '"+noHechas+"'", null);
        if (fila.moveToFirst()) {
            do {
                tareas.add(fila.getString(0));
            } while (fila.moveToNext());
        }
        bd.close();
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_list_item_1, tareas);
        lv.setAdapter(adapter);
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView adapterView, View view, int i, long l) {
                Intent intent = new Intent(view.getContext(),Tarea.class);
                intent.putExtra("nombre",tareas.get(i));
                startActivity(intent);
            }
        });
    }

    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo
            menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        AdapterView.AdapterContextMenuInfo info =
                (AdapterView.AdapterContextMenuInfo)menuInfo;
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menucontextual, menu);
        str = lv.getAdapter().getItem(info.position).toString();
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {
        AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)
                item.getMenuInfo();
        switch(item.getItemId()) {
            case R.id.Modificar:
                Intent intent = new Intent(this,ModificarTarea.class);
                intent.putExtra("nombre",str);
                startActivity(intent);
                return true;
            case R.id.Borrar:
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.setTitle(getString(R.string.borrarS));
                builder.setPositiveButton(getString(R.string.borrar),
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(
                                        ListaTareas.this,
                                        "administracion", null, 1);
                                SQLiteDatabase bd = admin.getWritableDatabase();
                                int cant = bd.delete("tareas",
                                        "nombre='"+str +"'",null);
                                if(cant == 1){
                                    Toast.makeText(ListaTareas.this, R.string.borrada,
                                            Toast.LENGTH_SHORT).show();
                                }
                                bd.close();
                                startActivity(getIntent());
                            }
                        });
                builder.setNegativeButton(getString(R.string.cancelar), null);
                AlertDialog dialog = builder.create();
                dialog.show();
                return true;
            default:
                return super.onContextItemSelected(item);
        }
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
            LinearLayout layout = new LinearLayout(ListaTareas.this);
            layout.setOrientation(LinearLayout.VERTICAL);
            final EditText editTextContraseña = new EditText(ListaTareas.this);
            editTextContraseña.setHint(R.string.contraseña);
            layout.addView(editTextContraseña);
            final EditText editTextNuevaContraseña = new EditText(ListaTareas.this);
            editTextNuevaContraseña.setInputType(EditorInfo.TYPE_TEXT_VARIATION_PASSWORD);
            editTextNuevaContraseña.setHint(R.string.contraseñaNueva);
            layout.addView(editTextNuevaContraseña);
            final AlertDialog.Builder builder = new AlertDialog.Builder(ListaTareas.this);
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
                                Toast.makeText(ListaTareas.this,
                                        R.string.exito,
                                            Toast.LENGTH_SHORT).show();
                                }else {
                                    Toast.makeText(ListaTareas.this, R.string.contraMal,
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
                btn.setBackgroundColor(Color.parseColor("#827717"));
                btn1.setBackgroundColor(Color.parseColor("#827717"));
                btn2.setBackgroundColor(Color.parseColor("#827717"));
            }
            if (id == R.id.app3) {
                Intent i = new Intent(this, MainActivity.class);
                startActivity(i);
            }
            return super.onOptionsItemSelected(item);
    }

    public void actualizar(View v){
        startActivity(getIntent());
    }
}