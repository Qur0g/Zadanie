using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    /// <summary>
    /// Here we store all game config.
    /// </summary>
    [System.Serializable]
    public class Config
    {
        [SerializeField]
        //GameItems
        public List<Item> items = new List<Item>();
    }

    /// <summary>
    /// Class which represents ItemConfig
    /// </summary>
    [System.Serializable]
    public class Item
    {
        public int id;
        public string name;
        public int price;
        public Sprite icon;
    }
}