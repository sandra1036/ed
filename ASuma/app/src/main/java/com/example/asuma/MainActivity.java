package com.example.asuma;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.math.BigDecimal;

public class MainActivity extends AppCompatActivity {

      private EditText editTextNum1;
      private EditText editTextNum2;
      private TextView textViewResult;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        editTextNum1= findViewById(R.id.editTextNum1);
        editTextNum2= findViewById(R.id.editTextNum2);
        textViewResult=findViewById(R.id.TextViewResult);

    }
    public void resultado(View view){
//
//        System.out.println("Ejecutando num 1"+editTextNum1.getText().toString());
//        System.out.println("Ejecutando num 2"+editTextNum2.getText().toString());
//
//        double num1=Double.parseDouble(editTextNum1.getText().toString());
//        double num2=Double.parseDouble(editTextNum2.getText().toString());
//        double sum=num1+num2;
//        textViewResult.setText(String.valueOf(sum));

        BigDecimal num1=new BigDecimal(editTextNum1.getText().toString());
        BigDecimal num2=new BigDecimal(editTextNum2.getText().toString());
        BigDecimal result=num1.add(num2);
        textViewResult.setText(result.toString());


    }
//    private double getDouble1(){
//        //String string1=editTextNum1.getText().toString();
//        return double num1=Double.parseDouble(editTextNum1.getText().toString());
//
//    }
//    private double getDouble2(){
//        //String string2=editTextNum2.getText().toString();
//        double num2=Double.parseDouble(editTextNum2.getText().toString());
//    }

    public void onButtonRestaClick(View view){
//        System.out.println("onButtonResta ejecutando");
//        double num1=Double.parseDouble(editTextNum1.getText().toString());
//        double num2=Double.parseDouble(editTextNum2.getText().toString());
//        double rest=num1-num2;
//        textViewResult.setText(String.valueOf(rest));

        BigDecimal num1=new BigDecimal(editTextNum1.getText().toString());
        BigDecimal num2=new BigDecimal(editTextNum2.getText().toString());
        BigDecimal result= num1.subtract(num2);
        textViewResult.setText(result.toString());

    }


}
