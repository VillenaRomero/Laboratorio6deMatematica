using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int lifeplayer;
    public string scenefallide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemigo")) {
            lifeplayer--;
            if (lifeplayer == 0) {
                SceneManager.LoadScene(scenefallide);
            }
        }
    }
}
