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
    void CriarQuestoes(Label labelPergunta,
    ,)
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
        Q4.RespostaCorreta = 1;
        Q4.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q4);
       var Q5 = new Questao();
       Q5.pergunta = "Qual é a língua mais falada do mundo?";
        Q5.Resposta01 = "Espanhol";
        Q5.Resposta02 = "Inglês";
        Q5.Resposta03 = "Mandarim";
        Q5.Resposta04 = "Hindi";
        Q5.Resposta05 = "Árabe";
        Q5.RespostaCorreta = 3;
        Q5.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q5);
       var Q6 = new Questao();
       Q6.pergunta = "Qual é o nome do nosso galáxia?";
        Q6.Resposta01 = "Andrômeda";
        Q6.Resposta02 = "Via Láctea";
        Q6.Resposta03 = "Sombrero";
        Q6.Resposta04 = "Triângulo";
        Q6.Resposta05 = "Cleber";
        Q6.RespostaCorreta = 2;
        Q6.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q6);
       var Q7 = new Questao();
       Q7.pergunta = "Quem foi a primeira mulher a ganhar um Prêmio Nobel?";
        Q7.Resposta01 = "Marie Curie";
        Q7.Resposta02 = "Rosalind Franklin";
        Q7.Resposta03 = "Ada Lovelace";
        Q7.Resposta04 = "Jane Goodall";
        Q7.Resposta05 = "Barbara McClintock";
        Q7.RespostaCorreta = 1;
        Q7.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q7);
       var Q8 = new Questao();
       Q8.pergunta = "Qual é o nome do famoso detetive criado por Arthur Conan Doyle?";
        Q8.Resposta01 = "Hercule Poirot";
        Q8.Resposta02 = "Philip Marlowe";
        Q8.Resposta03 = "Sherlock Holmes";
        Q8.Resposta04 = "Sam Spade";
        Q8.Resposta05 = "Miss Marple";
        Q8.RespostaCorreta = 3;
        Q8.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q8);
       var Q9 = new Questao();
       Q9.pergunta = "Qual é o deserto mais árido do mundo?";
        Q9.Resposta01 = "Deserto do Saara";
        Q9.Resposta02 = "Deserto de Atacama";
        Q9.Resposta03 = "Deserto de Gobi";
        Q9.Resposta04 = "Deserto da Arábia";
        Q9.Resposta05 = "Egito";
        Q9.RespostaCorreta = 2;
        Q9.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q9);
       var Q10 = new Questao();
        Q10.pergunta = "Qual a fórmula da velocidade média?";
        Q10.Resposta01 = "V = S / T";
        Q10.Resposta02 = "V = T / S";
        Q10.Resposta03 = "V = S + T";
        Q10.Resposta04 = "V = S - T";
        Q10.Resposta05 = "V = S * T";
        Q10.RespostaCorreta = 1;
        Q10.ConfigurarDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q10);
       var Q11 = new Questao();

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