
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::DatabaseLoginWidget databaseloginwidget1;
	
	private global::DatabaseConnectionSecWidget databaseconnectionsecwidget1;
	
	private global::CryptoConfigWidget cryptoconfigwidget1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.databaseloginwidget1 = new global::DatabaseLoginWidget ();
		this.databaseloginwidget1.Events = ((global::Gdk.EventMask)(256));
		this.databaseloginwidget1.Name = "databaseloginwidget1";
		this.vbox1.Add (this.databaseloginwidget1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.databaseloginwidget1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.databaseconnectionsecwidget1 = new global::DatabaseConnectionSecWidget ();
		this.databaseconnectionsecwidget1.Events = ((global::Gdk.EventMask)(256));
		this.databaseconnectionsecwidget1.Name = "databaseconnectionsecwidget1";
		this.vbox1.Add (this.databaseconnectionsecwidget1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.databaseconnectionsecwidget1]));
		w2.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.cryptoconfigwidget1 = new global::CryptoConfigWidget ();
		this.cryptoconfigwidget1.Events = ((global::Gdk.EventMask)(256));
		this.cryptoconfigwidget1.Name = "cryptoconfigwidget1";
		this.vbox1.Add (this.cryptoconfigwidget1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.cryptoconfigwidget1]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 523;
		this.DefaultHeight = 458;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
