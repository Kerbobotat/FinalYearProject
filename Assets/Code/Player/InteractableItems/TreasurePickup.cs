﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Player;
using UnityEngine;
using Assets.Code.Player;

namespace Player.InteractableItems
{
    public class TreasurePickup : InteractableItem, IInteractable
    {
        public int Value = 0;
        private void Awake()
        {
            this.Name = "Gold";
            this.Info = "As much gold as you can eat.";
        }

        public void Consume(GameObject obj)
        {
            var player = PlayerData.GetSharedInstance();
            player.Gold += Value;
            Destroy(this.gameObject);
        }
    }
}
