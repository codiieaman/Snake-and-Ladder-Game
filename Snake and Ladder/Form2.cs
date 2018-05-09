using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake_and_Ladder
{
    public partial class Form2 : Form
    {
        bool PlayerTurn = true;
        int DiceNumber = 0;
        int Playerturncount = 0;
        int Player1Locat = 0;
        int Player2Locat = 0;
        public Form2()
        {
            InitializeComponent();
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Player1.Location = new Point(36,510);
            Player2.Location = new Point(36, 510 + 46);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random rn = new Random();
            int RandomDiceNumber = rn.Next(1, 6);
            #region DiceImage
            switch (RandomDiceNumber)
            {
                case 1:
                    Dice1.Visible = true;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 2:
                    Dice1.Visible = false;
                    Dice2.Visible = true;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 3:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = true;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 4:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = true;
                    Dice5.Visible = false;
                    Dice6.Visible = false;
                    break;
                case 5:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = true;
                    Dice6.Visible = false;
                    break;
                case 6:
                    Dice1.Visible = false;
                    Dice2.Visible = false;
                    Dice3.Visible = false;
                    Dice4.Visible = false;
                    Dice5.Visible = false;
                    Dice6.Visible = true;
                    break;
            }
            #endregion
            DiceNumber = RandomDiceNumber;
            Playerturncount++;
            if (Playerturncount % 2 == 0)
            {
                PlayerTurn = true;
                CurrentPlayer.Text = Player1Name.Text;
            }
            else
            {
                PlayerTurn = false;
                CurrentPlayer.Text = Player2Name.Text;
            }
            if (PlayerTurn == true)
            {
                
              Player1Locat = Player1Locat + RandomDiceNumber;
            PlayerLocation.Player1Location(Player1Locat, Player1);
                #region snake 
            switch (Player1Locat)
            { 
                case 12:
                    Player1.Location=new Point(216,510);
                    MessageBox.Show("You Bite By Snake");
                    Player1Locat = 2;
                    break;
                case 20:
                    Player1.Location = new Point(483, 510);
                     MessageBox.Show("You Bite By Snake");
                    Player1Locat = 5;
                    break;
                case 39:
                    Player1.Location=new Point(572,353);
                     MessageBox.Show("You Bite By Snake");
                    Player1Locat = 22;
                    break;
                case 44:
                    Player1.Location = new Point(36, 432);
                     MessageBox.Show("You Bite By Snake");
                    Player1Locat = 15;
                    break;
                case 47:
                    Player1.Location = new Point(129,272);
                     MessageBox.Show("You Bite By Snake");
                    Player1Locat = 30;
                    break;
                case 54:
                    Player1.Location = new Point(306,353);
                     MessageBox.Show("You Bite By Snake");
                    Player1Locat = 19;
                    break;
            }
                #endregion
                #region laddar
            switch (Player1Locat)
            {
                case 3:
                    Player1.Location = new Point(483,432);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 10;
                    break;
                case 9:
                    Player1.Location = new Point(483, 353);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 21;
                    break;
                case 18:
                    Player1.Location = new Point(306, 193);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 35;
                    break;
                case 13:
                    Player1.Location = new Point(36, 272);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 31;
                    break;
                case 25:
                    Player1.Location = new Point(663, 113);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 40;
                    break;
                case 36:
                    Player1.Location = new Point(306, 33);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 51;
                    break;
                case 48:
                    Player1.Location = new Point(216,33);
                    MessageBox.Show("You Got Laddar");
                    Player1Locat = 50;
                    break;
            }
                #endregion
                #region Winning
            if (Player1Locat >= 55 && Player1Locat<=65)
            {
                MessageBox.Show("Player1 Wins");
                Player1Locat = 66;
                Player2Locat = 66;

            }
                #endregion
            }
            else if (PlayerTurn == false)
            {
               Player2Locat = Player2Locat + RandomDiceNumber;
                PlayerLocation.Player2Location(Player2Locat, Player2);
                #region snake
                switch (Player2Locat)
                {
                    case 12:
                        Player2.Location = new Point(216, 510+46);
                        MessageBox.Show("You Bite By Snake");
                        Player2Locat = 2;
                        break;
                    case 20:
                        Player2.Location = new Point(483, 510+46);
                        MessageBox.Show("You Bite By Snake");
                        Player2Locat = 5;
                        break;
                    case 39:
                        Player2.Location = new Point(572, 353+46);
                        MessageBox.Show("You Bite By Snake");
                        Player2Locat = 22;
                        break;
                    case 44:
                        Player2.Location = new Point(36, 432+46);
                        MessageBox.Show("You Bite By Snake");
                        Player2Locat = 15;
                        break;
                    case 47:
                        Player2.Location = new Point(129, 272+46);
                        MessageBox.Show("You Bite By Snake");
                        Player2Locat = 30;
                        break;
                    case 54:
                        Player2.Location = new Point(306, 353+46);
                        MessageBox.Show("You Bite By Snake");
                        Player2Locat = 19;
                        break;
                }
                #endregion
                #region laddar
                switch (Player2Locat)
                {
                    case 3:
                        Player2.Location = new Point(483, 432+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 10;
                        break;
                    case 9:
                        Player2.Location = new Point(483, 353+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 21;
                        break;
                    case 18:
                        Player2.Location = new Point(306, 193+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 35;
                        break;
                    case 13:
                        Player2.Location = new Point(36, 272+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 31;
                        break;
                    case 25:
                        Player2.Location = new Point(663, 113+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 40;
                        break;
                    case 36:
                        Player2.Location = new Point(306, 33+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 51;
                        break;
                    case 48:
                        Player2.Location = new Point(216, 33+46);
                        MessageBox.Show("You Got Laddar");
                        Player2Locat = 50;
                        break;
                }
                #endregion
                #region Winning
                if (Player2Locat >= 55 && Player2Locat <= 65)
                {
                    MessageBox.Show("Player2 Wins");
                    Player1Locat = 66;
                    Player2Locat = 66;

                }
                #endregion
            }
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PlayerTurn = true;
             DiceNumber = 0;
             Playerturncount = 0;
           Player1Locat = 0;
            Player2Locat = 0;
            Player1.Location = new Point(36, 510);
            Player2.Location = new Point(36, 510 + 46);
        }
    }
}
