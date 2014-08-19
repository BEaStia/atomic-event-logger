using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AnomalEvent.Classes;
using AnomalEvent.Forms;

namespace AnomalEvent
{
	static class Program
	{
	    /// <summary>
	    /// Главная точка входа для приложения.
	    /// </summary>
	    [STAThread]
	    private static void Main()
	    {
	        if (AnomalEventConnection.CreateConnection())
	        {
	            Application.EnableVisualStyles();
	            Application.SetCompatibleTextRenderingDefault(false);
	            Application.Run(new LoginForm());
	            Application.ApplicationExit += Application_ApplicationExit;
	        }
	        else
	        {
	            
	        }
	    }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            AnomalEventConnection.Connection.Close();
        }
	}
}
