using OOP_2;
using System.Data.Entity;

public class DeviceContext : DbContext
{
    // Таблицы для каждого типа оборудования
    public DbSet<DJEquipment> DJEquipments { get; set; }
    public DbSet<Mixer> Mixers { get; set; }
    public DbSet<Player> Players { get; set; }

    public DeviceContext() : base("name=DJEquipmentDB") { }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Таблица для базового класса DJEquipment
        modelBuilder.Entity<DJEquipment>().ToTable("DJEquipments");

        // Указываем таблицы для производных классов
        modelBuilder.Entity<Mixer>().ToTable("Mixers");
        modelBuilder.Entity<Player>().ToTable("Players");
   
    }
}
