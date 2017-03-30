using UnityEngine;
using System.Collections;

/// <summary>
/// 所有物品的基类
/// </summary>
public class Item
{

    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int BuyPrice { get; private set; }
    public int SellPrice { get; private set; }
    public string Icon { get; private set; }
    public ItemType ItemType { get; protected set; }


    //构造函数
    public Item(int id, string name, string description, int buyprice, int sellprice, string icon)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.BuyPrice = buyprice;
        this.SellPrice = sellprice;
        this.Icon = icon;
    }

}

public enum ItemType
{
    Weapon,
    Comsumable,
    Armor
}
