
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox9;

	private global::Gtk.HBox hbox12;

	private global::Gtk.Entry numeros1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.HBox hbox5;

	private global::Gtk.HBox hbox10;

	private global::Gtk.HBox hbox11;

	private global::Gtk.Entry numeros2;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label4;

	private global::Gtk.Label operacion;

	private global::Gtk.HBox hbox4;

	private global::Gtk.HBox hbox13;

	private global::Gtk.Button suma;

	private global::Gtk.Button resta;

	private global::Gtk.Button multiplicacion;

	private global::Gtk.HBox hbox14;

	private global::Gtk.Button division;

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
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.hbox12 = new global::Gtk.HBox();
		this.hbox12.Name = "hbox12";
		this.hbox12.Spacing = 6;
		this.hbox9.Add(this.hbox12);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.hbox12]));
		w1.Position = 0;
		// Container child hbox9.Gtk.Box+BoxChild
		this.numeros1 = new global::Gtk.Entry();
		this.numeros1.CanFocus = true;
		this.numeros1.Name = "numeros1";
		this.numeros1.IsEditable = true;
		this.numeros1.InvisibleChar = '•';
		this.hbox9.Add(this.numeros1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.numeros1]));
		w2.PackType = ((global::Gtk.PackType)(1));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox1.Add(this.hbox9);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox9]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.numeros2 = new global::Gtk.Entry();
		this.numeros2.CanFocus = true;
		this.numeros2.Name = "numeros2";
		this.numeros2.IsEditable = true;
		this.numeros2.InvisibleChar = '•';
		this.hbox11.Add(this.numeros2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.numeros2]));
		w4.PackType = ((global::Gtk.PackType)(1));
		w4.Position = 2;
		w4.Expand = false;
		this.hbox10.Add(this.hbox11);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.hbox11]));
		w5.Position = 0;
		this.hbox5.Add(this.hbox10);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox10]));
		w6.Position = 0;
		this.hbox1.Add(this.hbox5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox5]));
		w7.Position = 0;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado");
		this.hbox2.Add(this.label4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label4]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.operacion = new global::Gtk.Label();
		this.operacion.Name = "operacion";
		this.operacion.LabelProp = global::Mono.Unix.Catalog.GetString("operacion");
		this.hbox2.Add(this.operacion);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.operacion]));
		w10.PackType = ((global::Gtk.PackType)(1));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 6;
		// Container child hbox13.Gtk.Box+BoxChild
		this.suma = new global::Gtk.Button();
		this.suma.CanFocus = true;
		this.suma.Name = "suma";
		this.suma.UseUnderline = true;
		this.suma.BorderWidth = ((uint)(33));
		this.suma.Label = global::Mono.Unix.Catalog.GetString("+");
		this.hbox13.Add(this.suma);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.suma]));
		w12.Position = 0;
		w12.Fill = false;
		// Container child hbox13.Gtk.Box+BoxChild
		this.resta = new global::Gtk.Button();
		this.resta.CanFocus = true;
		this.resta.Name = "resta";
		this.resta.UseUnderline = true;
		this.resta.BorderWidth = ((uint)(33));
		this.resta.Label = global::Mono.Unix.Catalog.GetString("--");
		this.hbox13.Add(this.resta);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.resta]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox13.Gtk.Box+BoxChild
		this.multiplicacion = new global::Gtk.Button();
		this.multiplicacion.CanFocus = true;
		this.multiplicacion.Name = "multiplicacion";
		this.multiplicacion.UseUnderline = true;
		this.multiplicacion.BorderWidth = ((uint)(33));
		this.multiplicacion.Label = global::Mono.Unix.Catalog.GetString("x");
		this.hbox13.Add(this.multiplicacion);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.multiplicacion]));
		w14.Position = 2;
		w14.Expand = false;
		w14.Fill = false;
		this.hbox4.Add(this.hbox13);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox13]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox14 = new global::Gtk.HBox();
		this.hbox14.Name = "hbox14";
		this.hbox14.Spacing = 6;
		// Container child hbox14.Gtk.Box+BoxChild
		this.division = new global::Gtk.Button();
		this.division.CanFocus = true;
		this.division.Name = "division";
		this.division.UseUnderline = true;
		this.division.BorderWidth = ((uint)(33));
		this.division.Label = global::Mono.Unix.Catalog.GetString("/");
		this.hbox14.Add(this.division);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.division]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		this.hbox4.Add(this.hbox14);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox14]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		this.vbox1.Add(this.hbox4);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w18.Position = 3;
		w18.Expand = false;
		w18.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 540;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.suma.Clicked += new global::System.EventHandler(this.OnButton18Clicked);
	}
}
