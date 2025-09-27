using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedZ = 5f;
    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        rb.linearVelocity = new Vector3(0, 0, -speedZ);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="vacio" || collision.gameObject.tag=="playernave"){
            Destroy(gameObject);
        }
    }
}
