
// This file has been generated by the GUI designer. Do not modify.

public partial class WinCryptoSec2
{
	private global::Gtk.VBox vbox1;
	
	private global::CryptoSec2TitleWidget cryptosec2titlewidget1;
	
	private global::WidCryptoDatabase widcryptodatabase1;
	
	private global::CryptoSec2FooterWidget cryptosec2footerwidget1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget WinCryptoSec2
		this.Name = "WinCryptoSec2";
		this.Title = global::Mono.Unix.Catalog.GetString ("WinCryptoSec2");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.keys.ico");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child WinCryptoSec2.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.cryptosec2titlewidget1 = new global::CryptoSec2TitleWidget ();
		this.cryptosec2titlewidget1.Events = ((global::Gdk.EventMask)(256));
		this.cryptosec2titlewidget1.Name = "cryptosec2titlewidget1";
		this.vbox1.Add (this.cryptosec2titlewidget1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.cryptosec2titlewidget1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.widcryptodatabase1 = new global::WidCryptoDatabase ();
		this.widcryptodatabase1.Events = ((global::Gdk.EventMask)(256));
		this.widcryptodatabase1.Name = "widcryptodatabase1";
		this.vbox1.Add (this.widcryptodatabase1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.widcryptodatabase1]));
		w2.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.cryptosec2footerwidget1 = new global::CryptoSec2FooterWidget ();
		this.cryptosec2footerwidget1.Events = ((global::Gdk.EventMask)(256));
		this.cryptosec2footerwidget1.Name = "cryptosec2footerwidget1";
		this.vbox1.Add (this.cryptosec2footerwidget1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.cryptosec2footerwidget1]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1000;
		this.DefaultHeight = 537;
		this.Show ();
	}
}