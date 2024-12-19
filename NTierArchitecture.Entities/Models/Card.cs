using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NTierArchitecture.Entities.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public List<CardItem> CardItems { get; set; } = new();

        public void AddItem(CardItem item)
        {
            var p = CardItems.FirstOrDefault(x => x.ProductID == item.ProductID);

            if (p != null)
            {
                //adet guncelle
                p.Quantity += item.Quantity;
            }
            else
            {
                //ekleme yap
                CardItems.Add(item);
            }
        }

        public void DeleteItem(Guid cartItemID)
        {
            CardItem? c = CardItems.FirstOrDefault(item => item.CardItemID == cartItemID);

            if (c != null)
            {
                c.Quantity -= 1;
            }

            if (c.Quantity == 0)
            {
                CardItems.Remove(c);
            }
        }
    }
}
