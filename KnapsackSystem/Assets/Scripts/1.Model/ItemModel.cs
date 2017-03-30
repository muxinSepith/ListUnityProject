using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemModel
{
    private static Dictionary<string, Item> GridItem = new Dictionary<string, Item>();


    //存储
    public static void StoreItem(string name, Item item)
    {
        if (GridItem.ContainsKey(name))
            DeleteItem(name);

        GridItem.Add(name, item);
    }

    //取出
    public static Item GetItem(string name)
    {
        if (GridItem.ContainsKey(name))
        {
            return GridItem[name];
        }
        else
            return null;
    }

    //删除
    public static void DeleteItem(string name)
    {
        if (GridItem.ContainsKey(name))
            GridItem.Remove(name);
    }
}
