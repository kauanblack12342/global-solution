using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public GameObject portao;
    public GameObject portao2;
    public float speedUp;
    public float timer;
    
    public diretorScript diretor;
    

    private Rigidbody rig;
    private bool isgrounded;
    private int time;
    
    



    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
        
       
       
        
        
        
    }

    
    void Update()
    {
        move();
        jump();
        temporizador();
        
       
    }

    private void move()
    {
        float movementX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float movementZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, movementZ);
    }

    private void jump()
    {
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            rig.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isgrounded = false;
        }
    }

   private void temporizador()
    {
        if (timer > time)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            portao.transform.position = new Vector3(17.7f, 4.7f, -1.46f);
            timer = 0;


        }
    }

   

    public void reiniciar()
    {
        transform.position = new Vector3(8.04f, 1.2f, -1.4f);
    }

   

    private  void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "chão")
        {
            isgrounded = true;
        }
        if (collision.gameObject.tag == "placa")
        {
            
            portao.transform.Translate(Vector3.up * speedUp);
           
        }

        if(collision.gameObject.tag == "placa2")
        {
            portao2.transform.Translate(Vector3.up * speedUp);
        }

        if(collision.gameObject.tag == "laser")
        {
            diretor.reiniciarJogo(); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vitoria")
        {
            diretor.venceuJogo();
        }
    }
}
