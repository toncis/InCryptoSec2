//
//  CryptoSecModuleType.cs
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

namespace InGtkCryptoSec2.Model
{
    /// <summary>
    /// InCryptoSec2 module enum.
    /// Supported InGtkCryptoSec2 application types ...
    /// </summary>
    [Serializable]    
    public enum CryptoSecModuleType
    {
        /// <summary>
        /// None.
        /// </summary>
        [Description("None")]
        None = 0,
        /// <summary>
        /// Database.
        /// </summary>
        [Description("Database")]
        Database = 1,
        /// <summary>
        /// FTP.
        /// </summary>
        [Description("FTP")]
        FTP = 2,
        /// <summary>
        /// Securing strings.
        /// </summary>
        [Description("String")]
        String = 3,
        /// <summary>
        /// Securing files.
        /// </summary>
        [Description("File")]
        File = 4,
        /// <summary>
        /// Securing xml.
        /// </summary>
        [Description("XML")]
        XML = 5
    }
}

