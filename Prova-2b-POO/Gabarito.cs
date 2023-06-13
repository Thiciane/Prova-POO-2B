using System;
public class Gabarito
{
    public string[] resposta = {"A", "B", "D", "E", "C", "A", "A", "D", "E", "B"};
     
    public string Correcaoo(string[] aluno)
    {
        
        int conta = 0;
        for(int i = 0; i < resposta.Length; i++)
        {
            string[] respostas = (aluno[i].ToLower()).Split();
            string[] gabarito = (resposta[i].ToLower()).Split();

            if (respostas[i] == gabarito[i])
            {
                conta =+ 1;
            }
        }
        return Convert.ToInt32(conta).ToString();
    }
}
