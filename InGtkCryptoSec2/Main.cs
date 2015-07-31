//  
//  Main.cs
//  
//  Author:
//       Tonči Sviličić <tonci.svilicic@in2.hr>
// 
//  Copyright (c) 2012 Tonči Sviličić
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

namespace InGtkCryptoSec2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			//MainWindow win = new MainWindow ();
			//win.Show ();
            WinCryptoSec2 win2 = new WinCryptoSec2 ();
            win2.Show ();
			Application.Run ();
		}
	}

    static class CryptoSecMessageBox
    {
        internal static void ShowError(Window win, string strFormat, params object[] args)
        {
            MessageDialog msgDiagError = new MessageDialog(
                win, 
                DialogFlags.DestroyWithParent, 
                MessageType.Error, 
                ButtonsType.Close, 
                strFormat,
                args);
            msgDiagError.Run();
            msgDiagError.Destroy();     }
        internal static void ShowError(Window win, string strError)
        {
            MessageDialog msgDiagError = new MessageDialog(
                win, 
                DialogFlags.DestroyWithParent, 
                MessageType.Error, 
                ButtonsType.Close, 
                strError);
            msgDiagError.Run();
            msgDiagError.Destroy();     
        }
        internal static void ShowError(string strError)
        {
            MessageDialog msgDiagError = new MessageDialog(
                null, 
                DialogFlags.DestroyWithParent, 
                MessageType.Error, 
                ButtonsType.Close, 
                strError);
            msgDiagError.Run();
            msgDiagError.Destroy();     
        }

        internal static void ShowInformation(Window win, string strFormat, params object[] args)
        {
            MessageDialog msgDiagInformation = new MessageDialog(
                win, 
                DialogFlags.DestroyWithParent, 
                MessageType.Info, 
                ButtonsType.Ok, 
                strFormat,
                args);
            msgDiagInformation.Run();
            msgDiagInformation.Destroy();       }
        internal static void ShowInformation(Window win, string strInfo)
        {
            MessageDialog msgDiagInformation = new MessageDialog(
                win, 
                DialogFlags.DestroyWithParent, 
                MessageType.Info, 
                ButtonsType.Ok, 
                strInfo);
            msgDiagInformation.Run();
            msgDiagInformation.Destroy();       
        }
        internal static void ShowInformation(string strInfo)
        {
            MessageDialog msgDiagInformation = new MessageDialog(
                null, 
                DialogFlags.DestroyWithParent, 
                MessageType.Info, 
                ButtonsType.Ok, 
                strInfo);
            msgDiagInformation.Run();
            msgDiagInformation.Destroy();       
        }

        internal static bool ShowQuestion(Window win, string strFormat, params object[] args)
        {
            bool retValue = false;

            MessageDialog msgDiagQuestion = new MessageDialog(
                win, 
                DialogFlags.DestroyWithParent, 
                MessageType.Question, 
                ButtonsType.YesNo, 
                strFormat,
                args);
            int iResult = msgDiagQuestion.Run();
            msgDiagQuestion.Destroy();

            if(iResult == (int)ResponseType.Accept)
            {
                retValue = true;
            }

            return retValue;
        }
        internal static bool ShowQuestion(Window win, string strQuestion)
        {
            bool retValue = false;

            MessageDialog msgDiagQuestion = new MessageDialog(
                win, 
                DialogFlags.DestroyWithParent, 
                MessageType.Question, 
                ButtonsType.YesNo, 
                strQuestion);
            int iResult = msgDiagQuestion.Run();
            msgDiagQuestion.Destroy();

            if(iResult == (int)ResponseType.Accept)
            {
                retValue = true;
            }

            return retValue;
        }
        internal static bool ShowQuestion(string strQuestion)
        {
            bool retValue = false;

            MessageDialog msgDiagQuestion = new MessageDialog(
                null, 
                DialogFlags.DestroyWithParent, 
                MessageType.Question, 
                ButtonsType.YesNo, 
                strQuestion);
            int iResult = msgDiagQuestion.Run();
            msgDiagQuestion.Destroy();

            if(iResult == (int)ResponseType.Accept)
            {
                retValue = true;
            }

            return retValue;
        }
    }

}
