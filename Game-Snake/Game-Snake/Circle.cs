//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Circle.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Clasic videogame snake.
/// </summary>
namespace Snake
{
    /// <summary>Circle to drawn (snake)</summary>
    public class Circle
    {
        /// <summary>Initializes a new instance of the <see cref="Circle"/> class.</summary>
        public Circle()
        {
            this.X = 0;
            this.Y = 0;
        }

        /// <summary>Gets or sets the x.</summary>
        /// <value>The x.</value>
        public int X { get; set; }

        /// <summary>Gets or sets the y.</summary>
        /// <value>The y.</value>
        public int Y { get; set; }
    }
}
