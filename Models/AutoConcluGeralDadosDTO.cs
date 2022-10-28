namespace TesteInsereAutoConclusao.Models
{
    public class AutoConcluGeralDadosDTO : Entity
    {
        public string ProtocoloN { get; set; }
        public string AutoConclu { get; set; }
        public string ProjetoN { get; set; }
        public string Requerente { get; set; }
        public string Quadra { get; set; }
        public int Lote { get; set; }
        public string Endereco { get; set; }
        public string DataLicenca { get; set; }
        public string ConclusaoObra { get; set; }
        //--------------------------------------------
        public string TipoUnidade { get; set; }
        public string Material { get; set; }
        public string RevestimentoExterno { get; set; }
        public string RevestimentoInterno { get; set; }
        public string Esquadria { get; set; }
        public string Estrutura { get; set; }
        public string Cobertura { get; set; }
        public string InstalacaoSanitaria { get; set; }
        public string Forro { get; set; }
        public string InstalacaoEletrica { get; set; }
        public string Piso { get; set; }
        public string Limitacao { get; set; }
        //--------------------------------------------
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
        //--------------------------------------------
        public string Esgoto { get; set; }
        public string AguaRede { get; set; }
        public string FossaSepticaSumidouro { get; set; }
        public string EnergiaEletrica { get; set; }
        public string Iluminacao { get; set; }
        public string Telefone { get; set; }
        public string GuiasSarjetas { get; set; }
        public string GaleriaPluvial { get; set; }
        public string Pavimentacao { get; set; }
        public string Calcamento { get; set; }
        public string Arborizacao { get; set; }
        public string LimpezaPublica { get; set; }
        public string ColetaLixo { get; set; }
        public string TransporteColetivo { get; set; }

    }
}
