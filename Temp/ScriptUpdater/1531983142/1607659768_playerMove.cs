using UnityEngine;

public class playerMove : MonoBehaviour
{

    Rigidbody2D body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = transform.GetComponet<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.linearVelocity = new Vector3(Input.GetAxis("Horizontal"),body.linearVelocity.y);
    }
}
