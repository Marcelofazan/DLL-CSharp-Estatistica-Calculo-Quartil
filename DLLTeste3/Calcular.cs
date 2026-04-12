using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace DLLTeste3
{
    [ComVisible(true), GuidAttribute("89BB4535-5A89-43a0-89C5-19A4697E5C5C")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("DLLTeste3.Cotacao")]
    public class Cotacao
    {
        public double PrimeiroQuartil { get; set; }
        public double TerceiroQuartil { get; set; }
        public int GetCotacaoCount => (Cotacoes != null ? Cotacoes.Count : 0);
        public List<decimal> Cotacoes { get; set; } = new List<decimal>(); 

        public void AddCotacao(decimal cotacao)
        {
            if (Cotacoes == null)
            {
                Cotacoes = new List<decimal>();
            }
            Cotacoes.Add(cotacao);
        }

        public dynamic Estatistica()
        {
            try
            {
                double[] x;
                x = Cotacoes.Select(i => Convert.ToDouble(i, System.Globalization.CultureInfo.InvariantCulture)).ToArray();
                Descriptive desp = new Descriptive(x);
                desp.Analyze(); // analyze the data

                try
                {
                    PrimeiroQuartil = desp.Result.FirstQuartile;
                    TerceiroQuartil = desp.Result.ThirdQuartile;
                }
                catch (Exception)
                {
                    PrimeiroQuartil = 0;
                    TerceiroQuartil = 0;
                }
            }
            catch (Exception)
            {
                PrimeiroQuartil = 0;
                TerceiroQuartil = 0;
            }

            var listaEstatistica = new { PrimeiroQuartil, TerceiroQuartil };

            return JsonConvert.SerializeObject(listaEstatistica);
        }
    }
}