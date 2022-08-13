using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using UnityEngine.UI;

namespace Game.UI
{
    public class EQ : GridListViewController<Item>
    {
        private Object cellPrefab;

        public override string headerText => "Equipment";

        public override List<Item> data => Manager.Instance.config.items;

        public List<Player.Equipment.ItemData> EqData => Manager.player.equipment.items;

        public override void Start()
        {
            base.Start();
            cellPrefab = Resources.Load("UI/Prefabs/Cell");
            Build();
        }

        public override Button cell(Item item)
        {
            return null;
        }
                  
        public Button EqCell(Player.Equipment.ItemData item)
        {
            Button btn = (Instantiate(cellPrefab, content) as GameObject).GetComponent<Button>();

            btn.image.sprite = data[item.id].icon;
            btn.GetComponentInChildren<Text>().text = data[item.id].name + " " + item.count.ToString();
            return btn;
        }

        private void Build()
        {
            foreach (var item in EqData)
            {
                EqCell(item);
            }
        }
    }
}