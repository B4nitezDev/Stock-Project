using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class DbContextStockManagement : DbContext
    {
        public DbContextStockManagement(DbContextOptions<DbContextStockManagement> options)
             : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Integration> Integrations { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Entity.Attribute> Attributes { get; set; }
        public DbSet<Alert> Alerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.Order_Type)
                .HasConversion<string>(); // Guarda el Enum como string

            modelBuilder.Entity<Order>()
                .Property(o => o.CurrentStatus)
                .HasConversion<string>(); // Guarda el Enum como string

            // Configuración de la auto-relación en Category
            modelBuilder.Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.Parent_Category)
                .OnDelete(DeleteBehavior.Restrict); // Evita múltiples rutas de cascada

            // Configuración de la relación muchos a muchos entre Users y Roles
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Configuración de la relación muchos a muchos entre Roles y Permissions
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionId);

            // Configuración de relaciones adicionales y restricciones
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Company)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.Company_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Users -> Company
            modelBuilder.Entity<User>()
                .HasOne(u => u.Company)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.Company_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Configs -> Company
            modelBuilder.Entity<Config>()
                .HasOne(u => u.Company)
                .WithMany(c => c.Configs)
                .HasForeignKey(cf => cf.Company_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Products -> Company
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Company)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Company_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // History -> Product
            modelBuilder.Entity<History>()
                .HasOne(h => h.Product)
                .WithMany(p => p.Histories)
                .HasForeignKey(h => h.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Attributes -> Product
            modelBuilder.Entity<Entity.Attribute>()
                .HasOne(a => a.Product)
                .WithMany(p => p.Attributes)
                .HasForeignKey(a => a.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Alerts -> Product
            modelBuilder.Entity<Alert>()
                .HasOne(al => al.Product)
                .WithMany(p => p.Alerts)
                .HasForeignKey(al => al.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Category -> Company
            modelBuilder.Entity<Category>()
                .HasOne(c => c.Company)
                .WithMany(co => co.Categories)
                .HasForeignKey(c => c.Company_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuración de índices y otros aspectos
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Barcode)
                .IsUnique();
        }
    }
}
