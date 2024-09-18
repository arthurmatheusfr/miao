namespace Miao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador(Label labelPergunta,Button BTNResposta01,Button BTNResposta02,Button BTNResposta03,Button BTNResposta04, Button BTNResposta05)
    {
        CriarQuestoes(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    }
    void CriarQuestoes(Label labelPergunta,Button BTNResposta01,Button BTNResposta02,Button BTNResposta03,Button BTNResposta04, Button BTNResposta05)
    {
        var Q1 = new Questao();
        Q1.pergunta = "Quanto é 2+2??????????";
        Q1.Resposta01 = "1";
        Q1.Resposta02 = "13";
        Q1.Resposta03 = "21";
        Q1.Resposta04 = "11";
        Q1.Resposta05 = "4";
        Q1.RespostaCorreta = 5;
        Q1.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q1);
        var Q2 = new Questao();
    }
      public void ProximaQuestao()
      {
        var NumRandomico = Random.Shared.Next(0,ListaQuestoes.Count - 1);
        while(ListaQuestoesRespondidas.Contains(NumRandomico))
         NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count -1);
         ListaQuestoesRespondidas.Add(NumRandomico);
         QuestaoCorrente = ListaQuestoes[NumRandomico];
         QuestaoCorrente.Desenha();
      }
      public async void VerificaResposta(int rr)
      {
        if(QuestaoCorrente.VerificaResposta(rr))
        {
         await Task.Delay(1000);
         ProximaQuestao();
        }
      }
}