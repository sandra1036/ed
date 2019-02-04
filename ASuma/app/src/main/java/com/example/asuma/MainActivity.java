package com.example.asuma;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import java.math.BigDecimal;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void SendMessage(View view){

        EditText editText= findViewById(R.id.editTextNum1);
        EditText editText2=findViewById(R.id.editTextNum2);

        System.out.println("Ejecutando num 1"+editText.getText().toString());
        System.out.println("Ejecutando num 2"+editText2.getText().toString());


    }
    public static void  Resultado(double num1,double num2){
        double suma=0;
        suma=num1+num2;
        System.out.println(suma);
    }

}
