using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACG
{
    interface ICardControl<T>
    {
        void DisplayCard(T card);

        void Flip();

        void Display();
    }
}
