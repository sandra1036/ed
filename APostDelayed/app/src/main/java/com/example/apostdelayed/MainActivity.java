package com.example.apostdelayed;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    private Button button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        button = findViewById(R.id.button);

        //asignar al boton sin entrar en el diseño

        //clase anonima
//        button.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                button.postDelayed(new Runnable() {
//          @Override
//           public void run() {
//              button.setText("");
//          }
//       },2000);
//
//                }
//        });
        //expresion lambda
//        button.setOnClickClickListener(v -> {
//
//        });

        //referencia al metodo

        button.setOnClickListener(this::onButtonClick);

    }

    public void onButtonClick(View view){
        Log.i(MainActivity.class.getSimpleName(),"Ejecutando onButtonClick");
        button.setText("Hola");

//        button.postDelayed(new Runnable() {
//            @Override
//            public void run() {
//                button.setText("");
//
//            }
//        },2000);


        //Expresion Lambda

       // button.postDelayed(()-> button.setText(""),2000);

        //Referencia al metodo

        button.postDelayed(this::kkita, 2000);
    }

private void kkita(){

        button.setText("");

}
}
