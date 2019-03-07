package com.example.apares;

import android.graphics.drawable.ColorDrawable;
import android.graphics.drawable.Drawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ImageButton;
import android.widget.ImageView;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class MainActivity extends AppCompatActivity {


      private List<Integer> ids=
              Arrays.asList(R.id.imageButton1, R.id.imageButton2, R.id.imageButton30, R.id.imageButton4,
                      R.id.imageButton5, R.id.imageButton14, R.id.imageButton9, R.id.imageButton10, R.id.imageButton11,
                      R.id.imageButton12,R.id.imageButton13,R.id.imageButton14);

      private List<ImageButton>list=new ArrayList<>();

      private ColorDrawable colorDrawable=new ColorDrawable();
    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        for (int id=0;id < ids.size();id++){
            final ImageButton imageButton=findViewById(id);
            list.add(imageButton);

        }

    }

    private ImageButton img =findViewById(R.id.imageButton1);
    public void OnButtonClick(View view){
        Log.i(MainActivity.class.getSimpleName(),"Ejecutando onButtonClick");


        img.postDelayed(new Runnable() {
           @Override
            public void run() {
             img.getDrawable();
           }
        },2000);



    }
}
