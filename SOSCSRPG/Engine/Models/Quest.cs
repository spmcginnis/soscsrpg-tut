﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        
        public List<ItemQuantity> ItemsToComplete { get; set; }

        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }

        public Quest(int id, string name, string desc, List<ItemQuantity> itemsToComplete, int rewardXP, int rewardGold, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Desc = desc;
            ItemsToComplete = itemsToComplete;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
