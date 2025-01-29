using System.Numerics;
using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float JumpSpeed = 4f;
    private bool isGrounded = true;

    void Start()
    {
        if (sphereRigidbody == null)
        {
            sphereRigidbody = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void MoveBall(UnityEngine.Vector2 input){
        UnityEngine.Vector3 inputXZPlane = new UnityEngine.Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane);
    }
    public void Jump()
    {
        if (isGrounded) 
        {
            sphereRigidbody.AddForce(UnityEngine.Vector3.up * JumpSpeed, ForceMode.Impulse);
            isGrounded = false; 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")) 
        {
            isGrounded = true;
        }
    }
}
