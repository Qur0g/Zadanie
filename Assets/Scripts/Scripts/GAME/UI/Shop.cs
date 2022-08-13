using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using UnityEngine.UI;
using TMPro;

namespace Game.UI
{
    /// <summary>
    /// ViewController of the Shop. Should contain view and basic mechanics of the shop.
    /// </summary>
    public class Shop : GridListViewController<Item>
    {
        private TextMeshProUGUI moneyView;

        public override string headerText => "Buy Items";

        /// <summary>
        /// All items from config.
        /// </summary>
        public override List<Item> data => Manager.Instance.config.items;

        /// <summary>
        /// When Cell is clicked.
        /// </summary>
        /// <param name="item"></param>
        public override void OnCellClick(Item item)
        {           
            Debug.Log("Taks for you");
           
            Manager.player.money -= item.price;
            moneyView = GameObject.Find("Money").GetComponent<TextMeshProUGUI>();
            moneyView.text = Manager.player.money.ToString();

            AddToEq(item);
            ///TODO:1. Take Money from player.
            ///TODO:2. Give player the item.
        }

        private void AddToEq(Item item)
        {
            bool isItem = false;

            for (int i = 0; i < Manager.player.equipment.items.Count; i++)
            {
                if (item.id == Manager.player.equipment.items[i].id)
                {                   
                    isItem = true;
                    Manager.player.equipment.items[i].count++;
                }
            }

            if (isItem == false)
            {
                Manager.player.equipment.items.Add(new Player.Equipment.ItemData()); 
                Manager.player.equipment.items[Manager.player.equipment.items.Count - 1].count++;
            }            
        }
    }
}