using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetailsHandbook.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlternateResistors",
                columns: table => new
                {
                    SpinType = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<double>(type: "REAL", nullable: false),
                    Nominal = table.Column<double>(type: "REAL", nullable: false),
                    Access = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternateResistors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "AnalogMicrocircuits",
                columns: table => new
                {
                    FunctionalPurpose = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    SupplyVoltage = table.Column<string>(type: "TEXT", nullable: false),
                    CaseType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalogMicrocircuits", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "CeramicCapacitors",
                columns: table => new
                {
                    Tcc = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    Nominal = table.Column<double>(type: "REAL", nullable: false),
                    WorkingVoltage = table.Column<int>(type: "INTEGER", nullable: false),
                    Access = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CeramicCapacitors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "ComputerSystems",
                columns: table => new
                {
                    FunctionalPurpose = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    SupplyVoltage = table.Column<string>(type: "TEXT", nullable: false),
                    CaseType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerSystems", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "ConstantResistor",
                columns: table => new
                {
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<double>(type: "REAL", nullable: false),
                    Nominal = table.Column<double>(type: "REAL", nullable: false),
                    Access = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstantResistor", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "ElectrolyticCapacitors",
                columns: table => new
                {
                    PlateType = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    Nominal = table.Column<double>(type: "REAL", nullable: false),
                    WorkingVoltage = table.Column<int>(type: "INTEGER", nullable: false),
                    Access = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectrolyticCapacitors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "HighFreqConnector",
                columns: table => new
                {
                    WaveResistance = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    MaxCommVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighFreqConnector", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "HighFreqDiodes",
                columns: table => new
                {
                    CutoffFreq = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    CutoffCurrent = table.Column<double>(type: "REAL", nullable: false),
                    CutoffVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighFreqDiodes", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "Inductances",
                columns: table => new
                {
                    Nominal = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkingCurrent = table.Column<double>(type: "REAL", nullable: false),
                    Access = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inductances", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "LightDiodes",
                columns: table => new
                {
                    LightPower = table.Column<double>(type: "REAL", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    CutoffCurrent = table.Column<double>(type: "REAL", nullable: false),
                    CutoffVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightDiodes", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "LogicMicrocircuits",
                columns: table => new
                {
                    LogicOrganization = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    SupplyVoltage = table.Column<string>(type: "TEXT", nullable: false),
                    CaseType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogicMicrocircuits", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "LowFreqConnectors",
                columns: table => new
                {
                    ConnectorType = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    MaxCommVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LowFreqConnectors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "MembraneCapacitors",
                columns: table => new
                {
                    PlateType = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    Nominal = table.Column<double>(type: "REAL", nullable: false),
                    WorkingVoltage = table.Column<int>(type: "INTEGER", nullable: false),
                    Access = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembraneCapacitors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "RectifyingDiodes",
                columns: table => new
                {
                    ReverseCurrent = table.Column<double>(type: "REAL", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    CutoffCurrent = table.Column<double>(type: "REAL", nullable: false),
                    CutoffVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RectifyingDiodes", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "Relays",
                columns: table => new
                {
                    WindingWorkVoltage = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    MaxCommVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relays", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "Switchers",
                columns: table => new
                {
                    SwitchType = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false),
                    MaxCommVoltage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switchers", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "Thyristors",
                columns: table => new
                {
                    DcVoltageInClosedCase = table.Column<int>(type: "INTEGER", nullable: false),
                    DCurrentInOpenCase = table.Column<double>(type: "REAL", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thyristors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "Transistors",
                columns: table => new
                {
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<string>(type: "TEXT", nullable: false),
                    CutoffFreq = table.Column<int>(type: "INTEGER", nullable: false),
                    HighOrLowFreq = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transistors", x => x.Model);
                });

            migrationBuilder.CreateTable(
                name: "ZenerDiodes",
                columns: table => new
                {
                    StabilizationVoltage = table.Column<double>(type: "REAL", nullable: false),
                    StabilizationCurrent = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Interchangeability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZenerDiodes", x => x.Model);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternateResistors");

            migrationBuilder.DropTable(
                name: "AnalogMicrocircuits");

            migrationBuilder.DropTable(
                name: "CeramicCapacitors");

            migrationBuilder.DropTable(
                name: "ComputerSystems");

            migrationBuilder.DropTable(
                name: "ConstantResistor");

            migrationBuilder.DropTable(
                name: "ElectrolyticCapacitors");

            migrationBuilder.DropTable(
                name: "HighFreqConnector");

            migrationBuilder.DropTable(
                name: "HighFreqDiodes");

            migrationBuilder.DropTable(
                name: "Inductances");

            migrationBuilder.DropTable(
                name: "LightDiodes");

            migrationBuilder.DropTable(
                name: "LogicMicrocircuits");

            migrationBuilder.DropTable(
                name: "LowFreqConnectors");

            migrationBuilder.DropTable(
                name: "MembraneCapacitors");

            migrationBuilder.DropTable(
                name: "RectifyingDiodes");

            migrationBuilder.DropTable(
                name: "Relays");

            migrationBuilder.DropTable(
                name: "Switchers");

            migrationBuilder.DropTable(
                name: "Thyristors");

            migrationBuilder.DropTable(
                name: "Transistors");

            migrationBuilder.DropTable(
                name: "ZenerDiodes");
        }
    }
}
