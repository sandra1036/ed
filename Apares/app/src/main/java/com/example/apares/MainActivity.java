package com.example.apares;
//
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.media.Image;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class MainActivity extends AppCompatActivity {


    private List<Integer> ids =
            Arrays.asList(R.id.imageButton1, R.id.imageButton2, R.id.imageButton30, R.id.imageButton4,
                    R.id.imageButton5, R.id.imageButton14, R.id.imageButton9, R.id.imageButton10, R.id.imageButton11,
                    R.id.imageButton12, R.id.imageButton13, R.id.imageButton80);

    private List<ImageButton> list = new ArrayList<>();

    List<Integer> imageIds = new ArrayList<>(Arrays.asList(
            R.drawable.asuna, R.drawable.kakashi, R.drawable.link,
            R.drawable.rin, R.drawable.natsu, R.drawable.sakura));


    private ColorDrawable colorDrawable = new ColorDrawable(Color.LTGRAY);

    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        imageIds.addAll(imageIds);

        Collections.shuffle(imageIds);

        for (int i = 0; i < ids.size(); i++) {
            final ImageButton imageButton = findViewById(ids.get(i));
            list.add(imageButton);
        }
        for(int i = 0; i < ids.size();i++) {
            ImageButton imageButton = findViewById(ids.get(i));
            imageButton.setImageDrawable(colorDrawable);

        }

    }

        public void OnButtonClick(View view) {

            Log.i(MainActivity.class.getSimpleName(), "Ejecutando onButtonClick");
            ImageButton imageButton = (ImageButton) view;
            int index = list.indexOf(imageButton);
            imageButton.setImageResource(imageIds.get(index));



        }

}


