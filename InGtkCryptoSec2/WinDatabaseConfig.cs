//
//  WinDatabaseConfig.cs
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
using InCryptoSec2.InGtkCryptoSec2.Model.Database;

namespace InGtkCryptoSec2
{
    public partial class WinDatabaseConfig : Gtk.Dialog
    {
        #region Private Class Members
        private DatabaseType m_DatabaseType;
        #endregion

        #region Class Constructor
        public WinDatabaseConfig()
        {
            this.Build();
            this.m_DatabaseType = DatabaseType.None;
        }

        public WinDatabaseConfig(DatabaseType database)
        {
            this.Build();
            m_DatabaseType = database;
        }
        #endregion

        #region Event Handlers

        protected void btnCancel_OnClick (object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void btnSQLServer_OnClick (object sender, EventArgs e)
        {
            this.m_DatabaseType = DatabaseType.SQLServer;
            this.Destroy();
        }

        protected void btnMySQL_OnClick (object sender, EventArgs e)
        {
            this.m_DatabaseType = DatabaseType.MySQL;
            this.Destroy();
        }

        protected void btnSQLite_OnClick (object sender, EventArgs e)
        {
            this.m_DatabaseType = DatabaseType.SQLite;
            this.Destroy();
        }

        protected void btnOracle_OnClick (object sender, EventArgs e)
        {
            this.m_DatabaseType = DatabaseType.Oracle;
            this.Hide();
            this.Destroy();
        }
        #endregion

        #region Public Properties
        public DatabaseType SelectedDatabase 
        { 
            get
            {
                return m_DatabaseType;
            }
            set
            {
                m_DatabaseType = value;  
            }
        }
        #endregion
    }
}

