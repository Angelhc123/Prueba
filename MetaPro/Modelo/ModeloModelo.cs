using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MetaPro.Modelo
{
    public partial class ModeloModelo : DbContext
    {
        public ModeloModelo()
            : base("name=ModeloModelo")
        {
        }

        public virtual DbSet<Amigos> Amigo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Criaturitas> Criaturita { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Objetivos> Objetivo { get; set; }
        public virtual DbSet<Usuarios> Usuario { get; set; }
        public virtual DbSet<V_BuscarAmigo> V_BuscarAmigo { get; set; }
        public virtual DbSet<V_MisobjetivosCumplidos> V_MisobjetivosCumplidos { get; set; }
        public virtual DbSet<V_MisobjetivosInCumplidos> V_MisobjetivosInCumplidos { get; set; }
        public virtual DbSet<V_Ver_Misobjetivos> V_Ver_Misobjetivos { get; set; }
        public virtual DbSet<V_Visualizar_amigos> V_Visualizar_amigos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Dificultad)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Objetivo)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Criaturitas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Criaturitas>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Criaturitas>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Criaturitas>()
                .Property(e => e.Pais)
                .IsUnicode(false);

            modelBuilder.Entity<Criaturitas>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Criaturitas>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Criaturitas>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Criaturita)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Conexion)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Objetivos>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Objetivos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Objetivos>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Objetivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Amigo)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdAmigoUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Amigo1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<V_BuscarAmigo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<V_BuscarAmigo>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<V_MisobjetivosCumplidos>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<V_MisobjetivosCumplidos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<V_MisobjetivosCumplidos>()
                .Property(e => e.Dificultad)
                .IsUnicode(false);

            modelBuilder.Entity<V_MisobjetivosInCumplidos>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<V_MisobjetivosInCumplidos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<V_MisobjetivosInCumplidos>()
                .Property(e => e.Dificultad)
                .IsUnicode(false);

            modelBuilder.Entity<V_Ver_Misobjetivos>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<V_Ver_Misobjetivos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<V_Ver_Misobjetivos>()
                .Property(e => e.Dificultad)
                .IsUnicode(false);

            modelBuilder.Entity<V_Visualizar_amigos>()
                .Property(e => e.Nickname)
                .IsUnicode(false);

            modelBuilder.Entity<V_Visualizar_amigos>()
                .Property(e => e.Conexion)
                .IsUnicode(false);
        }
    }
}
