using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACG
{
    public enum SerialType
    {
        RiseOfTheRunelords
    };

    public enum ProductType
    {
        BasicSet,
        CharacterAddOn,
        Deck1,
        Deck2,
        Deck3,
        Deck4,
        Deck5,
        Deck6,
    }
    public enum CardType
    {
        AdventurePath,
        Adventure,
        Ally,
        Armor,
        Blessing,
        Character,
        Item,
        Location,
        Monster,
        Scenario,
        Spell,
        Weapon
    };

    public abstract class Card
    {
        public string Name
        {
            get;
            set;
        }

        private CardType _Type;
        public CardType Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        public SerialType Serial
        {
            get;
            set;
        }

        public ProductType Product
        {
            get;
            set;
        }
    }

}
