using System;

namespace Tic_Tac_Toe
{
    public enum Player { Noone = 0, Crosses, Circles }
    
    struct Square
    {
        public Player Owner { get; }

        public Square(Player owner)
        {
            this.Owner = owner;
        }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.Noone:
                    return ".";
                case Player.Crosses:
                    return "X";
                case Player.Circles:
                    return "O";
                default:
                    throw new Exception("Invalid state");
            }
        }
    }
}
