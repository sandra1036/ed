
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Button button;

	private global::Gtk.VBox vboxResert;

	private global::Gtk.Label label2;

	private global::Gtk.HButtonBox hbuttonbox2;

	private global::Gtk.Button button11;

	private global::Gtk.Button button12;

	private global::Gtk.Button button13;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.button = new global::Gtk.Button();
		this.button.CanFocus = true;
		this.button.Name = "button";
		this.button.UseUnderline = true;
		this.button.Label = global::Mono.Unix.Catalog.GetString("Pregunta ");
		this.vbox1.Add(this.button);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.button]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vboxResert = new global::Gtk.VBox();
		this.vboxResert.Name = "vboxResert";
		this.vboxResert.Spacing = 6;
		// Container child vboxResert.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Se ha cantado Bingo");
		this.vboxResert.Add(this.label2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxResert[this.label2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vboxResert.Gtk.Box+BoxChild
		this.hbuttonbox2 = new global::Gtk.HButtonBox();
		this.hbuttonbox2.Name = "hbuttonbox2";
		this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button11 = new global::Gtk.Button();
		this.button11.CanFocus = true;
		this.button11.Name = "button11";
		this.button11.UseUnderline = true;
		this.button11.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.hbuttonbox2.Add(this.button11);
		global::Gtk.ButtonBox.ButtonBoxChild w3 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.button11]));
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button12 = new global::Gtk.Button();
		this.button12.CanFocus = true;
		this.button12.Name = "button12";
		this.button12.UseUnderline = true;
		this.button12.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.hbuttonbox2.Add(this.button12);
		global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.button12]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.button13 = new global::Gtk.Button();
		this.button13.CanFocus = true;
		this.button13.Name = "button13";
		this.button13.UseUnderline = true;
		this.button13.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.hbuttonbox2.Add(this.button13);
		global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.button13]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.vboxResert.Add(this.hbuttonbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxResert[this.hbuttonbox2]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		this.vbox1.Add(this.vboxResert);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxResert]));
		w7.Position = 2;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
