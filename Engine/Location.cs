﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
  public  class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAivaibleHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAivaibleHere = questAivaibleHere;
            MonsterLivingHere = monsterLivingHere;
        }

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAivaibleHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }



    }
}
