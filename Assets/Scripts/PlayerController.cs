using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float movementSpeed = 0.1f;
    [SerializeField] private float cameraSensibility = 0.1f;
    [SerializeField] private Rigidbody playerRigidbody;
    
    private float pitch = 0f;
    private float yawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotateCamera();
    }
    
    private void MovePlayer()
    {
        Vector3 CameraRight = cameraTransform.right;
        Vector3 CameraForward = cameraTransform.forward;
        
        //calcul déplacement joueur    
        Vector3 deltaPosition =
            new Vector3(CameraRight.x, 0f, CameraRight.z) * Input.GetAxis("Horizontal") +
            new Vector3(CameraForward.x, 0f, CameraForward.z) * Input.GetAxis("Vertical");
        
        playerRigidbody.MovePosition(
            playerRigidbody.position + deltaPosition * movementSpeed);
    }
    
    private void RotateCamera()
    {
        //rotation de la camera
        yawn += Input.GetAxis("Mouse X") * cameraSensibility;
        pitch -= Input.GetAxis("Mouse Y") * cameraSensibility;
        cameraTransform.eulerAngles = new Vector3(pitch, yawn, 0f);
    }
}
