using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Entities
{
    public class OldCeshtja
    {
        public int Id { get; set; }
        //[Column("OldId")]
        public int OldId { get; set; }
        //[Column("Emri")]
        public string Emri { get; set; }
        //[Column("Mbiemri")]
        public string Mbiemri { get; set; }
        //[Column("Data_e_ngjarjes")]
        public DateTime? Data_e_ngjarjes { get; set; } = null;
        //[Column("Kategoria")]
        public string Kategoria { get; set; }
        //[Column("Sipas Nenit")]
        public string Sipas_Nenit { get; set; }
        //[Column("Policia")]
        public string Policia { get; set; }
        //[Column("Prokuroria")]
        public string Prokuroria { get; set; }
        //[Column("Sipas Nenit_P")]
        public string Sipas_Nenit_P { get; set; }
        //[Column("Masa e sigurisë kërkuar nga Prokurori")]
        public string Masa_e_sigurisë_kërkuar_nga_Prokurori { get; set; }
        //[Column("Data Vendimit Pr")]
        public DateTime? Data_Vendimit_Pr { get; set; } = null;
        //[Column("Gjykata")]
        public string Gjykata { get; set; }
        //[Column("Hetimi")]
        public string Hetimi { get; set; }
        //[Column("Data Vedim Gjk")]
        public DateTime? Data_Vedim_Gjk { get; set; } = null;
        //[Column("Gjygjtari paraprak")]
        public string Gjygjtari_paraprak { get; set; }
        //[Column("Neni_GJP")]
        public string Neni_GJP { get; set; }
        //[Column("Data Gjygjtari pr")]
        public DateTime? Data_Gjygjtari_pr { get; set; } = null;
        //[Column("Masa e sigurise Gjykata Shk1")]
        public string Masa_e_sigurise_Gjykata_Shk1 { get; set; }
        //[Column("Data mases Gjykates Shk1")]
        public DateTime? Data_mases_Gjykates_Shk1 { get; set; } = null;
        //[Column("Vendimi Gjykates Shk1")]
        public string Vendimi_Gjykates_Shk1 { get; set; }
        //[Column("Neni_GJSH1")]
        public string Neni_GJSH1 { get; set; }
        //[Column("Data Vendimit GJ SH1")]
        public DateTime? Data_Vendimit_GJ_SH1 { get; set; } = null;
        //[Column("Vendimi Apelit")]
        public string Vendimi_Apelit { get; set; }
        //[Column("Neni_Apeli")]
        public string Neni_Apeli { get; set; }
        //[Column("Data Vendim Apeli")]
        public DateTime? Data_Vendim_Apeli { get; set; } = null;
        //[Column("Masa e sigurisë në Gjykatën e Apelit")]
        public string Masa_e_sigurisë_në_Gjykatën_e_Apelit { get; set; }
        //[Column("Data mas sig Apeli")]
        public DateTime? Data_mas_sig_Apeli { get; set; } = null;
        //[Column("Vendim Gjykata Larte")]
        public string Vendim_Gjykata_Larte { get; set; }
        //[Column("Data Gjykata Larte")]
        public DateTime? Data_Gjykata_Larte { get; set; } = null;
        //[Column("Neni_GJL")]
        public string Neni_GJL { get; set; }
        //[Column("Masa e sigurisë në Gjykatën e Larte")]
        public string Masa_e_sigurisë_në_Gjykatën_e_Larte { get; set; }
        //[Column("Data mas sig Gj Larte")]
        public DateTime? Data_mas_sig_Gj_Larte { get; set; } = null;
        //[Column("Komente")]
        public string Komente { get; set; }
    }
}