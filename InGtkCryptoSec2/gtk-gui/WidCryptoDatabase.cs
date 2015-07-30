
// This file has been generated by the GUI designer. Do not modify.

public partial class WidCryptoDatabase
{
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.HBox hbox10;
	
	private global::Gtk.Image image23;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.Button button49;
	
	private global::DatabaseLoginWidget databaseloginwidget1;
	
	private global::Gtk.HBox hbox8;
	
	private global::Gtk.Button btnLogin1;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Button button50;
	
	private global::DatabaseConnectionSecWidget databaseconnectionsecwidget1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget WidCryptoDatabase
		global::Stetic.BinContainer.Attach (this);
		this.Name = "WidCryptoDatabase";
		// Container child WidCryptoDatabase.Gtk.Container+ContainerChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.image23 = new global::Gtk.Image ();
		this.image23.Name = "image23";
		this.image23.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.sql1.png");
		this.hbox10.Add (this.image23);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.image23]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Database</b>");
		this.label5.UseMarkup = true;
		this.label5.UseUnderline = true;
		this.hbox10.Add (this.label5);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.label5]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.hbox6.Add (this.hbox10);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.hbox10]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.button49 = new global::Gtk.Button ();
		this.button49.CanFocus = true;
		this.button49.Name = "button49";
		this.button49.UseUnderline = true;
		this.button49.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.sqlserver2.png");
		this.button49.Image = w4;
		this.hbox6.Add (this.button49);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.button49]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox2.Add (this.hbox6);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox6]));
		w6.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.databaseloginwidget1 = new global::DatabaseLoginWidget ();
		this.databaseloginwidget1.Events = ((global::Gdk.EventMask)(256));
		this.databaseloginwidget1.Name = "databaseloginwidget1";
		this.vbox2.Add (this.databaseloginwidget1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.databaseloginwidget1]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.btnLogin1 = new global::Gtk.Button ();
		this.btnLogin1.WidthRequest = 150;
		this.btnLogin1.CanFocus = true;
		this.btnLogin1.Name = "btnLogin1";
		this.btnLogin1.UseUnderline = true;
		this.btnLogin1.Label = global::Mono.Unix.Catalog.GetString ("LOGIN");
		global::Gtk.Image w8 = new global::Gtk.Image ();
		w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-connect", global::Gtk.IconSize.Menu);
		this.btnLogin1.Image = w8;
		this.hbox8.Add (this.btnLogin1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnLogin1]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox2.Add (this.hbox8);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox8]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.hbox5.Add (this.vbox2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox2]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.button50 = new global::Gtk.Button ();
		this.button50.CanFocus = true;
		this.button50.Name = "button50";
		this.button50.UseUnderline = true;
		this.button50.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.hbox7.Add (this.button50);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.button50]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox3.Add (this.hbox7);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox7]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.databaseconnectionsecwidget1 = new global::DatabaseConnectionSecWidget ();
		this.databaseconnectionsecwidget1.Events = ((global::Gdk.EventMask)(256));
		this.databaseconnectionsecwidget1.Name = "databaseconnectionsecwidget1";
		this.vbox3.Add (this.databaseconnectionsecwidget1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.databaseconnectionsecwidget1]));
		w14.Position = 1;
		this.hbox5.Add (this.vbox3);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox3]));
		w15.Position = 1;
		this.Add (this.hbox5);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Hide ();
	}
}
