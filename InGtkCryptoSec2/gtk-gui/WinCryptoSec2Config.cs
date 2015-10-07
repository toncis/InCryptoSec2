
// This file has been generated by the GUI designer. Do not modify.

public partial class WinCryptoSec2Config
{
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Button btnDatabase;
	
	private global::Gtk.Button btnFtp;
	
	private global::Gtk.Button btnString;
	
	private global::Gtk.Button btnXml;
	
	private global::Gtk.Button btnCancel;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget WinCryptoSec2Config
		this.Name = "WinCryptoSec2Config";
		this.Title = global::Mono.Unix.Catalog.GetString ("InCrtyptoSec2 Modes");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.keys_16x16.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Modal = true;
		// Internal child WinCryptoSec2Config.VBox
		global::Gtk.VBox w1 = this.VBox;
		w1.Name = "dialog1_VBox";
		w1.BorderWidth = ((uint)(2));
		// Container child dialog1_VBox.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 10;
		this.vbox2.BorderWidth = ((uint)(5));
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnDatabase = new global::Gtk.Button ();
		this.btnDatabase.TooltipMarkup = "InCryptoSec2 module for Database security.";
		this.btnDatabase.CanFocus = true;
		this.btnDatabase.Name = "btnDatabase";
		this.btnDatabase.UseUnderline = true;
		this.btnDatabase.Label = global::Mono.Unix.Catalog.GetString ("Database");
		global::Gtk.Image w2 = new global::Gtk.Image ();
		w2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.database1_32x32.png");
		this.btnDatabase.Image = w2;
		this.vbox2.Add (this.btnDatabase);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnDatabase]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnFtp = new global::Gtk.Button ();
		this.btnFtp.TooltipMarkup = "InCryptoSec2 module for FTP security.";
		this.btnFtp.CanFocus = true;
		this.btnFtp.Name = "btnFtp";
		this.btnFtp.UseUnderline = true;
		this.btnFtp.Label = global::Mono.Unix.Catalog.GetString ("FTP");
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.server_client_32x32.png");
		this.btnFtp.Image = w4;
		this.vbox2.Add (this.btnFtp);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnFtp]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnString = new global::Gtk.Button ();
		this.btnString.TooltipMarkup = "InCryptoSec2 module for String security.";
		this.btnString.CanFocus = true;
		this.btnString.Name = "btnString";
		this.btnString.UseUnderline = true;
		this.btnString.Label = global::Mono.Unix.Catalog.GetString ("String");
		global::Gtk.Image w6 = new global::Gtk.Image ();
		w6.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.text_32x32.png");
		this.btnString.Image = w6;
		this.vbox2.Add (this.btnString);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnString]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnXml = new global::Gtk.Button ();
		this.btnXml.TooltipMarkup = "InCryptoSec2 module for XML security.";
		this.btnXml.CanFocus = true;
		this.btnXml.Name = "btnXml";
		this.btnXml.UseUnderline = true;
		this.btnXml.Label = global::Mono.Unix.Catalog.GetString ("XML");
		global::Gtk.Image w8 = new global::Gtk.Image ();
		w8.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.text_tree_32x32.png");
		this.btnXml.Image = w8;
		this.vbox2.Add (this.btnXml);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnXml]));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		w1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Internal child WinCryptoSec2Config.ActionArea
		global::Gtk.HButtonBox w11 = this.ActionArea;
		w11.Name = "dialog1_Action";
		w11.Spacing = 10;
		w11.BorderWidth = ((uint)(5));
		w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child dialog1_Action.Gtk.ButtonBox+ButtonBoxChild
		this.btnCancel = new global::Gtk.Button ();
		this.btnCancel.CanDefault = true;
		this.btnCancel.CanFocus = true;
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.UseStock = true;
		this.btnCancel.UseUnderline = true;
		this.btnCancel.Label = "gtk-cancel";
		this.AddActionWidget (this.btnCancel, -6);
		global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.btnCancel]));
		w12.Expand = false;
		w12.Fill = false;
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 246;
		this.DefaultHeight = 276;
		this.Show ();
		this.btnDatabase.Clicked += new global::System.EventHandler (this.btnDatabase_OnClick);
		this.btnFtp.Clicked += new global::System.EventHandler (this.btnFtp_OnClick);
		this.btnString.Clicked += new global::System.EventHandler (this.btnString_OnClick);
		this.btnXml.Clicked += new global::System.EventHandler (this.btnXml_OnClick);
	}
}