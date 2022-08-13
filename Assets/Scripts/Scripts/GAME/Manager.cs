using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    /// <summary>
    /// Main manager of the game.
    /// </summary>
    public class Manager : MonoBehaviour
    {
        private static Manager _instance;
        [SerializeField] private Player.Controller _player;

        public UI.GameUI ui;
        public Config config = new Config();

        public static Manager Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Game main player.
        /// </summary>
        public static Player.Controller player
        {
            get
            {
                return Instance._player;
            }
        }

        private void Awake()
        {
            _instance = this;
        }
    }
}
