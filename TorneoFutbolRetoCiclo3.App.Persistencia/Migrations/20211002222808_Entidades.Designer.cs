// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211002222808_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("ArbitroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("documento_arbitro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre_arbitro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre_colegio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telefono_arbitro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArbitroId");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Desempeno_equipo", b =>
                {
                    b.Property<int>("Desempeno_equipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_goles_a_favor")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_goles_en_contra")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_partidos_empatados")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_partidos_ganados")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_partidos_jugados")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_puntos")
                        .HasColumnType("int");

                    b.HasKey("Desempeno_equipoId");

                    b.HasIndex("EquipoId");

                    b.ToTable("Desempeno_equipos");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre_equipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EquipoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("EstadioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("direccion_estadio")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre_estadio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EstadioId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("JugadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("Posicion_jugadorId")
                        .HasColumnType("int");

                    b.Property<string>("apellido_jugador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nombre_jugador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("numero_jugador")
                        .HasColumnType("int");

                    b.HasKey("JugadorId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("Posicion_jugadorId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre_municipio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MunicipioId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Novedad", b =>
                {
                    b.Property<int>("NovedadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_novedadId")
                        .HasColumnType("int");

                    b.Property<int>("minuto_novedad")
                        .HasColumnType("int");

                    b.HasKey("NovedadId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("PartidoId");

                    b.HasIndex("Tipo_novedadId");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Partido", b =>
                {
                    b.Property<int>("PartidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArbitroId")
                        .HasColumnType("int");

                    b.Property<int>("EstadioId")
                        .HasColumnType("int");

                    b.Property<int>("cod_equipo_local")
                        .HasColumnType("int");

                    b.Property<int>("cod_equipo_vistante")
                        .HasColumnType("int");

                    b.Property<string>("fecha_partido")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("goles_equipo_local")
                        .HasColumnType("int");

                    b.Property<int>("goles_equipo_visitante")
                        .HasColumnType("int");

                    b.Property<string>("hora_partido")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("PartidoId");

                    b.HasIndex("ArbitroId");

                    b.HasIndex("EstadioId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Posicion_jugador", b =>
                {
                    b.Property<int>("Posicion_jugadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre_posicion_jugador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Posicion_jugadorId");

                    b.ToTable("Posicion_jugadores");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Tecnico", b =>
                {
                    b.Property<int>("TecnicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("nombre_tecnico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TecnicoId");

                    b.HasIndex("EquipoId");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Tipo_novedad", b =>
                {
                    b.Property<int>("Tipo_novedadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre_tipo_novedad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Tipo_novedadId");

                    b.ToTable("Tipo_novedades");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Desempeno_equipo", b =>
                {
                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Jugador", b =>
                {
                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Posicion_jugador", "Posicion_jugador")
                        .WithMany()
                        .HasForeignKey("Posicion_jugadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Posicion_jugador");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Novedad", b =>
                {
                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Partido", "Partido")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Tipo_novedad", "Tipo_novedad")
                        .WithMany()
                        .HasForeignKey("Tipo_novedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Partido");

                    b.Navigation("Tipo_novedad");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Partido", b =>
                {
                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Arbitro", "Arbitro")
                        .WithMany()
                        .HasForeignKey("ArbitroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arbitro");

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("TorneoFutbolRetoCiclo3.App.Dominio.Tecnico", b =>
                {
                    b.HasOne("TorneoFutbolRetoCiclo3.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
