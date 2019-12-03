//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Input.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Clasic videogame snake.
/// </summary>
namespace Snake
{
    using System.Collections;
    using System.Windows.Forms;

    /// <summary>Control inputs of videogame</summary>
    internal class Input
    {
        /// <summary>The key table</summary>
        private static Hashtable keyTable = new Hashtable();

        /// <summary>Keys the pressed.</summary>
        /// <param name="key">The key.</param>
        /// <returns>return true if some key was pressed</returns>
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        /// <summary>Changes the state.</summary>
        /// <param name="key">The key.</param>
        /// <param name="state">if set to <c>true</c> [state].</param>
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
