using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Template_Method
{
    public abstract class Game
    {
        public Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }
        public void Run()
        {
            Start();
            while (!HaveWinner)
            {
                TakeTurn(); 
            }
            Console.WriteLine($"Player {WinningPlayer} wins");
        }

        protected int currentPlayer;
        protected readonly int numberOfPlayers;
        protected abstract bool HaveWinner { get; }
        protected abstract int WinningPlayer { get; }
        protected abstract void TakeTurn(); 
        protected abstract void Start();
    }
}
