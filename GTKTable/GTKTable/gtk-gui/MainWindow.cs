
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;

	private global::Gtk.VBox vBox;

	private global::Gtk.HBox hbox2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.HBox hbox4;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vBox = new global::Gtk.VBox();
		this.vBox.Name = "vBox";
		this.vBox.Spacing = 6;
		// Container child vBox.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		this.vBox.Add(this.hbox2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vBox[this.hbox2]));
		w1.Position = 0;
		// Container child vBox.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		this.vBox.Add(this.hbox3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vBox[this.hbox3]));
		w2.Position = 1;
		// Container child vBox.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		this.vBox.Add(this.hbox4);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vBox[this.hbox4]));
		w3.Position = 2;
		this.hbox1.Add(this.vBox);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vBox]));
		w4.Position = 0;
		this.Add(this.hbox1);
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