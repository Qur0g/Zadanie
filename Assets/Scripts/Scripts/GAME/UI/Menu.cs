using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Game.UI
{
    public class Menu : MonoBehaviour
    {
        public void Shop()
        {
            Manager.Instance.ui.Show<Shop>();
        }

        public void Equipment()
        {
            Manager.Instance.ui.Show<EQ>();
            //TODO: Open Eq Screen here.
        }
    }
}
