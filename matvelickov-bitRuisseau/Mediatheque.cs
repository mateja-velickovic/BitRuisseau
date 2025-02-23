﻿using bit_ruisseau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bit_ruisseau
{
    public class Mediatheque
    {
        public Mediatheque()
        {
            IsAvailable = false;
            Medias = new List<Media>();
        }

        public Mediatheque(string displayName)
        {
            DisplayName = displayName;
        }

        public bool IsAvailable { get; set; }
        public string DisplayName { get; init; }

        public List<Media> Medias { get; set; }
    }
}