namespace KargoTakip.WebUI.Dtos
{
    public class ResultSevkiyatDto
    {
        public int ID { get; set; }
        public string? TakipNo { get; set; }
        public string? Gönderen { get; set; }
        public string? Alıcı { get; set; }
        public string? TeslimatAdresi { get; set; }
        public DateTime OluşturulmaTarihi { get; set; }
        public string? Durum { get; set; }
    }
}