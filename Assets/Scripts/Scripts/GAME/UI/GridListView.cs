using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using UnityEngine.UI;

namespace Game.UI
{
    /// <summary>
    /// Displays Items in grid style.
    /// </summary>
    /// <typeparam name="T">Item with icon and id.</typeparam>
    public class GridListViewController<T> : ViewController where T : Item
    {
        private Object cellPrefab;

        public override void Start()
        {
            base.Start();
            content.gameObject.AddComponent<GridLayoutGroup>();
            cellPrefab = Resources.Load("UI/Prefabs/Cell");
            Build();
        }

        /// <summary>
        /// Builds Cell from the item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual Button cell(T item)
        {
            Button btn = (Instantiate(cellPrefab, content) as GameObject).GetComponent<Button>();
            btn.onClick.AddListener(delegate
            {
                OnCellClick(item);
            });

            btn.image.sprite = item.icon;
            btn.GetComponentInChildren<Text>().text = item.name;
            return btn;
        }

        private void Build()
        {
            foreach (var item in data)
            {
                cell(item);
            }
        }

        /// <summary>
        /// Data displayed on grid.
        /// </summary>
        public virtual List<T> data
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Called when cell is clicked.
        /// </summary>
        /// <param name="item"></param>
        public virtual void OnCellClick(T item) { }

    }
}