package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class MainActivityAcercaDe extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_acerca_de);
    }

    public void llamar(View view) {
        Uri uri = Uri.parse("https://www.instagram.com/android/?hl=es");
        Intent intent = new Intent(Intent.ACTION_VIEW, uri);
        startActivity(intent);
    }

    public void llamar2(View view) {
        Uri uri = Uri.parse("https://es-la.facebook.com/AndroidOfficial/");
        Intent intent = new Intent(Intent.ACTION_VIEW, uri);
        startActivity(intent);
    }

    public void llamar3(View view) {
        Uri uri = Uri.parse("https://twitter.com/android/");
        Intent intent = new Intent(Intent.ACTION_VIEW, uri);
        startActivity(intent);
    }
}