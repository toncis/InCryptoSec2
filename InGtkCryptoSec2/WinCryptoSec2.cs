//
//  WinCryptoSec2.cs
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
using Gtk;
using InGtkCryptoSec2.Model;

public partial class WinCryptoSec2 : Gtk.Window
{
    #region Private Class Members
    private CryptoSecModuleType m_CryptoSecModule;
    #endregion

    #region Class Constuctor
    /// <summary>
    /// CryptoSec2TitleWidget class constructor.
    /// </summary>
    public WinCryptoSec2() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();

        InitForm();
    }
    #endregion

    #region Private Member Function
    private void InitForm()
    {
        m_CryptoSecModule = CryptoSecModuleType.Database;
        m_CryptoSecModule = cryptosec2titlewidget1.CryptoSecModule;
    }
    #endregion

}

