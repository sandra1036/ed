package com.example.myfirstapp;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import org.w3c.dom.Text;

public class DisplayMessageActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_message);


        String message=getIntent().getStringExtra(MainActivity.Kay_Message);

        TextView textView=findViewById(R.id.textView);
//        textView.setText(MainActivity.getMessage());
        textView.setText(message);
    }
}
