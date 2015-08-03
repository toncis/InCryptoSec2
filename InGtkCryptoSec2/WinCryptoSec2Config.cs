//
//  WinCryptoSec2Config.cs
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
using InGtkCryptoSec2.Model;

public partial class WinCryptoSec2Config : Gtk.Dialog
{
    #region Private Class Members
    private CryptoSecModuleType m_CryptoSecModule;
    #endregion

    #region Class Constuctor
    /// <summary>
    /// CryptoSec2TitleWidget class constructor.
    /// </summary>
    public WinCryptoSec2Config()
    {
        m_CryptoSecModule = CryptoSecModuleType.None;
        this.Build();
    }
    /// <summary>
    /// CryptoSec2TitleWidget class constructor.
    /// </summary>
    public WinCryptoSec2Config(CryptoSecModuleType mode)
    {
        m_CryptoSecModule = mode;
        this.Build();

        switch(m_CryptoSecModule)
        {
            case CryptoSecModuleType.Database:
                {
                    this.btnDatabase.GrabFocus();
                    break;
                }
            case CryptoSecModuleType.FTP:
                {
                    this.btnFtp.GrabFocus();
                    break;
                }
            case CryptoSecModuleType.String:
                {
                    this.btnString.GrabFocus();
                    break;
                }
            case CryptoSecModuleType.XML:
                {
                    this.btnXml.GrabFocus();
                    break;
                }
        }
    }
    #endregion

    #region Event Handlers
    protected void btnDatabase_OnClick (object sender, EventArgs e)
    {
        m_CryptoSecModule = CryptoSecModuleType.Database;
        this.Destroy();
    }

    protected void btnString_OnClick (object sender, EventArgs e)
    {
        m_CryptoSecModule = CryptoSecModuleType.String;
        this.Destroy();
    }

    protected void btnXml_OnClick (object sender, EventArgs e)
    {
        m_CryptoSecModule = CryptoSecModuleType.XML;
        this.Destroy();
    }

    protected void btnFtp_OnClick (object sender, EventArgs e)
    {
        m_CryptoSecModule = CryptoSecModuleType.FTP;
        this.Destroy();
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Active InCryptoSec2 application module.
    /// </summary>
    public CryptoSecModuleType CryptoSecModule 
    {
        get
        {
            return m_CryptoSecModule;
        }
        set 
        {
            m_CryptoSecModule = value;
        }
    }
    #endregion
}

