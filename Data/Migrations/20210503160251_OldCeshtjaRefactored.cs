using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.QendraFolApi.Data.Migrations
{
    public partial class OldCeshtjaRefactored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vendimi Gjykates Shk1",
                table: "OldCeshtja",
                newName: "Vendimi_Gjykates_Shk1");

            migrationBuilder.RenameColumn(
                name: "Vendimi Apelit",
                table: "OldCeshtja",
                newName: "Vendimi_Apelit");

            migrationBuilder.RenameColumn(
                name: "Vendim Gjykata Larte",
                table: "OldCeshtja",
                newName: "Vendim_Gjykata_Larte");

            migrationBuilder.RenameColumn(
                name: "Sipas Nenit_P",
                table: "OldCeshtja",
                newName: "Sipas_Nenit_P");

            migrationBuilder.RenameColumn(
                name: "Sipas Nenit",
                table: "OldCeshtja",
                newName: "Sipas_Nenit");

            migrationBuilder.RenameColumn(
                name: "Masa e sigurisë në Gjykatën e Larte",
                table: "OldCeshtja",
                newName: "Masa_e_sigurisë_në_Gjykatën_e_Larte");

            migrationBuilder.RenameColumn(
                name: "Masa e sigurisë në Gjykatën e Apelit",
                table: "OldCeshtja",
                newName: "Masa_e_sigurisë_në_Gjykatën_e_Apelit");

            migrationBuilder.RenameColumn(
                name: "Masa e sigurisë kërkuar nga Prokurori",
                table: "OldCeshtja",
                newName: "Masa_e_sigurisë_kërkuar_nga_Prokurori");

            migrationBuilder.RenameColumn(
                name: "Masa e sigurise Gjykata Shk1",
                table: "OldCeshtja",
                newName: "Masa_e_sigurise_Gjykata_Shk1");

            migrationBuilder.RenameColumn(
                name: "Gjygjtari paraprak",
                table: "OldCeshtja",
                newName: "Gjygjtari_paraprak");

            migrationBuilder.RenameColumn(
                name: "Data mases Gjykates Shk1",
                table: "OldCeshtja",
                newName: "Data_mases_Gjykates_Shk1");

            migrationBuilder.RenameColumn(
                name: "Data mas sig Gj Larte",
                table: "OldCeshtja",
                newName: "Data_mas_sig_Gj_Larte");

            migrationBuilder.RenameColumn(
                name: "Data mas sig Apeli",
                table: "OldCeshtja",
                newName: "Data_mas_sig_Apeli");

            migrationBuilder.RenameColumn(
                name: "Data Vendimit Pr",
                table: "OldCeshtja",
                newName: "Data_Vendimit_Pr");

            migrationBuilder.RenameColumn(
                name: "Data Vendimit GJ SH1",
                table: "OldCeshtja",
                newName: "Data_Vendimit_GJ_SH1");

            migrationBuilder.RenameColumn(
                name: "Data Vendim Apeli",
                table: "OldCeshtja",
                newName: "Data_Vendim_Apeli");

            migrationBuilder.RenameColumn(
                name: "Data Vedim Gjk",
                table: "OldCeshtja",
                newName: "Data_Vedim_Gjk");

            migrationBuilder.RenameColumn(
                name: "Data Gjykata Larte",
                table: "OldCeshtja",
                newName: "Data_Gjykata_Larte");

            migrationBuilder.RenameColumn(
                name: "Data Gjygjtari pr",
                table: "OldCeshtja",
                newName: "Data_Gjygjtari_pr");

            migrationBuilder.AddColumn<int>(
                name: "OldId",
                table: "OldCeshtja",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldId",
                table: "OldCeshtja");

            migrationBuilder.RenameColumn(
                name: "Vendimi_Gjykates_Shk1",
                table: "OldCeshtja",
                newName: "Vendimi Gjykates Shk1");

            migrationBuilder.RenameColumn(
                name: "Vendimi_Apelit",
                table: "OldCeshtja",
                newName: "Vendimi Apelit");

            migrationBuilder.RenameColumn(
                name: "Vendim_Gjykata_Larte",
                table: "OldCeshtja",
                newName: "Vendim Gjykata Larte");

            migrationBuilder.RenameColumn(
                name: "Sipas_Nenit_P",
                table: "OldCeshtja",
                newName: "Sipas Nenit_P");

            migrationBuilder.RenameColumn(
                name: "Sipas_Nenit",
                table: "OldCeshtja",
                newName: "Sipas Nenit");

            migrationBuilder.RenameColumn(
                name: "Masa_e_sigurisë_në_Gjykatën_e_Larte",
                table: "OldCeshtja",
                newName: "Masa e sigurisë në Gjykatën e Larte");

            migrationBuilder.RenameColumn(
                name: "Masa_e_sigurisë_në_Gjykatën_e_Apelit",
                table: "OldCeshtja",
                newName: "Masa e sigurisë në Gjykatën e Apelit");

            migrationBuilder.RenameColumn(
                name: "Masa_e_sigurisë_kërkuar_nga_Prokurori",
                table: "OldCeshtja",
                newName: "Masa e sigurisë kërkuar nga Prokurori");

            migrationBuilder.RenameColumn(
                name: "Masa_e_sigurise_Gjykata_Shk1",
                table: "OldCeshtja",
                newName: "Masa e sigurise Gjykata Shk1");

            migrationBuilder.RenameColumn(
                name: "Gjygjtari_paraprak",
                table: "OldCeshtja",
                newName: "Gjygjtari paraprak");

            migrationBuilder.RenameColumn(
                name: "Data_mases_Gjykates_Shk1",
                table: "OldCeshtja",
                newName: "Data mases Gjykates Shk1");

            migrationBuilder.RenameColumn(
                name: "Data_mas_sig_Gj_Larte",
                table: "OldCeshtja",
                newName: "Data mas sig Gj Larte");

            migrationBuilder.RenameColumn(
                name: "Data_mas_sig_Apeli",
                table: "OldCeshtja",
                newName: "Data mas sig Apeli");

            migrationBuilder.RenameColumn(
                name: "Data_Vendimit_Pr",
                table: "OldCeshtja",
                newName: "Data Vendimit Pr");

            migrationBuilder.RenameColumn(
                name: "Data_Vendimit_GJ_SH1",
                table: "OldCeshtja",
                newName: "Data Vendimit GJ SH1");

            migrationBuilder.RenameColumn(
                name: "Data_Vendim_Apeli",
                table: "OldCeshtja",
                newName: "Data Vendim Apeli");

            migrationBuilder.RenameColumn(
                name: "Data_Vedim_Gjk",
                table: "OldCeshtja",
                newName: "Data Vedim Gjk");

            migrationBuilder.RenameColumn(
                name: "Data_Gjykata_Larte",
                table: "OldCeshtja",
                newName: "Data Gjykata Larte");

            migrationBuilder.RenameColumn(
                name: "Data_Gjygjtari_pr",
                table: "OldCeshtja",
                newName: "Data Gjygjtari pr");
        }
    }
}
