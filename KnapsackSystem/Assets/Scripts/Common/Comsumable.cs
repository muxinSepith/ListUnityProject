using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Comsumable : Item
{

    public int BackHP { get; private set; }
    public int BackMP { get; private set; }


    public Comsumable(int id, string name, string description, int buyprice, int sellprice, string icon, int backhp, int backmp)
        : base(id, name, description, buyprice, sellprice, icon)
    {
        this.BackHP = backhp;
        this.BackMP = backmp;
        base.ItemType = ItemType.Comsumable;
    }
}
