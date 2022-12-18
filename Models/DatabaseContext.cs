using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebTransaction.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcsTransactionCarIn> AcsTransactionCarIns { get; set; } = null!;
        public virtual DbSet<AcsTransactionCarOut> AcsTransactionCarOuts { get; set; } = null!;
        public virtual DbSet<AcsTransactionMotorIn> AcsTransactionMotorIns { get; set; } = null!;
        public virtual DbSet<AcsTransactionMotorOut> AcsTransactionMotorOuts { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcsTransactionCarIn>(entity =>
            {
                entity.ToTable("ACS_Transaction_Car_In");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Card_ID");

                entity.Property(e => e.CardTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardType_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnName("Create_Date");

                entity.Property(e => e.CreateUid)
                    .HasMaxLength(50)
                    .HasColumnName("Create_UID");

                entity.Property(e => e.LaneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lane_ID");

                entity.Property(e => e.LaneImage).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Partner_ID");

                entity.Property(e => e.Plate).HasMaxLength(50);

                entity.Property(e => e.PlateHk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_HK");

                entity.Property(e => e.PlateImage).HasMaxLength(200);

                entity.Property(e => e.PlateO)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_O");

                entity.Property(e => e.ProcessDate).HasColumnType("date");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_ID");

                entity.Property(e => e.StationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Station_ID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_ID");

                entity.Property(e => e.VehicleTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleType_ID");

                entity.Property(e => e.WriteDate).HasColumnName("Write_Date");

                entity.Property(e => e.WriteUid)
                    .HasMaxLength(50)
                    .HasColumnName("Write_UID");
            });

            modelBuilder.Entity<AcsTransactionCarOut>(entity =>
            {
                entity.ToTable("ACS_Transaction_Car_Out");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Card_ID");

                entity.Property(e => e.CardTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardType_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnName("Create_Date");

                entity.Property(e => e.CreateUid)
                    .HasMaxLength(50)
                    .HasColumnName("Create_UID");

                entity.Property(e => e.FormNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LaneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lane_ID");

                entity.Property(e => e.LaneIdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lane_ID_In");

                entity.Property(e => e.LaneImage).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Partner_ID");

                entity.Property(e => e.Plate).HasMaxLength(50);

                entity.Property(e => e.PlateHk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_HK");

                entity.Property(e => e.PlateImage).HasMaxLength(200);

                entity.Property(e => e.PlateO)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_O");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcessDate).HasColumnType("date");

                entity.Property(e => e.Serial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_ID");

                entity.Property(e => e.StationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Station_ID");

                entity.Property(e => e.StationIdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Station_ID_In");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDateIn)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_Date_In");

                entity.Property(e => e.TransactionIdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction_ID_In");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_ID");

                entity.Property(e => e.VehicleTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleType_ID");

                entity.Property(e => e.WriteDate).HasColumnName("Write_Date");

                entity.Property(e => e.WriteUid)
                    .HasMaxLength(50)
                    .HasColumnName("Write_UID");
            });

            modelBuilder.Entity<AcsTransactionMotorIn>(entity =>
            {
                entity.ToTable("ACS_Transaction_Motor_In");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Card_ID");

                entity.Property(e => e.CardTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardType_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnName("Create_Date");

                entity.Property(e => e.CreateUid)
                    .HasMaxLength(50)
                    .HasColumnName("Create_UID");

                entity.Property(e => e.LaneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lane_ID");

                entity.Property(e => e.LaneImage).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Partner_ID");

                entity.Property(e => e.Plate).HasMaxLength(50);

                entity.Property(e => e.PlateHk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_HK");

                entity.Property(e => e.PlateImage).HasMaxLength(200);

                entity.Property(e => e.PlateO)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_O");

                entity.Property(e => e.ProcessDate).HasColumnType("date");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_ID");

                entity.Property(e => e.StationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Station_ID");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_ID");

                entity.Property(e => e.VehicleTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleType_ID");

                entity.Property(e => e.WriteDate).HasColumnName("Write_Date");

                entity.Property(e => e.WriteUid)
                    .HasMaxLength(50)
                    .HasColumnName("Write_UID");
            });

            modelBuilder.Entity<AcsTransactionMotorOut>(entity =>
            {
                entity.ToTable("ACS_Transaction_Motor_Out");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Card_ID");

                entity.Property(e => e.CardTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardType_ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnName("Create_Date");

                entity.Property(e => e.CreateUid)
                    .HasMaxLength(50)
                    .HasColumnName("Create_UID");

                entity.Property(e => e.FormNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LaneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lane_ID");

                entity.Property(e => e.LaneIdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lane_ID_In");

                entity.Property(e => e.LaneImage).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Partner_ID");

                entity.Property(e => e.Plate).HasMaxLength(50);

                entity.Property(e => e.PlateHk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_HK");

                entity.Property(e => e.PlateImage).HasMaxLength(200);

                entity.Property(e => e.PlateO)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plate_O");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProcessDate).HasColumnType("date");

                entity.Property(e => e.Serial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_ID");

                entity.Property(e => e.StationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Station_ID");

                entity.Property(e => e.StationIdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Station_ID_In");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDateIn)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_Date_In");

                entity.Property(e => e.TransactionIdIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction_ID_In");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_ID");

                entity.Property(e => e.VehicleTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VehicleType_ID");

                entity.Property(e => e.WriteDate).HasColumnName("Write_Date");

                entity.Property(e => e.WriteUid)
                    .HasMaxLength(50)
                    .HasColumnName("Write_UID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
