using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Episodios
{
    public Episodios(string titulo, int duracao, string resumo, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Resumo = resumo;
        Ordem = ordem;
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo { get; }
    public int Ordem { get; }


    public void AdicionarConvidados()
    {

    }
}