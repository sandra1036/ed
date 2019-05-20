using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private bool isnew=false;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        treeView.AppendColumn("Nombre",new CellRendererText(),"text",0);
        treeView.AppendColumn("Teléfono", new CellRendererText(), "text",1);
        ListStore listStore= new ListStore(typeof(String),typeof(String));
        treeView.Model = listStore;
        listStore.AppendValues("Rosa", "46544687");
        listStore.AppendValues("Edudardo", "85989965");
        listStore.AppendValues("Sonia", "8598996558");

        editAction.Sensitive = false;

        newAction.Activated += (sender, e) => {


            vBoxContacto.Visible = true;
            treeView.Sensitive = false;

        };
        treeView.Selection.Changed += (sender, e) =>
            editAction.Sensitive=treeView.Selection.CountSelectedRows()>0; 

      
        editAction.Activated += (sender, e) => {

            vBoxContacto.Visible = true;
            treeView.Sensitive = false;

            treeView.Selection.GetSelected(out TreeIter treeIter);

            String nombre=(String)treeView.Model.GetValue(treeIter, 0);
            String telefono=(String)treeView.Model.GetValue(treeIter, 1);
            entry1.Text = nombre;
            entry2.Text = telefono;

        };
        button1.Clicked += (sender, e) =>
        {
            if (isnew)
            {
                listStore.AppendValues(entry1.Text, entry2.Text);
            }
            else{
                treeView.Selection.GetSelected(out TreeIter treeIter);
                listStore.SetValue(treeIter, 0, entry1.Text);
                listStore.SetValue(treeIter, 1, entry2.Text);
            }
            vBoxContacto.Visible = false;
            treeView.Sensitive = true;

        };

        button2.Clicked +=(sender, e) => {

        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
