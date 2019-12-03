//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Settings.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Clasic videogame snake.
/// </summary>
namespace Snake
{
    /// <summary>Direction of Snake</summary>
    public enum Direction
    {
        /// <summary>Up Direction</summary>
        Up,

        /// <summary>Down Direction</summary>
        Down,

        /// <summary>Left Direction</summary>
        Left,

        /// <summary>Right Direction</summary>
        Right
    }

    /// <summary>Settings of the videogame</summary>
    public class Settings
    {
        /// <summary>Initializes a new instance of the <see cref="Settings"/> class.</summary>
        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 12;
            Score = 0;
            Points = 1;
            GameOver = false;
            DirectionSnake = Direction.Down;
        }

        /// <summary>Gets or sets the width.</summary>
        /// <value>The width.</value>
        public static int Width { get; set; }

        /// <summary>Gets or sets the height.</summary>
        /// <value>The height.</value>
        public static int Height { get; set; }

        /// <summary>Gets or sets the speed.</summary>
        /// <value>The speed.</value>
        public static int Speed { get; set; }

        /// <summary>Gets or sets the score.</summary>
        /// <value>The score.</value>
        public static int Score { get; set; }

        /// <summary>Gets or sets the points.</summary>
        /// <value>The points.</value>
        public static int Points { get; set; }

        /// <summary>Gets or sets a value indicating whether [game over].</summary>
        /// <value>
        /// <c>true</c> if [game over]; otherwise, <c>false</c>.</value>
        public static bool GameOver { get; set; }

        /// <summary>Gets or sets the direction.</summary>
        /// <value>The direction.</value>
        public static Direction DirectionSnake { get; set; }
    }
}
