using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class diretorScript : MonoBehaviour
{

    public player Player;
    public GameObject vitoria;
   public void reiniciarJogo()
    {
        
       
        Player.reiniciar();
        Player.timer = 5;
        vitoria.SetActive(false);
        
    }

    public void venceuJogo()
    {
        vitoria.SetActive(true);

    }
}
