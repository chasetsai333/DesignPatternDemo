using Structural_Pattern.Composite_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structural_Pattern.Composite_Pattern.Nodes
{
    class CompositeMenu : MenuComponent
    {
        private List<MenuComponent> menus = new List<MenuComponent>();

        public CompositeMenu(string name) 
            : base(name) { }

        public void Add(MenuComponent menu)
        {
            menus.Add(menu);
        }

        public void Remove(MenuComponent menu)
        {
            menus.Remove(menu);
        }

        public override void Print(int dept)
        {
            Console.WriteLine($"{new String('-', dept)}{name}");
            if (menus.Any())
            {
                menus.ForEach(menu =>
                {
                    menu.Print(dept+1);
                });
            }
        }
    }
}
