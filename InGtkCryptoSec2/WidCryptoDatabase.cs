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

[System.ComponentModel.ToolboxItem(true)]
public partial class WidCryptoDatabase : Gtk.Bin
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WidCryptoDatabase"/> class.
    /// </summary>
    public WidCryptoDatabase()
    {
        this.Build();

        InitForm();
    }

    #region Private Member Function
    private void InitForm()
    {
        this.lblEncription.Text = "RSA Cryptography Provider";
        this.lblDatabase.Text = "ORACLE";
        this.imgDatabase.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("InGtkCryptoSec2.icons.oracle_32x32.png");
    }
    #endregion

    #region Event Handlers
    protected void btnLogin_OnClick (object sender, EventArgs e)
    {
        throw new NotImplementedException ();
    }

    protected void btnCryptoConfig_OnClick (object sender, EventArgs e)
    {
        throw new NotImplementedException ();
    }

    protected void btnDatabaseConfig_OnClick (object sender, EventArgs e)
    {
        throw new NotImplementedException ();
    }
    #endregion
}


