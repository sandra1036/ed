using Gtk;
using System;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    private static readonly Gdk.Color Color_GREEN = new Gdk.Color(0, 255, 0);
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        //Button[] buttons = new Button[90];
        int contador = 1;
        List<Button> buttons = new List<Button>();

        for (int row = 0; row < 9; row++)
            for (int colum = 0; colum < 10; colum++) {
                Button button = new Button();
                table.Attach(button, (uint)colum, (uint)colum + 1, (uint)row, (uint)row + 1);
                buttons.Add(button);
                button.Label = " " + contador;
                contador++;
            }

        table.ShowAll();
        

        Random random = new Random();
        buttonAdelante.Clicked +=delegate {
            int numeroAleatorio=random.Next(90) + 1;
            labelNumero.Text = numeroAleatorio.ToString();
            buttons[numeroAleatorio-1].ModifyBg(StateType.Normal, Color_GREEN);
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
