
// This file has been generated by the GUI designer. Do not modify.

public partial class DatabaseLoginWidget
{
	private global::Gtk.Frame fraDatabaseLogin;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.Table tableDatabaseLogin;
	
	private global::Gtk.Image imgDatabaseServer;
	
	private global::Gtk.Image imgDatabaseUser;
	
	private global::Gtk.Image imgUserPasswd;
	
	private global::Gtk.Label lblDatabaseServer;
	
	private global::Gtk.Label lblUserName;
	
	private global::Gtk.Label lblUserPasswd;
	
	private global::Gtk.Entry txtDatabaseServer;
	
	private global::Gtk.Entry txtUserName;
	
	private global::Gtk.Entry txtUserPasswd;
	
	private global::Gtk.Label GtkLabel1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget DatabaseLoginWidget
		global::Stetic.BinContainer.Attach (this);
		this.Name = "DatabaseLoginWidget";
		// Container child DatabaseLoginWidget.Gtk.Container+ContainerChild
		this.fraDatabaseLogin = new global::Gtk.Frame ();
		this.fraDatabaseLogin.Name = "fraDatabaseLogin";
		this.fraDatabaseLogin.ShadowType = ((global::Gtk.ShadowType)(1));
		this.fraDatabaseLogin.BorderWidth = ((uint)(3));
		// Container child fraDatabaseLogin.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(4));
		this.GtkAlignment.TopPadding = ((uint)(4));
		this.GtkAlignment.RightPadding = ((uint)(4));
		this.GtkAlignment.BottomPadding = ((uint)(4));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.tableDatabaseLogin = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
		this.tableDatabaseLogin.Name = "tableDatabaseLogin";
		this.tableDatabaseLogin.RowSpacing = ((uint)(5));
		this.tableDatabaseLogin.ColumnSpacing = ((uint)(10));
		this.tableDatabaseLogin.BorderWidth = ((uint)(5));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.imgDatabaseServer = new global::Gtk.Image ();
		this.imgDatabaseServer.Name = "imgDatabaseServer";
		this.imgDatabaseServer.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.Database_16x16.png");
		this.tableDatabaseLogin.Add (this.imgDatabaseServer);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.imgDatabaseServer]));
		w1.TopAttach = ((uint)(2));
		w1.BottomAttach = ((uint)(3));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.imgDatabaseUser = new global::Gtk.Image ();
		this.imgDatabaseUser.Name = "imgDatabaseUser";
		this.imgDatabaseUser.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.user_16x16.png");
		this.tableDatabaseLogin.Add (this.imgDatabaseUser);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.imgDatabaseUser]));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.imgUserPasswd = new global::Gtk.Image ();
		this.imgUserPasswd.Name = "imgUserPasswd";
		this.imgUserPasswd.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.passwd_16x16.png");
		this.tableDatabaseLogin.Add (this.imgUserPasswd);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.imgUserPasswd]));
		w3.TopAttach = ((uint)(1));
		w3.BottomAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.lblDatabaseServer = new global::Gtk.Label ();
		this.lblDatabaseServer.Name = "lblDatabaseServer";
		this.lblDatabaseServer.LabelProp = global::Mono.Unix.Catalog.GetString ("Server :");
		this.lblDatabaseServer.SingleLineMode = true;
		this.tableDatabaseLogin.Add (this.lblDatabaseServer);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.lblDatabaseServer]));
		w4.TopAttach = ((uint)(2));
		w4.BottomAttach = ((uint)(3));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.lblUserName = new global::Gtk.Label ();
		this.lblUserName.Name = "lblUserName";
		this.lblUserName.LabelProp = global::Mono.Unix.Catalog.GetString ("User Name :");
		this.lblUserName.SingleLineMode = true;
		this.tableDatabaseLogin.Add (this.lblUserName);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.lblUserName]));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.lblUserPasswd = new global::Gtk.Label ();
		this.lblUserPasswd.Name = "lblUserPasswd";
		this.lblUserPasswd.LabelProp = global::Mono.Unix.Catalog.GetString ("Password :");
		this.tableDatabaseLogin.Add (this.lblUserPasswd);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.lblUserPasswd]));
		w6.TopAttach = ((uint)(1));
		w6.BottomAttach = ((uint)(2));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.txtDatabaseServer = new global::Gtk.Entry ();
		this.txtDatabaseServer.TooltipMarkup = "Database server name.";
		this.txtDatabaseServer.CanFocus = true;
		this.txtDatabaseServer.Name = "txtDatabaseServer";
		this.txtDatabaseServer.IsEditable = true;
		this.txtDatabaseServer.InvisibleChar = '●';
		this.tableDatabaseLogin.Add (this.txtDatabaseServer);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.txtDatabaseServer]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(2));
		w7.RightAttach = ((uint)(3));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.txtUserName = new global::Gtk.Entry ();
		this.txtUserName.TooltipMarkup = "Database user name.";
		this.txtUserName.CanFocus = true;
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.IsEditable = true;
		this.txtUserName.InvisibleChar = '●';
		this.tableDatabaseLogin.Add (this.txtUserName);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.txtUserName]));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.txtUserPasswd = new global::Gtk.Entry ();
		this.txtUserPasswd.TooltipMarkup = "Database user password.";
		this.txtUserPasswd.CanFocus = true;
		this.txtUserPasswd.Name = "txtUserPasswd";
		this.txtUserPasswd.IsEditable = true;
		this.txtUserPasswd.Visibility = false;
		this.txtUserPasswd.InvisibleChar = '●';
		this.tableDatabaseLogin.Add (this.txtUserPasswd);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.txtUserPasswd]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.LeftAttach = ((uint)(2));
		w9.RightAttach = ((uint)(3));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment.Add (this.tableDatabaseLogin);
		this.fraDatabaseLogin.Add (this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label ();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Database LogIn</b>");
		this.GtkLabel1.UseMarkup = true;
		this.fraDatabaseLogin.LabelWidget = this.GtkLabel1;
		this.Add (this.fraDatabaseLogin);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Hide ();
	}
}
