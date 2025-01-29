using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
public class InputController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnJump = new UnityEvent();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         UnityEngine.Vector2 inputVector = UnityEngine.Vector2.zero; 

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += UnityEngine.Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += UnityEngine.Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += UnityEngine.Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += UnityEngine.Vector2.right;
        }

        OnMove?.Invoke(inputVector);
        if (Input.GetKeyDown(KeyCode.Space)){
            OnJump?.Invoke();
        }
    }
}
