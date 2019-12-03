//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="StartLogo.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Clasic videogame snake.
/// </summary>
namespace Snake
{
    using System.Windows.Forms;

    /// <summary>Start logo of videogame</summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class StartLogo : Form
    {
        /// <summary>Initializes a new instance of the <see cref="StartLogo"/> class.</summary>
        public StartLogo()
        {
            this.InitializeComponent();
        }

        /// <summary>Initializes the component.</summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackgroundImage = global::Game_Snake.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 226);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}
