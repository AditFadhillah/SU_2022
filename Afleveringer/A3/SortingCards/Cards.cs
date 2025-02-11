using System;

namespace SortingCards;

public class Card : IComparable<Card> {
    public int rank = 0;
    public int suit = 0;

    public Card(int rank, int suit) {
        this.rank = rank;
        this.suit = suit;
    }

    public int CompareTo(Card c) {
        if (c.suit != this.suit) { //Checks suits are not the same
            return this.suit.CompareTo(c.suit);
        }
        else if (c.suit == this.suit) { //If suits are the same
            return this.rank.CompareTo(c.rank);
        }
        else {
            return 0;
        }
    }

    public override string ToString() {
        return $"{this.rank}, {this.suit}";
    }
}