namespace KargoTakip.WebUI.Dtos
{
    public class ResultMesajDto
    {
        public int MesajId { get; set; }
        public string Gonderen { get; set; }
        public string Konu { get; set; }
        public string MesajIcerik { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
    }
}