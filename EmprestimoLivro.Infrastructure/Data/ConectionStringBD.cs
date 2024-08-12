using System.IO;
using System;

namespace EmprestimoLivro.Infrastructure.Data
{
    public static class ConectionStringBD
    {
        public static string GetConectionString()
        {
            try
            {
                string caminhoDoArquivo = @"C:\EmprestimoLivro\ConectionStringSQLServer.txt";

                using (StreamReader sr = new StreamReader(caminhoDoArquivo))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
