//
//  WidCryptoDatabase.cs
//
//  Author:
//       Tonči Sviličić <tonci.svilicic@in2.hr>
//
//  Copyright (c) 2015 Tonči Sviličić
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using InGtkCryptoSec2;
using InCryptoSec2.InGtkCryptoSec2.Model.Database;

[System.ComponentModel.ToolboxItem(true)]
public partial class WidCryptoDatabase : Gtk.Bin
{
    #region Private Class Members
    private DatabaseType m_Database = DatabaseType.Oracle;
    #endregion

    #region Class Constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="WidCryptoDatabase"/> class.
    /// </summary>
    public WidCryptoDatabase()
    {
        this.Build();

        InitForm();
    }
    #endregion

    #region Private Member Function
    /// <summary>
    /// Initializes form controls.
    /// </summary>
    private void InitForm()
    {
        this.lblEncription.Text = "RSA Cryptography Provider";
        this.lblDatabase.Text = "ORACLE";
        this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.oracle_32x32.png");
    }
    /// <summary>
    /// Changes the selected database information.
    /// </summary>
    private void ChangeDatabase()
    {
        switch(m_Database)
        {
            case DatabaseType.Oracle :
                {
                    this.lblDatabase.Text = "ORACLE";
                    this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.oracle_32x32.png");
                    break;
                }
            case DatabaseType.SQLServer :
                {
                    this.lblDatabase.Text = "MS SQLServer";
                    this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.sqlserver5.gif");
                    break;
                }
            case DatabaseType.MySQL :
                {
                    this.lblDatabase.Text = "MySQL";
                    this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.MySQL_32x32.png");
                    break;
                }
            case DatabaseType.SQLite :
                {
                    this.lblDatabase.Text = "SQLite";
                    this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.SQLite2_32x32.png");
                    break;
                }
        }
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// On database login.
    /// </summary>
    protected void btnLogin_OnClick (object sender, EventArgs e)
    {
        throw new NotImplementedException ();
    }

    /// <summary>
    /// On cryptography configuration change.
    /// </summary>
    protected void btnCryptoConfig_OnClick (object sender, EventArgs e)
    {
        throw new NotImplementedException ();
    }

    /// <summary>
    /// On database configuration change.
    /// </summary>
    protected void btnDatabaseConfig_OnClick (object sender, EventArgs e)
    {
        WinDatabaseConfig frmDatabaseConfig = new WinDatabaseConfig(m_Database);
        frmDatabaseConfig.Run();
        m_Database = frmDatabaseConfig.SelectedDatabase;
        frmDatabaseConfig.Destroy();
        ChangeDatabase();
    }
    #endregion
}


