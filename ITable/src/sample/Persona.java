package sample;

import javafx.beans.property.SimpleIntegerProperty;
import javafx.beans.property.SimpleStringProperty;

public class Persona {

    private static SimpleStringProperty nombre;
    private static SimpleIntegerProperty tele;

   public Persona(String fnombre,int ftele){

        this.nombre=new SimpleStringProperty(fnombre);
        this.tele=new SimpleIntegerProperty(ftele);

    }

    public static String getNombre() {
        return nombre.get();
    }


    public static int getTele() {
        return tele.get();
    }

    public static void setNombre(String fnombre) {
       nombre.set(fnombre);
    }

    public static void setTele(int ftele) {
        tele.set(ftele);
    }
}
