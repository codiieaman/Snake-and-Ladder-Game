using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Snake_and_Ladder
{
    class PlayerLocation
    {
        public static void Player1Location(int Player1location, PictureBox Player1)
        {
         
            switch (Player1location)
            {
                case 0:
                    Player1.Location = new Point(36, 510);
                    break;
                case 1:
                    Player1.Location = new Point(129, 510);
                    break;
                case 2:
                    Player1.Location = new Point(216, 510);
                    break;
                case 3:
                    Player1.Location = new Point(306, 510);
                    break;
                case 4:
                    Player1.Location = new Point(394, 510);
                    break;
                case 5:
                    Player1.Location = new Point(483, 510);
                    break;
                case 6:
                    Player1.Location = new Point(572, 510);
                    break;
                case 7:
                    Player1.Location = new Point(663, 510);
                    break;
                case 8:
                    Player1.Location = new Point(663, 432);
                    break;
                case 9:
                    Player1.Location = new Point(572, 432);
                    break;
                case 10:
                    Player1.Location = new Point(483, 432);
                    break;
                case 11:
                    Player1.Location = new Point(394, 432);
                    break;
                case 12:
                    Player1.Location = new Point(306, 432);
                   break;
                case 13:
                    Player1.Location = new Point(216, 432);
                    break;
                case 14:
                    Player1.Location = new Point(129, 432);
                    break;
                case 15:
                    Player1.Location = new Point(36, 432);
                    break;
                case 16:
                    Player1.Location = new Point(36, 353);
                    break;
                case 17:
                    Player1.Location = new Point(129, 353);
                    break;
                case 18:
                    Player1.Location = new Point(216, 353);
                    break;
                case 19:
                    Player1.Location = new Point(306, 353);
                    break;
                case 20:
                    Player1.Location = new Point(394, 353);
                    
                    break;
                case 21:
                    Player1.Location = new Point(483, 353);
                    break;
                case 22:
                    Player1.Location = new Point(572, 353);
                    break;
                case 23:
                    Player1.Location = new Point(663, 353);
                    break;
                case 24:
                    Player1.Location = new Point(663, 272);
                    break;
                case 25:
                    Player1.Location = new Point(572, 272);
                    break;
                case 26:
                    Player1.Location = new Point(483, 272);
                    break;
                case 27:
                    Player1.Location = new Point(394, 272);
                    break;
                case 28:
                    Player1.Location = new Point(306, 272);
                    break;
                case 29:
                    Player1.Location = new Point(216, 272);
                    break;
                case 30:
                    Player1.Location = new Point(129, 272);
                    break;
                case 31:
                    Player1.Location = new Point(36, 272);
                    break;
                case 32:
                    Player1.Location = new Point(36, 193);
                    break;
                case 33:
                    Player1.Location = new Point(129, 193);
                    break;
                case 34:
                    Player1.Location = new Point(216, 193);
                    break;
                case 35:
                    Player1.Location = new Point(306, 193);
                    break;
                case 36:
                    Player1.Location = new Point(394, 193);
                    break;
                case 37:
                    Player1.Location = new Point(483, 193);
                    break;
                case 38:
                    Player1.Location = new Point(572, 193);
                    break;
                case 39:
                    Player1.Location = new Point(663, 193);
                    break;
                case 40:
                    Player1.Location = new Point(663, 113);
                    break;
                case 41:
                    Player1.Location = new Point(572, 113);
                    break;
                case 42:
                    Player1.Location = new Point(483, 113);
                    break;
                case 43:
                    Player1.Location = new Point(394, 113);
                    break;
                case 44:
                    Player1.Location = new Point(306, 113);
                    break;
                case 45:
                    Player1.Location = new Point(216, 113);
                    break;
                case 46:
                    Player1.Location = new Point(129, 113);
                    break;
                case 47:
                    Player1.Location = new Point(36, 113);
                    break;
                case 48:
                    Player1.Location = new Point(36, 33);
                    break;
                case 49:
                    Player1.Location = new Point(129, 33);
                    break;
                case 50:
                    Player1.Location = new Point(216, 33);
                    break;
                case 51:
                    Player1.Location = new Point(306, 33);
                    break;
                case 52:
                    Player1.Location = new Point(394, 33);
                    break;
                case 53:
                    Player1.Location = new Point(483, 33);
                    break;
                case 54:
                    Player1.Location = new Point(572, 33);
                    break;
                case 55:
                    Player1.Location = new Point(663, 33);
                    break;
                default:
                    Player1.Location = new Point(663, 33);
                    break;

            }
        }
        public static void Player2Location(int Player2location, PictureBox Player2)
        {
            switch (Player2location)
            {
                case 0:
                    Player2.Location = new Point(36, 510+46);
                    break;
                case 1:
                    Player2.Location = new Point(129, 510 + 46);
                    break;
                case 2:
                    Player2.Location = new Point(216, 510 + 46);
                    break;
                case 3:
                    Player2.Location = new Point(306, 510 + 46);
                    break;
                case 4:
                    Player2.Location = new Point(394, 510 + 46);
                    break;
                case 5:
                    Player2.Location = new Point(483, 510 + 46);
                    break;
                case 6:
                    Player2.Location = new Point(572, 510 + 46);
                    break;
                case 7:
                    Player2.Location = new Point(663, 510 + 46);
                    break;
                case 8:
                    Player2.Location = new Point(663, 432 + 46);
                    break;
                case 9:
                    Player2.Location = new Point(572, 432 + 46);
                    break;
                case 10:
                    Player2.Location = new Point(483, 432 + 46);
                    break;
                case 11:
                    Player2.Location = new Point(394, 432 + 46);
                    break;
                case 12:
                    Player2.Location = new Point(306, 432 + 46);
                    break;
                case 13:
                    Player2.Location = new Point(216, 432 + 46);
                    break;
                case 14:
                    Player2.Location = new Point(129, 432 + 46);
                    break;
                case 15:
                    Player2.Location = new Point(36, 432 +46);
                    break;
                case 16:
                    Player2.Location = new Point(36, 353 + 46);
                    break;
                case 17:
                    Player2.Location = new Point(129, 353+ 46);
                    break;
                case 18:
                    Player2.Location = new Point(216, 353 + 46);
                    break;
                case 19:
                    Player2.Location = new Point(306, 353 + 46);
                    break;
                case 20:
                    Player2.Location = new Point(394, 353 + 46);
                    break;
                case 21:
                    Player2.Location = new Point(483, 353 + 46);
                    break;
                case 22:
                    Player2.Location = new Point(572, 353 + 46);
                    break;
                case 23:
                    Player2.Location = new Point(663, 353 + 46);
                    break;
                case 24:
                    Player2.Location = new Point(663, 272 + 46);
                    break;
                case 25:
                    Player2.Location = new Point(572, 272 + 46);
                    break;
                case 26:
                    Player2.Location = new Point(483, 272 + 46);
                    break;
                case 27:
                    Player2.Location = new Point(394, 272 + 46);
                    break;
                case 28:
                    Player2.Location = new Point(306, 272 + 46);
                    break;
                case 29:
                    Player2.Location = new Point(216, 272 + 46);
                    break;
                case 30:
                    Player2.Location = new Point(129, 272 + 46);
                    break;
                case 31:
                    Player2.Location = new Point(36, 272 + 46);
                    break;
                case 32:
                    Player2.Location = new Point(36, 193 + 46);
                    break;
                case 33:
                    Player2.Location = new Point(129, 193 + 46);
                    break;
                case 34:
                    Player2.Location = new Point(216, 193 + 46);
                    break;
                case 35:
                    Player2.Location = new Point(306, 193 + 46);
                    break;
                case 36:
                    Player2.Location = new Point(394, 193 + 46);
                    break;
                case 37:
                    Player2.Location = new Point(483, 193 + 46);
                    break;
                case 38:
                    Player2.Location = new Point(572, 193 + 46);
                    break;
                case 39:
                    Player2.Location = new Point(663, 193 + 46);
                    break;
                case 40:
                    Player2.Location = new Point(663, 113 + 46);
                    break;
                case 41:
                    Player2.Location = new Point(572, 113 + 46);
                    break;
                case 42:
                    Player2.Location = new Point(483, 113 + 46);
                    break;
                case 43:
                    Player2.Location = new Point(394, 113 + 46);
                    break;
                case 44:
                    Player2.Location = new Point(306, 113 + 46);
                    break;
                case 45:
                    Player2.Location = new Point(216, 113 + 46);
                    break;
                case 46:
                    Player2.Location = new Point(129, 113 + 46);
                    break;
                case 47:
                    Player2.Location = new Point(36, 113 + 46);
                    break;
                case 48:
                    Player2.Location = new Point(36, 33 + 46);
                    break;
                case 49:
                    Player2.Location = new Point(129, 33 + 46);
                    break;
                case 50:
                    Player2.Location = new Point(216, 33 + 46);
                    break;
                case 51:
                    Player2.Location = new Point(306, 33 + 46);
                    break;
                case 52:
                    Player2.Location = new Point(394, 33 + 46);
                    break;
                case 53:
                    Player2.Location = new Point(483, 33 + 46);
                    break;
                case 54:
                    Player2.Location = new Point(572, 33 + 46);
                    break;
                case 55:
                    Player2.Location = new Point(663, 33 + 46);
                    break;
                default:
                    Player2.Location = new Point(663, 33 + 46);
                    break;

            }
        }
    }
}
