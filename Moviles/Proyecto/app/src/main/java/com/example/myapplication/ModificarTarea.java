package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.DatePicker;
import android.widget.TextView;
import android.widget.Toast;

import java.util.Calendar;

public class ModificarTarea extends AppCompatActivity {

    private TextView nombreTexto;
    private TextView descripcionTexto;
    private TextView fechaTexto;
    private TextView prioridadTexto;
    private TextView costeTexto;
    private TextView estadoTarea;
    private String nombreTarea;
    private DatePickerDialog datePickerDialog;
    private Calendar cal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_modificar_tarea);
        nombreTexto = findViewById(R.id.nombreTarea);
        descripcionTexto = findViewById(R.id.descripcionTarea);
        fechaTexto = findViewById(R.id.fechaTarea1);
        prioridadTexto = findViewById(R.id.tareaPrioridad);
        costeTexto = findViewById(R.id.tareaCoste);
        estadoTarea = findViewById(R.id.estadoTarea);

        fechaTexto.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                cal = Calendar.getInstance();
                int dia = cal.get(Calendar.DAY_OF_MONTH);
                int mes = cal.get(Calendar.MONTH);
                int año = cal.get(Calendar.YEAR);
                datePickerDialog = new DatePickerDialog(ModificarTarea.this,
                        new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker datePicker, int año, int mes, int dia) {
                        fechaTexto.setText(dia + "/" + (mes+1) + "/" + año);
                    }
                    }, año,mes,dia);datePickerDialog.show();
            }
        }
        );

        Bundle bundle = getIntent().getExtras();
        String nombre = bundle.get("nombre").toString();
        nombreTarea = bundle.get("nombre").toString();
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this,
                "administracion", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        nombreTexto.setText(nombre);
        Cursor fila = bd.rawQuery(
                "select descripcion,fecha , coste , prioridad, estado from tareas" +
                        " where nombre='"
                        + nombre + "'", null);
        if (fila.moveToFirst()) {
            descripcionTexto.setText(fila.getString(0));
            fechaTexto.setText(fila.getString(1));
            costeTexto.setText(fila.getString(2));
            prioridadTexto.setText(fila.getString(3));
            estadoTarea.setText(fila.getString(4));
        }
        bd.close();
    }

    public void modificarTarea(View v) {
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this,
                "administracion", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String nombre = nombreTexto.getText().toString();
        Cursor fila = bd.rawQuery(
                "select descripcion,fecha , coste , prioridad, estado " +
                        "from tareas where nombre='" + nombre + "'", null);

        if (fila.moveToFirst()) {
                ContentValues registro = new ContentValues();
                registro.put("descripcion", descripcionTexto.getText().toString());
                registro.put("fecha", fechaTexto.getText().toString());
                registro.put("coste", costeTexto.getText().toString());
                registro.put("prioridad", prioridadTexto.getText().toString());
                registro.put("estado", estadoTarea.getText().toString());
                int cant = bd.update("tareas", registro, "nombre='" +
                        nombre + "'", null);
                if (cant == 1)
                    Toast.makeText(this, getString(R.string.dtm),
                            Toast.LENGTH_SHORT).show();
                onBackPressed();
            }else {
                    bd.delete("tareas", "nombre='" + nombreTarea + "'",
                            null);
                    ContentValues registro = new ContentValues();
                    registro.put("nombre", nombre);
                    registro.put("descripcion", descripcionTexto.getText().toString());
                    registro.put("fecha", fechaTexto.getText().toString());
                    registro.put("coste", costeTexto.getText().toString());
                    registro.put("prioridad", prioridadTexto.getText().toString());
                    registro.put("estado", estadoTarea.getText().toString());
                    bd.insert("tareas", null, registro);
                    Toast.makeText(this, getString(R.string.dtm),
                            Toast.LENGTH_SHORT).show();
                    onBackPressed();
            }
        bd.close();
    }
}