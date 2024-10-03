namespace Miao;
public abstract class IAjuda
{
    Button BTNResposta01;
    Button BTNResposta02;
    Button BTNResposta03;
    Button BTNResposta04;
    Button BTNResposta05;
    Frame FrameAjuda;
    public void ConfigurarDesenho(Button BTNResposta01, Button BTNResposta02, Button BTNResposta03, Button BTNResposta04, Button BTNResposta05)
    {
        this.BTNResposta01 = BTNResposta01;
        this.BTNResposta02 = BTNResposta02;
        this.BTNResposta03 = BTNResposta03;
        this.BTNResposta04 = BTNResposta04;
        this.BTNResposta05 = BTNResposta05;
    }
    public void ConfigurarDesenho(Frame FrameAjuda)
    {
        this.FrameAjuda = FrameAjuda;
    }
    public abstract void RealizaAjuda(Questao questao);
}