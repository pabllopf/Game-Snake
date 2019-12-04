//-----------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="Board.cs" company="UnMedioStudio">Open Source</copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Clasic videogame snake.
/// </summary>
namespace Snake
{
    using Game_Snake;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>Interface of the videogame</suma" />
    public partial class Board : Form
    {
        /// <summary>The snake</summary>
        private List<Circle> snake = new List<Circle>();

        /// <summary>The food</summary>
        private Circle food = new Circle();

        RecordSystem recordSystem;

        /// <summary>Initializes a new instance of the <see cref="Board"/> class.</summary>
        public Board()
        {
            this.InitializeComponent();
            this.SetFirstGame();
            this.SetGameTimer();
            this.LoadRecord();
        }

        private void LoadRecord() 
        {
            string path = Application.StartupPath + "/record.json";

            if (!File.Exists(path)) 
            {
                using (StreamWriter mylogs = File.AppendText(path)) 
                { 
                    mylogs.Close();
                }
                recordSystem = new RecordSystem();
                string json = JsonConvert.SerializeObject(recordSystem);
                System.IO.File.WriteAllText(path, json);
            }

            using (StreamReader jsonStream = File.OpenText(path))
            {
                recordSystem = new RecordSystem();
                var json = jsonStream.ReadToEnd();
                recordSystem = JsonConvert.DeserializeObject<RecordSystem>(json);
            }

            record.Text = recordSystem.recordVar.ToString();
        }
        /// <summary>Sets the game timer.</summary>
        private void SetGameTimer() 
        {
            this.gameTimer.Interval = 1000 / Settings.Speed;
            this.gameTimer.Tick += this.UpdateScreen;
            this.gameTimer.Start();
        }

        /// <summary>Sets the first game.</summary>
        private void SetFirstGame() 
        {
            this.welcome.Visible = true;
            this.pause.Visible = false;
            this.pressStart.Visible = true;
            this.gameOver.Visible = false;
            new Settings();
            Settings.GameOver = true;
        }

        /// <summary>Starts the game.</summary>
        private void StartGame()
        {
            this.ResetSettings();
            this.NewPlayer();
            this.GenerateFood();
        }

        /// <summary>Resets the settings.</summary>
        private void ResetSettings() 
        {
            welcome.Visible = false;
            pause.Visible = false;
            gameOver.Visible = false;
            pressStart.Visible = false;
            new Settings();
            scoreValue.Text = Settings.Score.ToString();
        }

        /// <summary>Creates new player.</summary>
        private void NewPlayer() 
        {
            this.snake.Clear();
            this.snake.Add(new Circle { X = 10, Y = 5 });
            this.snake.Add(new Circle{X = this.snake[this.snake.Count - 1].X,Y = this.snake[this.snake.Count - 1].Y});
            this.snake.Add(new Circle { X = this.snake[this.snake.Count - 1].X, Y = this.snake[this.snake.Count - 1].Y });
        }

        /// <summary>Generates the food.</summary>
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            this.food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        /// <summary>Updates the screen.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    this.StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.D) && Settings.DirectionSnake != Direction.Left) 
                {
                    Settings.DirectionSnake = Direction.Right;
                }

                if (Input.KeyPressed(Keys.A) && Settings.DirectionSnake != Direction.Right) 
                {
                    Settings.DirectionSnake = Direction.Left;
                }

                if (Input.KeyPressed(Keys.W) && Settings.DirectionSnake != Direction.Down) 
                {
                    Settings.DirectionSnake = Direction.Up;
                }

                if (Input.KeyPressed(Keys.S) && Settings.DirectionSnake != Direction.Up) 
                {
                    Settings.DirectionSnake = Direction.Down;
                }

                this.MovePlayer();
            }

            this.pbCanvas.Invalidate();
        }

        /// <summary>Handles the Paint event of the canvas control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                for (int i = 0; i < this.snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                    {
                        snakeColour = Brushes.Black;
                    }
                    else 
                    {
                        snakeColour = Brushes.Green;
                    }

                    canvas.FillEllipse(snakeColour, new Rectangle(this.snake[i].X * Settings.Width, this.snake[i].Y * Settings.Height, Settings.Width, Settings.Height));
                    canvas.FillEllipse(Brushes.Red, new Rectangle(this.food.X * Settings.Width,  this.food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                if (!welcome.Visible) 
                {
                    if (Settings.Score >= recordSystem.recordVar) 
                    {
                        recordSystem.recordVar = Settings.Score;
                        record.Text = recordSystem.recordVar.ToString();
                    }
                    
                    gameOver.Visible = true;
                    pressStart.Visible = true;
                }
            }
        }

        /// <summary>Moves the player.</summary>
        private void MovePlayer()
        {
            for (int i = this.snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.DirectionSnake)
                    {
                        case Direction.Right:
                            this.snake[i].X++;
                            break;
                        case Direction.Left:
                            this.snake[i].X--;
                            break;
                        case Direction.Up:
                            this.snake[i].Y--;
                            break;
                        case Direction.Down:
                            this.snake[i].Y++;
                            break;
                    }

                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    if (this.snake[i].X < 0 || this.snake[i].Y < 0 || this.snake[i].X >= maxXPos || this.snake[i].Y >= maxYPos)
                    {
                        this.Die();
                    }

                    for (int j = 1; j < this.snake.Count; j++)
                    {
                        if (this.snake[i].X == this.snake[j].X && this.snake[i].Y == this.snake[j].Y)
                        {
                            this.Die();
                        }
                    }

                    if (this.snake[0].X == this.food.X && this.snake[0].Y == this.food.Y)
                    {
                        this.Eat();
                    }
                }
                else
                {
                    this.snake[i].X = this.snake[i - 1].X;
                    this.snake[i].Y = this.snake[i - 1].Y;
                }
            }
        }

        /// <summary>Handles the KeyDown event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            if (e.KeyCode == Keys.Space && pause.Visible == false)
            {
                this.gameTimer.Stop();
                this.pause.Visible = true;
                return;
            }
            if (e.KeyCode == Keys.Space && pause.Visible == true) 
            {
                this.gameTimer.Start();
                this.pause.Visible = false;
                return;
            }
        }

        /// <summary>Handles the KeyUp event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        /// <summary>Eats this instance.</summary>
        private void Eat()
        {
            Circle circle = new Circle
            {
                X = this.snake[this.snake.Count - 1].X,
                Y = this.snake[this.snake.Count - 1].Y
            };

            this.snake.Add(circle);

            Settings.Score += Settings.Points;
            this.scoreValue.Text = Settings.Score.ToString();

            this.GenerateFood();
        }

        /// <summary>Dies this instance.</summary>
        private void Die()
        {
            Settings.GameOver = true;
        }

        /// <summary>Handles the Click event of the gameOver control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LblGameOver_Click(object sender, EventArgs e)
        {
        }

        /// <summary>Handles the Click event of the label1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>Handles the Click event of the canvas control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PbCanvas_Click(object sender, EventArgs e)
        {
        }

        /// <summary>Handles the Click event of the newToolStripMenuItem control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartGame();
        }

        /// <summary>Handles the Click event of the infoToolStripMenuItem control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed By Pablo Perdomo Falcón");
        }

        /// <summary>Handles the Click event of the exitToolStripMenuItem1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        /// <summary>Handles the FormClosing event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.gameTimer.Stop();
            string path = Application.StartupPath + "/record.json";
            string json = JsonConvert.SerializeObject(recordSystem);
            System.IO.File.WriteAllText(path, json);
            if (MessageBox.Show("Do you want exit?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
                this.gameTimer.Start();
            }
        }

        /// <summary>Handles the Load event of the Board control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Board_Load(object sender, EventArgs e)
        {
            Program.PutLogo();
            System.Threading.Thread.Sleep(3000);
            Program.QuitLogo();
        }
    }
}
