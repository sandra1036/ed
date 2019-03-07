package com.example.apostdelayed;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TableLayout;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class MainActivity extends AppCompatActivity {

//    private Button button
    private final static String TAG=MainActivity.class.getSimpleName();
private List<Integer> ids=
        Arrays.asList(R.id.button,R.id.button2,R.id.button3);
private List <Button> buttonList=new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        for (int id: ids) {
            final Button button = findViewById(id);
            buttonList.add(button);
            button.setOnClickListener(v -> {
                Log.i(MainActivity.class.getSimpleName(), "onClickListener");
            });
        }

        TableLayout tableLayout = findViewById(R.id.tableLayout);
        View view;
        for (int index = 0; index < tableLayout.getChildCount(); index++) {
            view = tableLayout.getChildAt(index);
            if (view instanceof ViewGroup)
                Log.i(TAG, String.format("index %s view %s", index, view);

        }
       private List<View> getLeafChildren(ViewGroup viewGroup){
            List<View>leafChildren=new ArrayList<>();
            for (int index=0;index<viewgroup.getChildCount();index++){
                View view =viewGroup.getChildAt(index);
                if(view instanceof ViewGroup)
                    leafChildren.addAll(getLeafChildren((ViewGroup)view));
                else
                    leafChildren.add(view);

            }
            return leafChildren;

        }




//        button = findViewById(R.id.button);

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

//        button.setOnClickListener(this::onButtonClick);

    }

    public void onButtonClick(View view){
        Log.i(MainActivity.class.getSimpleName(),"Ejecutando onButtonClick");

//        button.setText("Hola");

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
//
//        button.postDelayed(this::kkita, 2000);
    }

//private void kkita(){
//
//        button.setText("");
//
//}
}
