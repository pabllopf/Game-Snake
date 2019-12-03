//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Program.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Clasic videogame snake.
/// </summary>
namespace Snake
{
    using System;
    using System.Windows.Forms;

    /// <summary>Main Class</summary>
    public static class Program
    {
        /// <summary>The start logo</summary>
        private static StartLogo startLogo = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startLogo = new StartLogo();
            startLogo.Show();

            Board mainForm = new Board();
            mainForm.Refresh();

            Application.Run(mainForm);
        }

        /// <summary>Puts the logo.</summary>
        public static void PutLogo() 
        {
            startLogo.Refresh();
        }

        /// <summary>Quits the logo.</summary>
        public static void QuitLogo()
        {
            startLogo.Close();
        }
    }
}
