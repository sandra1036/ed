using System;
using Gtk;
using CBingo;
public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Panel panel = new Panel(vBox);
        Bombo bombo = new Bombo();
        buttonAdelante.Clicked +=delegate {
            int num = bombo.sacarBola();
            panel.Marcar(num);
            Console.WriteLine("ButtonAdelante pulsado");
        };
   
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
