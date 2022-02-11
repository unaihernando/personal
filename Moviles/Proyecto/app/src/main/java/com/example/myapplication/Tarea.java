package com.example.myapplication;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.content.DialogInterface;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class Tarea extends AppCompatActivity {

    private TextView nombreTexto;
    private TextView descripcionTexto;
    private TextView fechaTexto;
    private TextView prioridadTexto;
    private TextView costeTexto;
    private TextView estadoTexto;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tarea);
        nombreTexto = findViewById(R.id.nombreTarea);
        descripcionTexto = findViewById(R.id.descripcionTarea);
        fechaTexto = findViewById(R.id.fechaTarea);
        prioridadTexto = findViewById(R.id.tareaPrioridad);
        costeTexto = findViewById(R.id.tareaCoste);
        estadoTexto = findViewById(R.id.estadoTarea);

        Bundle bundle = getIntent().getExtras();
        String nombre = (String) bundle.get("nombre");
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this,
                "administracion", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        nombreTexto.setText(nombre);
        Cursor fila = bd.rawQuery(
                "select descripcion,fecha , coste , prioridad, estado from tareas " +
                        "where nombre='"
                        + nombre +"'", null);
        if (fila.moveToFirst()) {
            descripcionTexto.setText(fila.getString(0));
            fechaTexto.setText(fila.getString(1));
            costeTexto.setText(fila.getString(2));
            prioridadTexto.setText(fila.getString(3));
            estadoTexto.setText(fila.getString(4));

        }
        bd.close();
    }

    public void volver(View v){
        onBackPressed();
    }

    public void borrar(View v){
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle(getString(R.string.borrarS));
        builder.setPositiveButton(getString(R.string.borrar),
                new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(Tarea.this,
                        "administracion", null, 1);
                SQLiteDatabase bd = admin.getWritableDatabase();
                int cant = bd.delete("tareas", "nombre='"+
                        nombreTexto.getText() +"'",null);
                if(cant == 1)
                    Toast.makeText(Tarea.this, R.string.borrada,
                            Toast.LENGTH_SHORT).show();
                onBackPressed();
            }
        });
        builder.setNegativeButton(getString(R.string.cancelar), null);
        AlertDialog dialog = builder.create();
        dialog.show();
    }

    public void realizar(View v){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(Tarea.this,
                "administracion", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        Cursor fila = bd.rawQuery(
                "select estado from tareas where nombre='" + nombreTexto.getText()
                        +"'", null);
        if(fila.moveToFirst()){
            if(fila.getString(0).equalsIgnoreCase(getString(R.string.hecha))){
                Toast.makeText(Tarea.this, getString(R.string.tyr),
                        Toast.LENGTH_SHORT).show();
                bd.close();
                onBackPressed();
            }else{
                ContentValues registro = new ContentValues();
                registro.put("estado", getString(R.string.hecha));
                int cant = bd.update("tareas", registro, "nombre='"
                        + nombreTexto.getText()+"'",null);
                bd.close();
                if (cant == 1)
                    Toast.makeText(this, getString(R.string.dtm),
                            Toast.LENGTH_SHORT).show();
                onBackPressed();
            }
        }
    }
}