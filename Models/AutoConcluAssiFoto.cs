namespace TesteInsereAutoConclusao.Models
{
    public class AutoConcluAssiFoto : Entity
    {
        public string ProtocoloN { get; set; }
        public byte[] Foto1 { get; set; }
        public byte[] Foto2 { get; set; }
        public byte[] Assinatura { get; set; }

    }
}
