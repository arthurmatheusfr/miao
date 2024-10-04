namespace Miao;

public class Universitarios : IAjuda
{
public override void RealizaAjuda(Questao questao)
{
  var porcentagem = 100;
  for (int i = 0; i<5; i++)
  {
    int NumRand = 0;
    if(porcentagem>0)
    {
        NumRand = Random.Shared.Next(0, porcentagem);
        porcentagem -= NumRand;
    }
    switch(i)
    {
        case 0:
        BTNResposta01.text+= "-"+NumRand.ToString()+"%";
        break;
        case 1:
        BTNResposta02.text+= "-"+NumRand.ToString()+"%";
        break;
         case 2:
        BTNResposta03.text+= "-"+NumRand.ToString()+"%";
        break;
         case 3:
        BTNResposta04.text+= "-"+NumRand.ToString()+"%";
        break;
         case 4:
        BTNResposta05.text+= "-"+NumRand.ToString()+"%";
        break;
    }
  
  }


}
}
