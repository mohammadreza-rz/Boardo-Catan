﻿using System;

namespace Model
{
    [Serializable]
    public class Personal
    {
        public int id;
        public int point;
        public int brick_count;
        public int stone_count;
        public int wood_count;
        public int wheat_count;
        public int monopoly_count;
        public int road_building_count;
        public int year_of_plenty;
        public int victory_point;
        public int knight;
        public int knight_card_played;
        public int thief_tile;
        public int catan_event;
        public int player;
        public bool has_long_road_card;
        public bool has_largest_army;
    }
}