namespace Miao;

public partial class Questao
{

    public int RespostaCorreta;
    public int NivelResposta;

    public string pergunta;
    public string Resposta01;
    public string Resposta02;
    public string Resposta03;
    public string Resposta04;
    public string Resposta05;

    private Label LabelPergunta;
    
    private Button ButtonResposta1;
    private Button ButtonResposta2;
    private Button ButtonResposta3;
    private Button ButtonResposta4;
    private Button ButtonResposta5;

    public void ConfiguraDesenho(Label labelPergunta, Button BTNResposta01, Button BTNResposta02, Button BTNResposta03, Button BTNResposta04, Button BTNResposta05)
    {

    }

    private Button QualBTN(int rr)
    {
        if (rr == 1)
            return ButtonResposta1;
        else if (rr == 2)
            return ButtonResposta2;
        else if (rr == 3)
            return ButtonResposta3;
        else if (rr == 4)
            return ButtonResposta4;
        else if (rr == 5)
            return ButtonResposta5;
        else
            return null;
    }
    public bool VerificaResposta(int rr)
    {
        if (RespostaCorreta == rr)
        {
            var BTN = QualBTN(rr);
            BTN.BackgroundColor = Colors.Green;
            return true;
        }
        else
        {
            var BTNCorreto = QualBTN(RespostaCorreta);
            var BTNIncorreto = QualBTN(rr);
            BTNCorreto.BackgroundColor = Colors.Yellow;
            BTNIncorreto.BackgroundColor = Colors.Red;
            return false;
        }

    }
}