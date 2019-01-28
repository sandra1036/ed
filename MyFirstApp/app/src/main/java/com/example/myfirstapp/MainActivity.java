package com.example.myfirstapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import java.io.Console;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void sendMessage(View view){

        EditText editText= findViewById(R.id.editText);
        System.out.println("ejecutando sendMessage editText.getText().toString()="+
                editText.getText().toString());
        Intent intent = new Intent(this, DisplayMessageActivity.class );
        startActivity(intent);

    }
}
