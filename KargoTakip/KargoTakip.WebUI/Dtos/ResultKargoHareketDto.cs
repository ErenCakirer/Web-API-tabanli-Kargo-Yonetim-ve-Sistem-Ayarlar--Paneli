namespace KargoTakip.WebUI.Dtos
{
    public class ResultKargoHareketDto
    {
        public int KargoHareketID { get; set; }
        public string TakipKodu { get; set; }
        public string Istasyon { get; set; }
        public string Durum { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
