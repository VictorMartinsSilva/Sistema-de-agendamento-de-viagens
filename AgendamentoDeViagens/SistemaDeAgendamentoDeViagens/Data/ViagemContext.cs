﻿using Microsoft.EntityFrameworkCore;
using SistemaDeAgendamentoDeViagens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeAgendamentoDeViagens.Data
{
    public class ViagemContext:DbContext
    {
        public ViagemContext(DbContextOptions<ViagemContext>options)
            :base(options)
        {

        }
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Voo> Voos { get; set; }
        public DbSet<Assento> Assentos { get; set; }
    }
}