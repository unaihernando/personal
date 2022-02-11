package com.example.aletdialog;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.os.Bundle;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Titulo");
        builder.setMessage("Mensaje");
        builder.setPositiveButton("Aceptar", null);
        AlertDialog dialog = builder.create();
        dialog.show();

        AlertDialog.Builder builder1 = new AlertDialog.Builder(this);
        builder1.setTitle("AlertDialog 2 botones");
        builder1.setMessage("¿Quieres cerrar la app?");
        builder1.setPositiveButton("Aceptar", null);
        builder1.setNegativeButton("Cancelar", null);
        builder1.setNeutralButton("Recordar más tarde", null);
        AlertDialog dialog1 = builder1.create();
        dialog1.show();
    }
}