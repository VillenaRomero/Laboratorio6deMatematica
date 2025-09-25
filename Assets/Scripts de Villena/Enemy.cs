using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int velocity;
    public int speedz;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity =speedz * velocity;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("vacio") || other.CompareTag("playernave")) {
            Destroy(gameObject);
        }
    }
}
