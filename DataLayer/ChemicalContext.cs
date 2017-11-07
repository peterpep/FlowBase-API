﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowBaseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowBaseAPI.DataLayer
{
    public class ChemicalContext : DbContext
    {
        public ChemicalContext(DbContextOptions<ChemicalContext> options) : base(options)
        {
        }

        public DbSet<Chemical> Chemicals { get; set; }
    }
}