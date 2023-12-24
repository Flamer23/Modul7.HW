using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    class CardCollection 
    {
        private Card[] collection;
        public CardCollection(Card[] collection)
        {
            this.collection = collection;
        }
        public CardCollection()
        {
            this.collection = null;
        }

        public void Add(Card card)
        {
            if (this.collection == null)
            {
                this.collection = new Card[] { card };
            }
            else
            {
                int temp = this.collection.Length;
                Card[] tempCollection = this.collection;
                this.collection = new Card[temp + 1];
                for (int i = 0; i < collection.Length - 1; i++)
                {
                    collection[i] = tempCollection[i];
                }
                this.collection[temp] = card;
            }
        }
        public Card this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }

        public static CardCollection operator +(CardCollection collection1, CardCollection collection2)
        {
            CardCollection cardCollection = new CardCollection();
            for (int i = 0; i < collection1.collection.Length; i++)
            {
                cardCollection.Add(collection1[i]);
            }
            for (int i = 0; i < collection2.collection.Length; i++)
            {
                cardCollection.Add(collection2[i]);
            }

            return cardCollection;
        }
    }
}
