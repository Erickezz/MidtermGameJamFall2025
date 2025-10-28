using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class gameengine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D rb;
    public float movespeed;
    private Vector2 _movedirection;
    public InputActionReference move;
    public GameObject Cubers;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(x:_movedirection.x*movespeed,y:_movedirection.y*movespeed);
    }

    private void FixedUpdate()
    {
        _movedirection = move.action.ReadValue<Vector2>();

    }
    
}
