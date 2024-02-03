using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Tool: Collectable
    {
        protected Tool(String description) {
            Description = description;

        }
        public abstract void DoAction();
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine( $"{Description} Collected, Congrats!!!!");
            DoAction();
        }
    }
}
