using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AjaxWebDemo.Models1
{
    public partial class iSpan_ProjectContext : DbContext
    {
        public iSpan_ProjectContext()
        {
        }

        public iSpan_ProjectContext(DbContextOptions<iSpan_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdImg> AdImgs { get; set; } = null!;
        public virtual DbSet<BusinessImg> BusinessImgs { get; set; } = null!;
        public virtual DbSet<BusinessMember> BusinessMembers { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MenuDetail> MenuDetails { get; set; } = null!;
        public virtual DbSet<NormalMember> NormalMembers { get; set; } = null!;
        public virtual DbSet<OptionsToProduct> OptionsToProducts { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderSerialNumber> OrderSerialNumbers { get; set; } = null!;
        public virtual DbSet<PaymentTerm> PaymentTerms { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductImg> ProductImgs { get; set; } = null!;
        public virtual DbSet<ProductOption> ProductOptions { get; set; } = null!;
        public virtual DbSet<ProductOptionGroup> ProductOptionGroups { get; set; } = null!;
        public virtual DbSet<ViewOptionsToGroup> ViewOptionsToGroups { get; set; } = null!;
        public virtual DbSet<ViewOrderDetailNonOptionGroupName> ViewOrderDetailNonOptionGroupNames { get; set; } = null!;
        public virtual DbSet<ViewOrderDetailWithOptionGroupName> ViewOrderDetailWithOptionGroupNames { get; set; } = null!;
        public virtual DbSet<ViewShowProductList> ViewShowProductLists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=iSpan_Project;Integrated Security=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdImg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AdImg");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.Fid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fid");

                entity.Property(e => e.Hyperlink)
                    .HasMaxLength(50)
                    .HasColumnName("hyperlink");

                entity.Property(e => e.ImgName)
                    .HasMaxLength(50)
                    .HasColumnName("imgName");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");
            });

            modelBuilder.Entity<BusinessImg>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("BusinessImg");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.BannerImgPath1)
                    .HasMaxLength(50)
                    .HasColumnName("Banner_ImgPath_1")
                    .HasDefaultValueSql("(N'../../img/BusinessMember_Img/default_banner001.png')");

                entity.Property(e => e.BannerImgPath2)
                    .HasMaxLength(50)
                    .HasColumnName("Banner_ImgPath_2");

                entity.Property(e => e.BannerImgPath3)
                    .HasMaxLength(50)
                    .HasColumnName("Banner_ImgPath_3");

                entity.Property(e => e.LogoImgPath)
                    .HasMaxLength(50)
                    .HasColumnName("LOGO_ImgPath")
                    .HasDefaultValueSql("(N'../../img/default/BMember_Icon.png')");

                entity.Property(e => e.SighImgPath)
                    .HasMaxLength(50)
                    .HasColumnName("SIgh_ImgPath")
                    .HasDefaultValueSql("(N'../../img/BusinessMember_Img/default_sign001.png')");
            });

            modelBuilder.Entity<BusinessMember>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("BusinessMember");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CloseTime).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.DeliveryAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.OpenTime).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegisterTime).HasColumnType("datetime");

                entity.Property(e => e.ShopType).HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK_Menu_1");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.IsForSale)
                    .HasMaxLength(1)
                    .HasColumnName("isForSale");

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.MenuName).HasMaxLength(50);
            });

            modelBuilder.Entity<MenuDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MenuDetail");

                entity.Property(e => e.MenuFid).HasColumnName("Menu_fid");

                entity.Property(e => e.ProductFid).HasColumnName("Product_fid");
            });

            modelBuilder.Entity<NormalMember>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("NormalMember");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.AddressArea)
                    .HasMaxLength(50)
                    .HasColumnName("Address_Area");

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(50)
                    .HasColumnName("Address_City");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailCertified)
                    .HasColumnName("emailCertified")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.IsSuspension)
                    .HasColumnName("isSuspension")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.MemberPhotoFile)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'../../img/default/NMember_Icon.png')");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegisterTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OptionsToProduct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OptionGroupFid).HasColumnName("OptionGroup_fid");

                entity.Property(e => e.ProductFid).HasColumnName("Product_fid");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK_Order");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.BMemberName)
                    .HasMaxLength(50)
                    .HasColumnName("B_MemberName");

                entity.Property(e => e.BMemberPhone)
                    .HasMaxLength(50)
                    .HasColumnName("B_MemberPhone");

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.NFid).HasColumnName("N_fid");

                entity.Property(e => e.OrderISerialId)
                    .HasMaxLength(10)
                    .HasColumnName("OrderI_SerialID")
                    .HasDefaultValueSql("([dbo].[udf_get_serialno]())")
                    .IsFixedLength();

                entity.Property(e => e.OrderPrefix)
                    .HasMaxLength(3)
                    .HasColumnName("Order_Prefix")
                    .HasDefaultValueSql("(N'NP')");

                entity.Property(e => e.OrderState).HasMaxLength(20);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerm).HasMaxLength(20);

                entity.Property(e => e.PickUpDate).HasColumnType("date");

                entity.Property(e => e.PickUpPerson).HasMaxLength(50);

                entity.Property(e => e.PickUpPersonPhone)
                    .HasMaxLength(50)
                    .HasColumnName("PickUpPerson_Phone");

                entity.Property(e => e.PickUpType).HasMaxLength(20);

                entity.Property(e => e.PlasticBag).HasMaxLength(5);

                entity.Property(e => e.TaxIdnum)
                    .HasMaxLength(10)
                    .HasColumnName("TaxIDNum");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderDetail");

                entity.Property(e => e.OptionFid).HasColumnName("Option_fid");

                entity.Property(e => e.OptionGroupFid).HasColumnName("OptionGroup_fid");

                entity.Property(e => e.OrderFid).HasColumnName("Order_fid");

                entity.Property(e => e.ProductFid).HasColumnName("Product_fid");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<OrderSerialNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderSerialNumber");

                entity.Property(e => e.OrderISerialId)
                    .HasMaxLength(10)
                    .HasColumnName("OrderI_SerialID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PaymentTerm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payment_Term");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.PayAmountLimit)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PayAmount_Limit");

                entity.Property(e => e.PayTerm).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => new { e.BFid, e.ProductName });

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.CategoryFid).HasColumnName("Category_fid");

                entity.Property(e => e.Fid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fid");

                entity.Property(e => e.IsForSale).HasMaxLength(1);

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.MenuFid)
                    .HasMaxLength(50)
                    .HasColumnName("Menu_fid");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("ProductCategory");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductImg>(entity =>
            {
                entity.HasKey(e => e.Fid);

                entity.ToTable("ProductImg");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.ImgPath).HasMaxLength(50);

                entity.Property(e => e.ProductFid).HasColumnName("Product_fid");
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK_Option");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.OptionGroupFid).HasColumnName("OptionGroup_fid");

                entity.Property(e => e.OptionName).HasMaxLength(50);

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ProductOptionGroup>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("PK_OptionGroup");

                entity.ToTable("ProductOptionGroup");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'-')");

                entity.Property(e => e.OptionGroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewOptionsToGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OptionsToGroups");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.OptionGroupFid).HasColumnName("OptionGroup_fid");

                entity.Property(e => e.OptionGroupName).HasMaxLength(50);

                entity.Property(e => e.OptionName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewOrderDetailNonOptionGroupName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDetail_NonOptionGroupName");

                entity.Property(e => e.OrderFId).HasColumnName("Order_fID");

                entity.Property(e => e.ProductFId).HasColumnName("Product_fID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewOrderDetailWithOptionGroupName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrderDetail_with_OptionGroupName");

                entity.Property(e => e.OptionGroupName).HasMaxLength(50);

                entity.Property(e => e.OptionName).HasMaxLength(50);

                entity.Property(e => e.OrderFid).HasColumnName("Order_fid");

                entity.Property(e => e.ProductFid).HasColumnName("Product_fid");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ViewShowProductList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_showProductList");

                entity.Property(e => e.BFid).HasColumnName("B_fid");

                entity.Property(e => e.CategoryFid).HasColumnName("Category_fid");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.IsForSale)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
