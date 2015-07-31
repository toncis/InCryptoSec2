
// This file has been generated by the GUI designer. Do not modify.

public partial class WidCryptoDatabase
{
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.HBox hbox10;
	
	private global::Gtk.Image imgDatabase;
	
	private global::Gtk.Label lblDatabase;
	
	private global::Gtk.Button btnDatabaseConfig;
	
	private global::Gtk.Frame fraDatabaseLogin;
	
	private global::Gtk.Alignment GtkAlignment10;
	
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
	
	private global::Gtk.Label lblDatabaseLogin;
	
	private global::Gtk.Frame fraConnectionString;
	
	private global::Gtk.Alignment GtkAlignment9;
	
	private global::Gtk.TextView txtConnectionString;
	
	private global::Gtk.Label lblConnectionString;
	
	private global::Gtk.HBox hbox8;
	
	private global::Gtk.Button btnLogin;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.HBox hbox11;
	
	private global::Gtk.Image imgEncryption;
	
	private global::Gtk.Label lblEncription;
	
	private global::Gtk.Button btnCryptoConfig;
	
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
		this.hbox5.BorderWidth = ((uint)(3));
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		this.hbox6.BorderWidth = ((uint)(3));
		// Container child hbox6.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 10;
		// Container child hbox10.Gtk.Box+BoxChild
		this.imgDatabase = new global::Gtk.Image ();
		this.imgDatabase.Name = "imgDatabase";
		this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.database1_32x32.png");
		this.hbox10.Add (this.imgDatabase);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.imgDatabase]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.lblDatabase = new global::Gtk.Label ();
		this.lblDatabase.Name = "lblDatabase";
		this.lblDatabase.LabelProp = global::Mono.Unix.Catalog.GetString ("Database");
		this.lblDatabase.UseMarkup = true;
		this.lblDatabase.UseUnderline = true;
		this.hbox10.Add (this.lblDatabase);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.lblDatabase]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.hbox6.Add (this.hbox10);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.hbox10]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.btnDatabaseConfig = new global::Gtk.Button ();
		this.btnDatabaseConfig.TooltipMarkup = "Change database.";
		this.btnDatabaseConfig.WidthRequest = 150;
		this.btnDatabaseConfig.Name = "btnDatabaseConfig";
		this.btnDatabaseConfig.UseUnderline = true;
		this.btnDatabaseConfig.Label = global::Mono.Unix.Catalog.GetString ("DATABASE");
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.database1_32x32.png");
		this.btnDatabaseConfig.Image = w4;
		this.hbox6.Add (this.btnDatabaseConfig);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.btnDatabaseConfig]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox2.Add (this.hbox6);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox6]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fraDatabaseLogin = new global::Gtk.Frame ();
		this.fraDatabaseLogin.Name = "fraDatabaseLogin";
		this.fraDatabaseLogin.ShadowType = ((global::Gtk.ShadowType)(1));
		this.fraDatabaseLogin.BorderWidth = ((uint)(3));
		// Container child fraDatabaseLogin.Gtk.Container+ContainerChild
		this.GtkAlignment10 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment10.Name = "GtkAlignment10";
		this.GtkAlignment10.LeftPadding = ((uint)(4));
		this.GtkAlignment10.TopPadding = ((uint)(4));
		this.GtkAlignment10.RightPadding = ((uint)(4));
		this.GtkAlignment10.BottomPadding = ((uint)(4));
		// Container child GtkAlignment10.Gtk.Container+ContainerChild
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
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.imgDatabaseServer]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.imgDatabaseUser = new global::Gtk.Image ();
		this.imgDatabaseUser.Name = "imgDatabaseUser";
		this.imgDatabaseUser.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.user_16x16.png");
		this.tableDatabaseLogin.Add (this.imgDatabaseUser);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.imgDatabaseUser]));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.imgUserPasswd = new global::Gtk.Image ();
		this.imgUserPasswd.Name = "imgUserPasswd";
		this.imgUserPasswd.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.passwd_16x16.png");
		this.tableDatabaseLogin.Add (this.imgUserPasswd);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.imgUserPasswd]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.lblDatabaseServer = new global::Gtk.Label ();
		this.lblDatabaseServer.Name = "lblDatabaseServer";
		this.lblDatabaseServer.LabelProp = global::Mono.Unix.Catalog.GetString ("Server :");
		this.lblDatabaseServer.SingleLineMode = true;
		this.tableDatabaseLogin.Add (this.lblDatabaseServer);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.lblDatabaseServer]));
		w10.TopAttach = ((uint)(2));
		w10.BottomAttach = ((uint)(3));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.lblUserName = new global::Gtk.Label ();
		this.lblUserName.Name = "lblUserName";
		this.lblUserName.LabelProp = global::Mono.Unix.Catalog.GetString ("User Name :");
		this.lblUserName.SingleLineMode = true;
		this.tableDatabaseLogin.Add (this.lblUserName);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.lblUserName]));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.lblUserPasswd = new global::Gtk.Label ();
		this.lblUserPasswd.Name = "lblUserPasswd";
		this.lblUserPasswd.LabelProp = global::Mono.Unix.Catalog.GetString ("Password :");
		this.tableDatabaseLogin.Add (this.lblUserPasswd);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.lblUserPasswd]));
		w12.TopAttach = ((uint)(1));
		w12.BottomAttach = ((uint)(2));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.txtDatabaseServer = new global::Gtk.Entry ();
		this.txtDatabaseServer.TooltipMarkup = "Database server name.";
		this.txtDatabaseServer.CanFocus = true;
		this.txtDatabaseServer.Name = "txtDatabaseServer";
		this.txtDatabaseServer.IsEditable = true;
		this.txtDatabaseServer.InvisibleChar = '●';
		this.tableDatabaseLogin.Add (this.txtDatabaseServer);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.txtDatabaseServer]));
		w13.TopAttach = ((uint)(2));
		w13.BottomAttach = ((uint)(3));
		w13.LeftAttach = ((uint)(2));
		w13.RightAttach = ((uint)(3));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.txtUserName = new global::Gtk.Entry ();
		this.txtUserName.TooltipMarkup = "Database user name.";
		this.txtUserName.CanFocus = true;
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.IsEditable = true;
		this.txtUserName.InvisibleChar = '●';
		this.tableDatabaseLogin.Add (this.txtUserName);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.txtUserName]));
		w14.LeftAttach = ((uint)(2));
		w14.RightAttach = ((uint)(3));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableDatabaseLogin.Gtk.Table+TableChild
		this.txtUserPasswd = new global::Gtk.Entry ();
		this.txtUserPasswd.TooltipMarkup = "Database user password.";
		this.txtUserPasswd.CanFocus = true;
		this.txtUserPasswd.Name = "txtUserPasswd";
		this.txtUserPasswd.IsEditable = true;
		this.txtUserPasswd.Visibility = false;
		this.txtUserPasswd.InvisibleChar = '●';
		this.tableDatabaseLogin.Add (this.txtUserPasswd);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tableDatabaseLogin [this.txtUserPasswd]));
		w15.TopAttach = ((uint)(1));
		w15.BottomAttach = ((uint)(2));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment10.Add (this.tableDatabaseLogin);
		this.fraDatabaseLogin.Add (this.GtkAlignment10);
		this.lblDatabaseLogin = new global::Gtk.Label ();
		this.lblDatabaseLogin.Name = "lblDatabaseLogin";
		this.lblDatabaseLogin.LabelProp = global::Mono.Unix.Catalog.GetString ("Database Login");
		this.lblDatabaseLogin.UseMarkup = true;
		this.fraDatabaseLogin.LabelWidget = this.lblDatabaseLogin;
		this.vbox2.Add (this.fraDatabaseLogin);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fraDatabaseLogin]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fraConnectionString = new global::Gtk.Frame ();
		this.fraConnectionString.Name = "fraConnectionString";
		this.fraConnectionString.ShadowType = ((global::Gtk.ShadowType)(1));
		this.fraConnectionString.BorderWidth = ((uint)(3));
		// Container child fraConnectionString.Gtk.Container+ContainerChild
		this.GtkAlignment9 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment9.Name = "GtkAlignment9";
		this.GtkAlignment9.LeftPadding = ((uint)(4));
		this.GtkAlignment9.TopPadding = ((uint)(4));
		this.GtkAlignment9.RightPadding = ((uint)(4));
		this.GtkAlignment9.BottomPadding = ((uint)(4));
		// Container child GtkAlignment9.Gtk.Container+ContainerChild
		this.txtConnectionString = new global::Gtk.TextView ();
		this.txtConnectionString.Name = "txtConnectionString";
		this.txtConnectionString.WrapMode = ((global::Gtk.WrapMode)(1));
		this.GtkAlignment9.Add (this.txtConnectionString);
		this.fraConnectionString.Add (this.GtkAlignment9);
		this.lblConnectionString = new global::Gtk.Label ();
		this.lblConnectionString.Name = "lblConnectionString";
		this.lblConnectionString.LabelProp = global::Mono.Unix.Catalog.GetString ("Connection String");
		this.lblConnectionString.UseMarkup = true;
		this.fraConnectionString.LabelWidget = this.lblConnectionString;
		this.vbox2.Add (this.fraConnectionString);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fraConnectionString]));
		w21.Position = 2;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.btnLogin = new global::Gtk.Button ();
		this.btnLogin.TooltipMarkup = "Login to the database.";
		this.btnLogin.WidthRequest = 150;
		this.btnLogin.CanDefault = true;
		this.btnLogin.CanFocus = true;
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Label = "LOGIN";
		global::Gtk.Image w22 = new global::Gtk.Image ();
		w22.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.mSecure_32x32.png");
		this.btnLogin.Image = w22;
		this.hbox8.Add (this.btnLogin);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.btnLogin]));
		w23.PackType = ((global::Gtk.PackType)(1));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		this.vbox2.Add (this.hbox8);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox8]));
		w24.PackType = ((global::Gtk.PackType)(1));
		w24.Position = 3;
		w24.Expand = false;
		w24.Fill = false;
		this.hbox5.Add (this.vbox2);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox2]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		this.hbox7.BorderWidth = ((uint)(3));
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 10;
		// Container child hbox11.Gtk.Box+BoxChild
		this.imgEncryption = new global::Gtk.Image ();
		this.imgEncryption.Name = "imgEncryption";
		this.imgEncryption.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.lock_32x32.png");
		this.hbox11.Add (this.imgEncryption);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.imgEncryption]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.lblEncription = new global::Gtk.Label ();
		this.lblEncription.Name = "lblEncription";
		this.lblEncription.LabelProp = global::Mono.Unix.Catalog.GetString ("Encryption : RSA");
		this.lblEncription.UseMarkup = true;
		this.lblEncription.UseUnderline = true;
		this.hbox11.Add (this.lblEncription);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.lblEncription]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.hbox7.Add (this.hbox11);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.hbox11]));
		w28.Position = 0;
		w28.Expand = false;
		w28.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.btnCryptoConfig = new global::Gtk.Button ();
		this.btnCryptoConfig.TooltipMarkup = "Change cryptography.";
		this.btnCryptoConfig.WidthRequest = 150;
		this.btnCryptoConfig.Name = "btnCryptoConfig";
		this.btnCryptoConfig.UseUnderline = true;
		this.btnCryptoConfig.Label = global::Mono.Unix.Catalog.GetString ("ENCRYPTION");
		global::Gtk.Image w29 = new global::Gtk.Image ();
		w29.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.lock_preferences_32x32.png");
		this.btnCryptoConfig.Image = w29;
		this.hbox7.Add (this.btnCryptoConfig);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.btnCryptoConfig]));
		w30.PackType = ((global::Gtk.PackType)(1));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		this.vbox3.Add (this.hbox7);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox7]));
		w31.Position = 0;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.databaseconnectionsecwidget1 = new global::DatabaseConnectionSecWidget ();
		this.databaseconnectionsecwidget1.Events = ((global::Gdk.EventMask)(256));
		this.databaseconnectionsecwidget1.Name = "databaseconnectionsecwidget1";
		this.vbox3.Add (this.databaseconnectionsecwidget1);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.databaseconnectionsecwidget1]));
		w32.Position = 1;
		this.hbox5.Add (this.vbox3);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox3]));
		w33.Position = 1;
		this.Add (this.hbox5);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Hide ();
		this.btnDatabaseConfig.Clicked += new global::System.EventHandler (this.btnDatabaseConfig_OnClick);
		this.btnLogin.Clicked += new global::System.EventHandler (this.btnLogin_OnClick);
		this.btnCryptoConfig.Clicked += new global::System.EventHandler (this.btnCryptoConfig_OnClick);
	}
}
