namespace TesteInsereAutoConclusao.Models
{
    public class AutoConcluMensoes: Entity
    {
        public string ProtocoloN { get; set; }
        public string AreaTerreno { get; set; }
        public string AreaConstruida { get; set; }
        public string QtdPecasInternas { get; set; }
        public string QtdPecasExternas { get; set; }
        public string NPavimentos { get; set; }
        public string NUnidadeResidenciais { get; set; }
        public string NUnidadeComerciais { get; set; }
        public string AreaTotalEdificacao { get; set; }
        public string RecuoFrontal { get; set; }
        public string TaxaOcupacao { get; set; }
    }
}
