package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.ContentValues;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.util.Calendar;

public class NuevaTarea extends AppCompatActivity {
    private EditText ed1,ed2,ed4;
    private TextView ed3;
    private Spinner sp;
    private RadioButton rb1,rb2;
    private Calendar cal;
    private DatePickerDialog datePickerDialog;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nueva_tarea);
        ed1 = findViewById(R.id.editTextTextPersonName1);
        ed2 = findViewById(R.id.editTextTextPersonName2);
        ed4 = findViewById(R.id.editTextNumber);
        sp = findViewById(R.id.spinner);
        String opciones[] = {getString(R.string.urgente), getString(R.string.alta),
                getString(R.string.media), getString(R.string.baja)};
        ArrayAdapter<String> adapter = new
                ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, opciones);
        sp.setAdapter(adapter);
        rb1 = findViewById(R.id.radioButton2);
        rb2 = findViewById(R.id.radioButton);
        ed3 = findViewById(R.id.editTextDate);
        ed3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                cal = Calendar.getInstance();
                int dia = cal.get(Calendar.DAY_OF_MONTH);
                int mes = cal.get(Calendar.MONTH);
                int año = cal.get(Calendar.YEAR);
                datePickerDialog = new DatePickerDialog(NuevaTarea.this,
                        new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker datePicker, int año, int mes, int dia) {
                        ed3.setText(dia + "/" + (mes+1) + "/" + año);
                    }
                    }, año,mes,dia);datePickerDialog.show();
            }
        }
        );
    }

    public void alta(View v) {
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this,
                "administracion", null, 1);
        SQLiteDatabase bd = admin.getWritableDatabase();
        String nombre = ed1.getText().toString();
        String descri = ed2.getText().toString();
        String pre = ed4.getText().toString();
        String fecha = ed3.getText().toString();
        String prio = sp.getSelectedItem().toString();
        String estado = "";
        if (!rb1.isChecked() && !rb2.isChecked() || nombre.equals("") || descri.equals("") ||
                pre.equals("") || fecha.equals(getString(R.string.clicarFecha))){
            Toast.makeText(this, getString(R.string.tareaMal),
                    Toast.LENGTH_SHORT).show();
            startActivity(getIntent());
        }else {
            if (rb1.isChecked()) {
                estado = "Realizada";
            } else if (rb2.isChecked()) {
                estado = "No Realizada";
            }
            ContentValues registro = new ContentValues();
            registro.put("nombre", nombre);
            registro.put("descripcion", descri);
            registro.put("fecha", fecha);
            registro.put("coste", pre);
            registro.put("prioridad", prio);
            registro.put("estado", estado);
            bd.insert("tareas", null, registro);
            bd.close();
            Toast.makeText(this, getString(R.string.guardarTarea),
                    Toast.LENGTH_SHORT).show();
            Intent i = new Intent(this, MainActivity2.class);
            startActivity(i);
        }
    }

    public void cancelar(View v) {
        onBackPressed();
    }
}