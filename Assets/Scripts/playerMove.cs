using UnityEngine;

public class playerMove : MonoBehaviour
{

    Rigidbody2D body;

    [SerializeField] float speed;

    float poisonTime = 0;
    float maxPoisonTime = 1;

    public int money;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * speed,body.linearVelocity.y);
        if (poisonTime >= maxPoisonTime){
            Debug.Log("You Died!");
            transform.position = Vector3.zero;
            poisonTime = 0;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("poison"))
        {
            poisonTime += Time.deltaTime;
        }
        if (other.gameObject.CompareTag("coin"))
        {
            money += 1;
            Destroy(other.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("poison"))
        {
            poisonTime = 0;
        }
    }
}
