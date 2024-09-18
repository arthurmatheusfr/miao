namespace Miao;

public class Questao
public string RespostaErrada {get; set;}
public string RespostaCorreta {get; set;}
public string pergunta {get; set;}
private button QualBTN(int rr)
{
    if(rr == 1)
    return BotaoResposta01;
    else if (rr == 2)
    return BotaoResposta02;
    else if (rr == 3)
    return BotaoResposta03;
    else if (rr == 4)
    return BotaoResposta04;
    else if (rr == 5)
    return BotaoResposta05;
    else
    return null;
}
public bool VerificaResposta(int rr)
{
    if (RespostaCerta == rr)
    {
        var BTN = QualBTN(rr);
        BTN BackgroundColor = Colors.Green;
        return true;
    }
    else
    {
        var BTNCorreto = QualBTN(RespostaCerta);
        var BTNIncorreto = QualBTN(rr);
        BTNCorreto.BackgroundColor = Colors.Yellow;
        BTNIncorreto.BackgroundColor = Colors.Red;
        return false;
    }
}
