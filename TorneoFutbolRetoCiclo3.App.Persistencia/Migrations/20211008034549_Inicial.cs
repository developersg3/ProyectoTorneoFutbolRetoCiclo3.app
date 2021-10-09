using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolRetoCiclo3.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    ArbitroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_arbitro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    documento_arbitro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono_arbitro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nombre_colegio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.ArbitroId);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_equipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoId);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    MunicipioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_municipio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.MunicipioId);
                });

            migrationBuilder.CreateTable(
                name: "Posicion_jugadores",
                columns: table => new
                {
                    Posicion_jugadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_posicion_jugador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicion_jugadores", x => x.Posicion_jugadorId);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_novedades",
                columns: table => new
                {
                    Tipo_novedadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_tipo_novedad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_novedades", x => x.Tipo_novedadId);
                });

            migrationBuilder.CreateTable(
                name: "Desempeno_equipos",
                columns: table => new
                {
                    Desempeno_equipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad_partidos_jugados = table.Column<int>(type: "int", nullable: false),
                    cantidad_partidos_ganados = table.Column<int>(type: "int", nullable: false),
                    cantidad_partidos_empatados = table.Column<int>(type: "int", nullable: false),
                    cantidad_goles_a_favor = table.Column<int>(type: "int", nullable: false),
                    cantidad_goles_en_contra = table.Column<int>(type: "int", nullable: false),
                    cantidad_puntos = table.Column<int>(type: "int", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desempeno_equipos", x => x.Desempeno_equipoId);
                    table.ForeignKey(
                        name: "FK_Desempeno_equipos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    TecnicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_tecnico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.TecnicoId);
                    table.ForeignKey(
                        name: "FK_Tecnicos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    EstadioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_estadio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    direccion_estadio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.EstadioId);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "MunicipioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_jugador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido_jugador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    numero_jugador = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    EquipoId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Posicion_jugadorId = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.JugadorId);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jugadores_Posicion_jugadores_Posicion_jugadorId",
                        column: x => x.Posicion_jugadorId,
                        principalTable: "Posicion_jugadores",
                        principalColumn: "Posicion_jugadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_equipo_local = table.Column<int>(type: "int", nullable: false),
                    cod_equipo_vistante = table.Column<int>(type: "int", nullable: false),
                    goles_equipo_local = table.Column<int>(type: "int", nullable: false),
                    goles_equipo_visitante = table.Column<int>(type: "int", nullable: false),
                    fecha_partido = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    hora_partido = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ArbitroId = table.Column<int>(type: "int", nullable: false),
                    EstadioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.PartidoId);
                    table.ForeignKey(
                        name: "FK_Partidos_Arbitros_ArbitroId",
                        column: x => x.ArbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "ArbitroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "EstadioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    NovedadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    minuto_novedad = table.Column<int>(type: "int", nullable: false),
                    Tipo_novedadId = table.Column<int>(type: "int", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.NovedadId);
                    table.ForeignKey(
                        name: "FK_Novedades_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "EquipoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Novedades_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "PartidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Novedades_Tipo_novedades_Tipo_novedadId",
                        column: x => x.Tipo_novedadId,
                        principalTable: "Tipo_novedades",
                        principalColumn: "Tipo_novedadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desempeno_equipos_EquipoId",
                table: "Desempeno_equipos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_Posicion_jugadorId",
                table: "Jugadores",
                column: "Posicion_jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_EquipoId",
                table: "Novedades",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_PartidoId",
                table: "Novedades",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_Tipo_novedadId",
                table: "Novedades",
                column: "Tipo_novedadId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_ArbitroId",
                table: "Partidos",
                column: "ArbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EstadioId",
                table: "Partidos",
                column: "EstadioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnicos_EquipoId",
                table: "Tecnicos",
                column: "EquipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desempeno_equipos");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Posicion_jugadores");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Tipo_novedades");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
