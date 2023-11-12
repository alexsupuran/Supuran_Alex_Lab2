﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supuran_Alex_Lab2.Models;

namespace Supuran_Alex_Lab2.Data
{
    public class Supuran_Alex_Lab2Context : DbContext
    {
        public Supuran_Alex_Lab2Context (DbContextOptions<Supuran_Alex_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Supuran_Alex_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Supuran_Alex_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Supuran_Alex_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Supuran_Alex_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Supuran_Alex_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Supuran_Alex_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
