using System;
public class Gabarito
{
    public string[] resposta = {"A", "B", "D", "E", "C", "A", "A", "D", "E", "B"};
     
    public string Correcaoo(string[] aluno)
    {
        int conta = 0;
        for(int i = 0; i < resposta.Length; i++)
        {
            string alunoUpper = aluno[i].ToUpper();
            if (alunoUpper == resposta[i])
            {
                conta++;
            }
        }
        return conta.ToString();
    }
}
