using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;

namespace Game.UI
{
    public class GameUI : MonoBehaviour
    {
        public T Show<T>(string name = "") where T : ViewController
        {
            var obj = Resources.Load("UI/Prefabs/" + typeof(T).Name);
            if (obj != null)
            {
                return (Instantiate(obj, transform) as GameObject).GetComponent<T>();
            }
            else
            {
                throw new System.Exception("No Asset named " + typeof(T).Name);
            }
        }
    }
}