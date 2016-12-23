//
//  CryptoSec2TitleWidget.cs
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

[System.ComponentModel.ToolboxItem(true)]
public partial class CryptoSec2TitleWidget : Gtk.Bin
{
    #region Private Class Members
    #endregion

    #region Class Constuctor
    /// <summary>
    /// CryptoSec2TitleWidget class constructor.
    /// </summary>
    public CryptoSec2TitleWidget()
    {
        this.CryptoSecModule = CryptoSecModuleType.Database;
        this.Build();
    }
    #endregion

    #region Private Member Functions
    /// <summary>
    /// Change InGtkCryptoSec2 application module.
    /// </summary>
    private void ChangeCryptoSecApplicationModule()
    {
        switch(CryptoSecModule)
        {
            case CryptoSecModuleType.Database :
                {
                    this.lblCryptoSecModeTitle.Text = @"Database Security";
                    break;
                }
            case CryptoSecModuleType.FTP :
                {
                    this.lblCryptoSecModeTitle.Text = @"FTP Security";
                    break;
                }
            case CryptoSecModuleType.String :
                {
                    this.lblCryptoSecModeTitle.Text = @"String Security";
                    break;
                }
            case CryptoSecModuleType.XML :
                {
                    this.lblCryptoSecModeTitle.Text = @"XML Security";
                    break;
                }
            case CryptoSecModuleType.File :
                {
                    this.lblCryptoSecModeTitle.Text = @"File Security";
                    break;
                }
        }
    }
    #endregion

    #region Event Handlers
    /// <summary>
    /// Button CryptoSecMode on click event handler.
    /// </summary>
    protected void btnCryptoSecMode_OnClick (object sender, EventArgs e)
    {
        WinCryptoSec2Config frmCryptoSecConfig = new WinCryptoSec2Config(CryptoSecModule);
        frmCryptoSecConfig.Run();
        CryptoSecModule = frmCryptoSecConfig.CryptoSecModule;
        frmCryptoSecConfig.Destroy();
        ChangeCryptoSecApplicationModule();
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Active InCryptoSec2 application module.
    /// </summary>
    public CryptoSecModuleType CryptoSecModule { get; set;}
    #endregion
}


