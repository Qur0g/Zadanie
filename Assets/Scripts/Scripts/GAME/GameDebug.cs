using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    /// <summary>
    /// Class used for dislaying user debug.
    /// </summary>
    public class GameDebug : MonoBehaviour
    {
        void Start()
        {
            DebugPlayer();
            DebugConfig();

            Manager.player.health.OnUpdate += DebugPlayer;
            Manager.player.money.OnUpdate += DebugPlayer;
        }

        void DebugPlayer(int value = 0)
        {
            //Here we gonna Debug all Player data.
            Debug.LogFormat("health {0}", Manager.player.health);
            Debug.LogFormat("money {0}", Manager.player.money);
            Debug.LogFormat("items count {0}", Manager.player.equipment.totalItemsCount());
        }

        void DebugConfig()
        {
            Debug.LogFormat("items config {0}", Manager.Instance.config.items.Count);
        }
    }

}