using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;

namespace RecordShop.Data;

public partial class VinylRecordsContext : DbContext
{
    public VinylRecordsContext()
    {
    }

    public VinylRecordsContext(DbContextOptions<VinylRecordsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Band> Bands { get; set; }

    public virtual DbSet<Buyer> Buyers { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleDetail> SaleDetails { get; set; }

    public virtual DbSet<Seller> Sellers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vinyl> Vinyls { get; set; }

    public virtual DbSet<VinylForDiscount> VinylForDiscounts { get; set; }

	// procedure 

	public DbSet<OrderDetailByBuyerId> OrderDetailByBuyers { get; set; }


	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-TEEQPNH;Initial Catalog=VinylRecords;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Band>(entity =>
        {
            entity.HasKey(e => e.BandId).HasName("PK__Band__A03693A8A0E6EE70");

            entity.ToTable("Band");

            entity.Property(e => e.BandId).ValueGeneratedNever();
            entity.Property(e => e.BandName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.Genre).WithMany(p => p.Bands)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("FK__Band__GenreId__3B75D760");
        });

        modelBuilder.Entity<Buyer>(entity =>
        {
            entity.HasKey(e => e.BuyerId).HasName("PK__Buyer__4B81C62A85753BF4");

            entity.ToTable("Buyer");

            entity.Property(e => e.BuyerId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BuyerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK__Genre__0385057E7DC4D7E9");

            entity.ToTable("Genre");

            entity.Property(e => e.GenreId).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.GenreName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PK__Publishe__4C657FAB77A47D9A");

            entity.ToTable("Publisher");

            entity.Property(e => e.PublisherId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contact)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PK__Sale__1EE3C3FFBFD42E75");

            entity.ToTable("Sale");

            entity.Property(e => e.SaleId).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.Buyer).WithMany(p => p.Sales)
                .HasForeignKey(d => d.BuyerId)
                .HasConstraintName("FK__Sale__BuyerId__4BAC3F29");

            entity.HasOne(d => d.Seller).WithMany(p => p.Sales)
                .HasForeignKey(d => d.SellerId)
                .HasConstraintName("FK__Sale__SellerId__4AB81AF0");
        });

        modelBuilder.Entity<SaleDetail>(entity =>
        {
            entity.HasKey(e => e.SaleDetailId).HasName("PK__SaleDeta__70DB14FEF14198AA");

            entity.ToTable("SaleDetail");

            entity.Property(e => e.SaleDetailId).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.Sale).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.SaleId)
                .HasConstraintName("FK__SaleDetai__SaleI__4E88ABD4");

            entity.HasOne(d => d.Vinyl).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.VinylId)
                .HasConstraintName("FK__SaleDetai__Vinyl__4F7CD00D");
        });

        modelBuilder.Entity<Seller>(entity =>
        {
            entity.HasKey(e => e.SellerId).HasName("PK__Seller__7FE3DB8132E57C05");

            entity.ToTable("Seller");

            entity.Property(e => e.SellerId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SellerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CD30348B1");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updated).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vinyl>(entity =>
        {
            entity.HasKey(e => e.VinylId).HasName("PK__Vinyl__52D1755795B2D11D");

            entity.ToTable("Vinyl");

            entity.Property(e => e.VinylId).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.DateOfPublishing).HasColumnType("datetime");
            entity.Property(e => e.Updated).HasColumnType("datetime");
            entity.Property(e => e.VinylName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Band).WithMany(p => p.Vinyls)
                .HasForeignKey(d => d.BandId)
                .HasConstraintName("FK__Vinyl__BandId__403A8C7D");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Vinyls)
                .HasForeignKey(d => d.PublisherId)
                .HasConstraintName("FK__Vinyl__Publisher__412EB0B6");
        });

        modelBuilder.Entity<VinylForDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VinylFor__3214EC07D5F9DEDF");

            entity.ToTable("VinylForDiscount");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.DiscountDate).HasColumnType("datetime");
            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.Vinyl).WithMany(p => p.VinylForDiscounts)
                .HasForeignKey(d => d.VinylId)
                .HasConstraintName("FK__VinylForD__Vinyl__440B1D61");
        });

        // create procedure

        modelBuilder.Entity<OrderDetailByBuyerId>().HasNoKey();

        OnModelCreatingPartial(modelBuilder);
    }

     // add procedure
    public List<OrderDetailByBuyerId> GetOrderDetailByBuyersId(int BuyerId)
    {
        SqlParameter parameter = new SqlParameter("@BuyerId", BuyerId);
        return OrderDetailByBuyers.FromSqlRaw("EXEC GetOrderDetailByBuyerId @BuyerId", parameter).ToList();
	}

	public int ProInsertOrder(int saleId, string sellerName, string buyerName, float amount, float paid, float remain)
	{
		var idParam = new SqlParameter
		{
			ParameterName = "@Id",
			SqlDbType = SqlDbType.Int,
			Direction = ParameterDirection.Output
		};

		 Database.ExecuteSqlRaw
         (
			"EXEC InsertOrderReturn @SaleId, @SellerName, @BuyerName, @Amount, @Paid, @Remain, @Id OUTPUT",
			new SqlParameter("@SaleId", saleId),
			new SqlParameter("@SellerName", sellerName),
			new SqlParameter("@BuyerName", buyerName),
			new SqlParameter("@Amount", amount),
			new SqlParameter("@Paid", paid),
			new SqlParameter("@Remain", remain),
			idParam
	     );

		return (int)idParam.Value;
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
