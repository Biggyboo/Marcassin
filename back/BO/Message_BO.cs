﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Message_BO
    {
        public int id_Message { get; set; }
        public string Contenu { get; set; }
        public List<Utilisateur_BO> id_Sources { get; set; }
        public List<Room_BO> id_Rooms { get; set; }
        public DateTime Date_ajout { get; set; }
    }
}
