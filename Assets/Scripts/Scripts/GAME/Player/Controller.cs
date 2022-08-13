using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Game.Player
{
    /// <summary>
    /// Main controller of the Player.
    /// </summary>
    public class Controller : MonoBehaviour
    {
        //Data
        public Equipment equipment = new Equipment();
        public Value money = new Value(1500);
        public Value health = new Value(100);

        //View
        [SerializeField] private Material material;
        [SerializeField] private TextMeshProUGUI healthView;

        private void Start()
        {
            StartCoroutine(Second());
        }

        private void Update()
        {
            material.color = Color.Lerp(material.color, Color.white, 1 * Time.deltaTime);
        }

        IEnumerator Second()
        {
            while (true)
            {
                healthView.text = health.ToString();
                yield return new WaitForSeconds(1);
                //Tick tock.
                health.value -= 1;
                material.color = Color.red;
            }
        }
    }

    /// <summary>
    /// User Equipment Data ( Serialized in JSON )
    /// </summary>
    [System.Serializable]
    public class Equipment
    {
        public List<ItemData> items = new List<ItemData>();

        [System.Serializable]
        public class ItemData
        {
            public int id;    /// Item config id.
            public int count;    /// Item count.
        }

        /// <summary>
        /// Returns total amount of the items;
        /// </summary>
        /// <returns></returns>
        public int totalItemsCount()
        {
            int count = 0;

            foreach (var item in items)
            {
                count += item.count;
            }

            return count;
        }
    }
}