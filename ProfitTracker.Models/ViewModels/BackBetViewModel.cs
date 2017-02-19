﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitTracker.Models.ViewModels
{
    public class BackBetViewModel
    {
        public int Id { get; set; }
        public IEnumerable<BookmakerViewModel> Bookmakers { get; set; }
        public double Stake { get; set; }
        public double Odds { get; set; }
        public int BookmakerId { get; set; }
    }
}