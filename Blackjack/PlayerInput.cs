using System;

namespace BlackJack
{
    public class PlayerInput
    {
        private string input;
        private void Ask()
        {
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
        }

        public int CollectInput()
        {
            Ask();
            var playerChosenInput = Console.ReadLine();
            return int.Parse(playerChosenInput);
        }
    }
}