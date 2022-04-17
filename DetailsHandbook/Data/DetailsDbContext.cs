global using Details;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsHandbook
{
    public class DetailsDbContext : DbContext
    {
        public DbSet<AlternateResistor> AlternateResistors { get; set; }
        public DbSet<AnalogMicrocircuit> AnalogMicrocircuits { get; set; }
        public DbSet<CeramicCapacitor> CeramicCapacitors { get; set; }
        public DbSet<ComputerSystem> ComputerSystems { get; set; }
        public DbSet<ConstantResistor> ConstantResistor { get; set; }
        public DbSet<ElectrolyticCapacitor> ElectrolyticCapacitors { get; set; }
        public DbSet<HighFreqConnector> HighFreqConnector { get; set; }
        public DbSet<HighFreqDiode> HighFreqDiodes { get; set; }
        public DbSet<Inductance> Inductances { get; set; }
        public DbSet<LightDiode> LightDiodes { get; set; }
        public DbSet<LogicMicrocircuit> LogicMicrocircuits { get; set; }
        public DbSet<LowFreqConnector> LowFreqConnectors { get; set; }
        public DbSet<MembraneCapacitor> MembraneCapacitors { get; set; }
        public DbSet<RectifyingDiode> RectifyingDiodes { get; set; }
        public DbSet<Relay> Relays { get; set; }
        public DbSet<Switcher> Switchers { get; set; }
        public DbSet<Thyristor> Thyristors { get; set; }
        public DbSet<Transistor> Transistors { get; set; }
        public DbSet<ZenerDiode> ZenerDiodes { get; set; }

        public List<Detail> GetData()
        {
            List<Detail> data = new List<Detail>();
            data.AddRange(AlternateResistors.ToList());
            data.AddRange(AnalogMicrocircuits.ToList());
            data.AddRange(CeramicCapacitors.ToList());
            data.AddRange(ComputerSystems.ToList());
            data.AddRange(ConstantResistor.ToList());
            data.AddRange(ElectrolyticCapacitors.ToList());
            data.AddRange(HighFreqConnector.ToList());
            data.AddRange(HighFreqDiodes.ToList());
            data.AddRange(Inductances.ToList());
            data.AddRange(LightDiodes.ToList());
            data.AddRange(LogicMicrocircuits.ToList());
            data.AddRange(LowFreqConnectors.ToList());
            data.AddRange(MembraneCapacitors.ToList());
            data.AddRange(RectifyingDiodes.ToList());
            data.AddRange(Relays.ToList());
            data.AddRange(Switchers.ToList());
            data.AddRange(Thyristors.ToList());
            data.AddRange(Transistors.ToList());
            data.AddRange(ZenerDiodes.ToList());
            return data;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder opt) 
            => opt.UseSqlite("Data Source= Detailsdata.db");
 
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
