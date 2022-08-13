using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ViewController : MonoBehaviour
    {
        [SerializeField] private Text header;
        [SerializeField] protected RectTransform content;

        public virtual string headerText
        {
            get
            {
                return "";
            }
        }

        public virtual void Start()
        {
            header.text = headerText;
        }

        public void Close()
        {
            Destroy(gameObject);
        }
    }
}
