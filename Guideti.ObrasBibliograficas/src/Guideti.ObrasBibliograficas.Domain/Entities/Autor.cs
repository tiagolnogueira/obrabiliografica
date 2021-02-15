namespace Guideti.ObrasBibliograficas.Domain.Entities
{
    public class Autor : Entity
    {
        public string Nome
        {
            get => NomeFormatado(); set => _ = value;
        }
        public string NomeFormatado()
        {
            if (Nome.Trim() == "") return "";
            string nomeCompletoRetornado = Nome;
            string primeiroNome = nomeCompletoRetornado.Split(new char[] { ' ', ',' })[0].Trim();
            string resto = nomeCompletoRetornado.Substring(
                 primeiroNome.Length + 1,
                 nomeCompletoRetornado.Length - primeiroNome.Length - 1).Trim();
            string resultadoFinal = resto.ToUpper() + " " + primeiroNome + ".";
            return resultadoFinal;
        }
    }
}
