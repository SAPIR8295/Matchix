﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleProject.Shared.Models.Matchix;

namespace TriangleProject.Shared.Models.Unity
{
    public class GameForUnity
    {
  
        public string GameName { get; set; }
        public double GameTime { get; set; }
        public List <Pairs> PairList { get; set; }
    }
}
