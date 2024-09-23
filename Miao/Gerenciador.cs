namespace Miao;

public class Gerenciador
{
  public int Pontuacao {get; private set;}
  int NivelAtual = 0;
  void Inicializar()
  {
    Pontuacao = 0;
    NivelAtual = 0;
    ProximaQuestao();
  }
  void AdicionaPontuacao(int N)
  {

  }
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
        Q2.pergunta = " Qual é a capital da França?";
        Q2.Resposta01 = "Madrid";
        Q2.Resposta02 = "Roma";
        Q2.Resposta03 = "Paris";
        Q2.Resposta04 = "Londres";
        Q2.Resposta05 = "Berlim";
        Q2.RespostaCorreta = 3;
        Q2.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q2);
       var Q3 = new Questao();
        Q3.pergunta = " Quem é o autor de A Moreninha?";
        Q3.Resposta01 = "Machado de Assis";
        Q3.Resposta02 = "Joaquim Manuel de Macedo";
        Q3.Resposta03 = " Álvares de Azevedo";
        Q3.Resposta04 = "José de Alencar";
        Q3.Resposta05 = "Graciliano Ramos";
        Q3.RespostaCorreta = 2;
        Q3.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q3);
       var Q4 = new Questao();
       Q4.pergunta = " Quem escreveu O Pequeno Príncipe?";
        Q4.Resposta01 = "Antoine de Saint-Exupéry";
        Q4.Resposta02 = "J.K. Rowling";
        Q4.Resposta03 = "Mark Twain";
        Q4.Resposta04 = "Lewis Carroll";
        Q4.Resposta05 = "C.S. Lewis";
        Q4.RespostaCorreta = 2;
        Q4.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q4);
       var Q5 = new Questao();
    }
      public void ProximaQuestao()
      {
        var NumRandomico = Random.Shared.Next(0,ListaQuestoes.Count);
        while(ListaQuestoesRespondidas.Contains(NumRandomico))
         NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(NumRandomico);
         QuestaoCorrente = ListaQuestoes[NumRandomico];
         QuestaoCorrente.Desenha();
      }
      public async void VerificaResposta(int rr)
      {
        if(QuestaoCorrente.VerificaResposta(rr))
        {
         await Task.Delay(1000);
         AdicionaPontuacao(NivelAtual);
         NivelAtual++;
         ProximaQuestao();
        }
        else
        {
          await App.Current.MainPage.DisplayAlert("Game Over", "Você perdeu!", "ok");
          Inicializar();
        }
      }
}