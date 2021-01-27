﻿using System;
using System.Collections.Generic;

namespace MOBA_Manager.DataModel
{
    public class Team
    {
        private int _reputation;
        private List<Player> _roster;
        private String _teamName;

        public String GetTeamName()
        {
            return this._teamName;
        }

        public void SetTeamName(String name)
        {
            this._teamName = name;
        }
    }
}