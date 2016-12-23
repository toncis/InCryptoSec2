//
//  DatabaseType.cs
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
using System.ComponentModel;

namespace InCryptoSec2.InGtkCryptoSec2.Model.Database
{
    /// <summary>
    /// DatabaseType enum.
    /// Supported database types..
    /// </summary>
    [Serializable]
    public enum DatabaseType
    {
        /// <summary>
        /// None.
        /// </summary>
        [Description("None")]
        None = 0,
        /// <summary>
        /// Oracle.
        /// </summary>
        [Description("Oracle")]
        Oracle = 1,
        /// <summary>
        /// MS SQL Server.
        /// </summary>
        [Description("SQLServer")]
        SQLServer = 2,
        /// <summary>
        /// MySQL.
        /// </summary>
        [Description("MySQL")]
        MySQL = 3,
        /// <summary>
        /// PostgreSQL.
        /// </summary>
        [Description("PostgreSQL")]
        PostgreSQL = 4,
        /// <summary>
        /// SQLite.
        /// </summary>
        [Description("SQLite")]
        SQLite = 5
    }

}