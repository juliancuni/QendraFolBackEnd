using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.QendraFolApi.Data.Migrations
{
    public partial class OldCeshtja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OldCeshtja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_e_ngjarjes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SipasNenit = table.Column<string>(name: "Sipas Nenit", type: "nvarchar(max)", nullable: true),
                    Policia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prokuroria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SipasNenit_P = table.Column<string>(name: "Sipas Nenit_P", type: "nvarchar(max)", nullable: true),
                    MasaesigurisëkërkuarngaProkurori = table.Column<string>(name: "Masa e sigurisë kërkuar nga Prokurori", type: "nvarchar(max)", nullable: true),
                    DataVendimitPr = table.Column<string>(name: "Data Vendimit Pr", type: "nvarchar(max)", nullable: true),
                    Gjykata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hetimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataVedimGjk = table.Column<string>(name: "Data Vedim Gjk", type: "nvarchar(max)", nullable: true),
                    Gjygjtariparaprak = table.Column<string>(name: "Gjygjtari paraprak", type: "nvarchar(max)", nullable: true),
                    Neni_GJP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataGjygjtaripr = table.Column<string>(name: "Data Gjygjtari pr", type: "nvarchar(max)", nullable: true),
                    MasaesiguriseGjykataShk1 = table.Column<string>(name: "Masa e sigurise Gjykata Shk1", type: "nvarchar(max)", nullable: true),
                    DatamasesGjykatesShk1 = table.Column<string>(name: "Data mases Gjykates Shk1", type: "nvarchar(max)", nullable: true),
                    VendimiGjykatesShk1 = table.Column<string>(name: "Vendimi Gjykates Shk1", type: "nvarchar(max)", nullable: true),
                    Neni_GJSH1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataVendimitGJSH1 = table.Column<string>(name: "Data Vendimit GJ SH1", type: "nvarchar(max)", nullable: true),
                    VendimiApelit = table.Column<string>(name: "Vendimi Apelit", type: "nvarchar(max)", nullable: true),
                    Neni_Apeli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataVendimApeli = table.Column<string>(name: "Data Vendim Apeli", type: "nvarchar(max)", nullable: true),
                    MasaesigurisënëGjykatëneApelit = table.Column<string>(name: "Masa e sigurisë në Gjykatën e Apelit", type: "nvarchar(max)", nullable: true),
                    DatamassigApeli = table.Column<string>(name: "Data mas sig Apeli", type: "nvarchar(max)", nullable: true),
                    VendimGjykataLarte = table.Column<string>(name: "Vendim Gjykata Larte", type: "nvarchar(max)", nullable: true),
                    DataGjykataLarte = table.Column<string>(name: "Data Gjykata Larte", type: "nvarchar(max)", nullable: true),
                    Neni_GJL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasaesigurisënëGjykatëneLarte = table.Column<string>(name: "Masa e sigurisë në Gjykatën e Larte", type: "nvarchar(max)", nullable: true),
                    DatamassigGjLarte = table.Column<string>(name: "Data mas sig Gj Larte", type: "nvarchar(max)", nullable: true),
                    Komente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OldCeshtja", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OldCeshtja");
        }
    }
}
