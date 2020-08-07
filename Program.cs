using System;
using ThirdOOP.Models;

namespace ThirdOOP {
    class Program {
        static void Main (string[] args) {
            Deck newDeck = new Deck ();
            // newDeck.ListCards ();
            Player player1 = new Player ("Lydell");
            player1.Draw (newDeck, "Lydell");
            newDeck.Shuffle ();
            player1.Draw (newDeck, "Lydell");
            player1.Draw (newDeck, "Lydell");
            player1.Draw (newDeck, "Lydell");
            player1.Draw (newDeck, "Lydell");
            player1.ViewHand();
        }
    }
}