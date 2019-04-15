package sample;

import javafx.beans.property.SimpleStringProperty;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;

import javax.swing.text.TabableView;


public class Controller {

    @FXML private TableView <Persona> tableView;
    @FXML private Label label;

    @FXML ObservableList<Persona> personas= FXCollections.observableArrayList(
            new Persona("pepe","666666666"),
            new Persona("sofia","684684684"),
            new Persona("ursula","685646866")
    );

    public void initialize(){

        System.out.println("initialize ejecutado");
        label.setText("cambiado en initialize");
        //tableView.getItems().add(new Persona("pepe","666666666"));
        tableView.setItems(personas);
        
    }

    @FXML private void onButtonAction(ActionEvent actionEvent){
          personas.add(new Persona("nuevo","644685892"));
    }



    public static class Persona{

        private static SimpleStringProperty nombre;
        private static SimpleStringProperty tele;

        public Persona(String fnombre,String ftele){

            this.nombre=new SimpleStringProperty(fnombre);
            this.tele=new SimpleStringProperty(ftele);

        }

        public static String getNombre() {
            return nombre.get();
        }


        public static String getTele() {
            return tele.get();
        }

        public static void setNombre(String fnombre) {
            nombre.set(fnombre);
        }

        public static void setTele(String ftele) {
            tele.set(ftele);
        }
    }


    @FXML private TableColumn tableColumnNom;

    @FXML private TableColumn tableColumnTele;


}
