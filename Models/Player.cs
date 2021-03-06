using System;
using System.Collections.Generic;

namespace ThirdOOP.Models {
    class Player {
        public string Name;
        private List<Card> Hand = new List<Card> ();
        public Player(string name)
        {
            Name = name;
            Console.WriteLine($"Welcome to the game {name}");
        }

        public Card Draw (Deck deck, string name) {
            Name = name;
            Card drawedCard = deck.Deal ();
            Console.WriteLine ($"{Name} drew {drawedCard.StringVal} of {drawedCard.Suit}");
            Hand.Add (drawedCard);
            return drawedCard;
        }

        public Card Discard (int index) {

            if (Hand[index] is object) {
                Card playersCard = Hand[index];
                Hand.Remove (playersCard);
                return playersCard;
            } else {
                Console.WriteLine ($"{Name} doesn't have {Hand[index].StringVal} of {Hand[index].Suit}");
                return null;
            }

        }

        public void ViewHand(){
            foreach(Card card in Hand){
                Console.WriteLine($"{Name} Has a {card.StringVal} of {card.Suit} in hand");
            }
        }

    }
}