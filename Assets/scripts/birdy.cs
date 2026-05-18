using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
      
 public float velocity = 1f;
    public Rigidbody2D rb2D;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.linearVelocity =Vector2.up * velocity;
        } 
    }
}
