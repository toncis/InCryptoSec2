
// This file has been generated by the GUI designer. Do not modify.

public partial class WinDatabaseConfig
{
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Button btnOracle;
	
	private global::Gtk.Button btnSQLServer;
	
	private global::Gtk.Button btnMySQL;
	
	private global::Gtk.Button btnSQLite;
	
	private global::Gtk.Button btnClose;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget WinDatabaseConfig
		this.Name = "WinDatabaseConfig";
		this.Title = global::Mono.Unix.Catalog.GetString ("Set Database");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.database1_16x16.png");
		this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Modal = true;
		this.AllowShrink = true;
		// Internal child WinDatabaseConfig.VBox
		global::Gtk.VBox w1 = this.VBox;
		w1.Name = "dialog1_VBox";
		w1.BorderWidth = ((uint)(2));
		// Container child dialog1_VBox.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 10;
		this.vbox2.BorderWidth = ((uint)(5));
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnOracle = new global::Gtk.Button ();
		this.btnOracle.CanFocus = true;
		this.btnOracle.Name = "btnOracle";
		this.btnOracle.UseUnderline = true;
		this.btnOracle.Label = global::Mono.Unix.Catalog.GetString ("Oracle");
		global::Gtk.Image w2 = new global::Gtk.Image ();
		w2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.oracle_32x32.png");
		this.btnOracle.Image = w2;
		this.vbox2.Add (this.btnOracle);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnOracle]));
		w3.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnSQLServer = new global::Gtk.Button ();
		this.btnSQLServer.CanFocus = true;
		this.btnSQLServer.Name = "btnSQLServer";
		this.btnSQLServer.UseUnderline = true;
		this.btnSQLServer.Label = global::Mono.Unix.Catalog.GetString ("SQLServer");
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.sqlserver5.gif");
		this.btnSQLServer.Image = w4;
		this.vbox2.Add (this.btnSQLServer);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnSQLServer]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnMySQL = new global::Gtk.Button ();
		this.btnMySQL.CanFocus = true;
		this.btnMySQL.Name = "btnMySQL";
		this.btnMySQL.UseUnderline = true;
		this.btnMySQL.Label = global::Mono.Unix.Catalog.GetString ("MySQL");
		global::Gtk.Image w6 = new global::Gtk.Image ();
		w6.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.MySQL_32x32.png");
		this.btnMySQL.Image = w6;
		this.vbox2.Add (this.btnMySQL);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnMySQL]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnSQLite = new global::Gtk.Button ();
		this.btnSQLite.CanFocus = true;
		this.btnSQLite.Name = "btnSQLite";
		this.btnSQLite.UseUnderline = true;
		this.btnSQLite.Label = global::Mono.Unix.Catalog.GetString ("SQLite");
		global::Gtk.Image w8 = new global::Gtk.Image ();
		w8.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.SQLite2_32x32.png");
		this.btnSQLite.Image = w8;
		this.vbox2.Add (this.btnSQLite);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnSQLite]));
		w9.PackType = ((global::Gtk.PackType)(1));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		w1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Internal child WinDatabaseConfig.ActionArea
		global::Gtk.HButtonBox w11 = this.ActionArea;
		w11.Name = "__gtksharp_91_Stetic_TopLevelDialog_ActionArea";
		w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child __gtksharp_91_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
		this.btnClose = new global::Gtk.Button ();
		this.btnClose.CanFocus = true;
		this.btnClose.Name = "btnClose";
		this.btnClose.UseUnderline = true;
		this.btnClose.Label = global::Mono.Unix.Catalog.GetString ("_Cancel");
		global::Gtk.Image w12 = new global::Gtk.Image ();
		w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
		this.btnClose.Image = w12;
		this.AddActionWidget (this.btnClose, -5);
		global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.btnClose]));
		w13.Expand = false;
		w13.Fill = false;
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 267;
		this.DefaultHeight = 250;
		this.Show ();
		this.btnOracle.Clicked += new global::System.EventHandler (this.btnOracle_OnClick);
		this.btnSQLServer.Clicked += new global::System.EventHandler (this.btnSQLServer_OnClick);
		this.btnMySQL.Clicked += new global::System.EventHandler (this.btnMySQL_OnClick);
		this.btnSQLite.Clicked += new global::System.EventHandler (this.btnSQLite_OnClick);
		this.btnClose.Clicked += new global::System.EventHandler (this.btnClose_OnClick);
	}
}
