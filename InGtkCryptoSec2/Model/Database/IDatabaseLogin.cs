//
//  IDatabaseLogin.cs
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

namespace InCryptoSec2.InGtkCryptoSec2.Model.Database
{
    /// <summary>
    /// Database login interface.
    /// </summary>
    public interface IDatabaseLogin
    {
        /// <summary>
        /// Database user name.
        /// </summary>
        string UserName { get; set; }
        /// <summary>
        /// Database user password.
        /// </summary>
        string UserPasswd { get; set; }
        /// <summary>
        /// Database server.
        /// </summary>
        string DatabaseServer { get; set; }
        /// <summary>
        /// Database connection string.
        /// </summary>
        string DatabaseConnectionString { get; set; }
        /// <summary>
        /// Database type.
        /// </summary>
        DatabaseType Database { get; set; }
    }

    /// <summary>
    /// Encrypted Database login data interface.
    /// </summary>
    public interface IDatabaseSecData
    {
        /// <summary>
        /// Encrypted database user name.
        /// </summary>
        string SecUserName { get; set; }
        /// <summary>
        /// Encrypted database user password.
        /// </summary>
        string SecUserPasswd { get; set; }
        /// <summary>
        /// Encrypted database server.
        /// </summary>
        string SecDatabaseServer { get; set; }
        /// <summary>
        /// Encrypted database connection string.
        /// </summary>
        string SecDatabaseConnectionString { get; set; }
    }

}