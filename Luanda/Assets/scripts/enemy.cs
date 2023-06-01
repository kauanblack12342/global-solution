using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public diretorScript diretor;





    void Update()
    {
       transform.Translate(0,0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "parede")
        {
            speed = -speed;
        }

        if(collision.gameObject.tag == "Player")
        {
            diretor.reiniciarJogo();
        }
    }
}
