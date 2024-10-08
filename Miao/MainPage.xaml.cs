namespace Miao;

public partial class MainPage : ContentPage
{
    Gerenciador gerenciador;
    public MainPage()
    {
        InitializeComponent();
        gerenciador = new Gerenciador(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        gerenciador.ProximaQuestao();
    }
    void OnBTNResp01Clicked(object sender, EventArgs args)
    {
        gerenciador.VerificaResposta(1);
    }
    void OnBTNResp02Clicked(object sender, EventArgs args)
    {
        gerenciador.VerificaResposta(2);
    }
    void OnBTNResp03Clicked(object sender, EventArgs args)
    {
        gerenciador.VerificaResposta(3);
    }
    void OnBTNResp04Clicked(object sender, EventArgs args)
    {
        gerenciador.VerificaResposta(4);
    }
    void OnBTNResp05Clicked(object sender, EventArgs args)
    {
        gerenciador.VerificaResposta(5);
    }
}
int Pular = 0;
    void PularClicked(object s, EventArgs e)
    {
        if (Pular == 2){
             (s as Button).IsVisible = false;
        }
       else
       {
         gerenciador.ProximaQuestao();
         Pular ++;
       }
       if (Pular == 0)
       {
         pulinhos == "Pular X2";
       }
       if (Pular == 1)
       {
         pulinhos == "Pular X1";
       }
   
    }

