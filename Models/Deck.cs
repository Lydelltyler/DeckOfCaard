using System;
using System.Collections.Generic;

namespace ThirdOOP.Models {
    public class Deck {

        string[] stringCards = new string[] {
            "Ace",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King"
        };

        string[] suits = new string[] {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"
        };

        public List<Card> Cards = new List<Card> ();

        public Deck () {
            Console.WriteLine("**********We have a new Deck!***********");
            foreach (string suit in suits) {
                int val = 1;
                foreach (string stringVal in stringCards) {
                    Card newCard = new Card (stringVal, suit, val);
                    Cards.Add (newCard);
                    val++;
                }
            }
        }

        public Card Deal () {
            Console.WriteLine("**********Dealing Card***********");
            Card cardDealt = Cards[0];
            Cards.Remove (cardDealt);
            return cardDealt;
        }

        public void Reset () {
            Cards.Clear ();
            Console.WriteLine("**********Reseting Cards***********");
            foreach (string suit in suits) {
                int val = 1;
                foreach (string stringVal in stringCards) {
                    Card newCard = new Card (stringVal, suit, val);
                    Cards.Add (newCard);
                    val++;
                }
            }
        }

        public void Shuffle () {
            Console.WriteLine("**********Shuffling Cards***********");
            for (int i = 0; i < 52; i++) {
                Card temp = Cards[i];
                Cards[i] = Cards[i + 1];
                Cards[i + 1] = temp;
            }
        }

        public void ListCards () {
            Console.WriteLine("**********Revealing Deck***********");
            foreach (Card card in Cards) {
                Console.WriteLine ($"{card.StringVal} of {card.Suit}");
            }
        }

    }
}