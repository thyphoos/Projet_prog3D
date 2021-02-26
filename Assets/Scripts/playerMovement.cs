using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;
    
    public int cptsquelette = 0;
    public int cptkey=0;
    public int cptcible=1;
    public bool isciblepresent = false;
    [SerializeField] private TextMeshProUGUI keysNumber;
    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -10f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
         if (cptsquelette==6)
        {
            switch (cptcible)
            {
                case 1 :
                    if (isciblepresent == false)
                    {
                        GameObject cible1 = (GameObject) Instantiate(Resources.Load("cible"),new Vector3(40, 10, 25),Quaternion.identity);
                        cible1.transform.Rotate(0,0,90);
                        isciblepresent = true;
                    }
                   
                    break;
                
                case 2 : 
                    if (isciblepresent == false)
                    {
                        GameObject cible2 = (GameObject) Instantiate(Resources.Load("cible"),new Vector3(25, 10, 36.30f),Quaternion.identity);
                        cible2.transform.Rotate(0,0,90);
                        isciblepresent = true;
                    }
                    break;
                case 3: 
                if (isciblepresent == false)
                {
                    GameObject cible3 = (GameObject) Instantiate(Resources.Load("cible"),new Vector3(-11.6f, 2.88f, 63f),Quaternion.identity);
                    cible3.transform.Rotate(0,90,90);
                    isciblepresent = true;
                }
                break;
                case 4 : 
                if (isciblepresent == false)
                {
                    GameObject cible4 = (GameObject) Instantiate(Resources.Load("cible"),new Vector3(-7, 5, 25),Quaternion.identity);
                    cible4.transform.Rotate(0,0,90);
                    isciblepresent = true;
                }
                break;
                case 5 : 
                if (isciblepresent == false)
                {
                    GameObject cible5 = (GameObject) Instantiate(Resources.Load("cible"),new Vector3(-22, 12.25f, 18),Quaternion.identity);
                    cible5.transform.Rotate(0,0,45);
                    isciblepresent = true;
                }
                break;
                
                case 6 : 
                    float a = Random.Range(0, 360);
                    float b = Random.Range(0, 360);
                    float c = Random.Range(0, 360);
                
                    Instantiate(Resources.Load("key"), new Vector3(-22, 12.25f, 18), Quaternion.Euler(a,b,c));
                    cptcible++;
                    break;
            }

        }
         
         keysNumber.text = $"{cptkey}/3";

    }

    private void Start()
    {
        Instantiate(Resources.Load("key"), new Vector3(-12, 10, 6), Quaternion.Euler(-12,10,6));
    }
}
