using Structural_Pattern.Composite_Pattern.Abstracts;
using Structural_Pattern.Composite_Pattern.Leafs;
using Structural_Pattern.Composite_Pattern.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Composite_Pattern
{
    class Composite
    {
        /// <summary>
        /// 組合模式 (Composite Pattern)：數個物件之間，呈現一種樹狀結構。物件之間可以組合。
        /// </summary>
        public void Go()
        {
            CompositeMenu menu = new CompositeMenu("分類");

            CompositeMenu menuA = new CompositeMenu("A品牌");
            menuA.Add(new LeafMenuPhone("5.8吋手機"));
            menuA.Add(new LeafMenuNotebook("13吋筆電"));
            menuA.Add(new LeafMenuNotebook("15吋筆電"));

            CompositeMenu menuB = new CompositeMenu("B品牌");
            menuB.Add(new LeafMenuPhone("6吋手機"));
            menuB.Add(new LeafMenuNotebook("14吋筆電"));
            menuB.Add(new LeafMenuNotebook("16吋筆電"));

            CompositeMenu menuSale = new CompositeMenu("特價區");
            CompositeMenu menuA2 = new CompositeMenu("A品牌");
            menuA2.Add(new LeafMenuPhone("超值5.8吋手機"));
            menuA2.Add(new LeafMenuNotebook("超值13吋筆電"));
            menuA2.Add(new LeafMenuNotebook("超值15吋筆電"));
            menuA2.Add(new LeafMenuNotebook("20吋筆電"));
            menuA2.Remove(new LeafMenuNotebook("20吋筆電"));
            menuSale.Add(menuA2);

            menu.Add(menuA);
            menu.Add(menuB);
            menu.Add(menuSale);
            menu.Print(0);
        }
    }
}
