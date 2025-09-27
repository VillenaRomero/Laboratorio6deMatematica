using UnityEngine;

public class spawenemy : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float minYposition;
    public float maxYposition;
    public float Zposition;
    private void Start()
    {
        Createenemy();
    }

    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        float yposition = Random.Range(minYposition, maxYposition);

        Vector3 positioncreate = new Vector3(xposition, yposition, Zposition);

        GameObject enemigo = Instantiate(prefabEnemy, positioncreate, transform.rotation);

        Invoke("Createenemy", 1.5f);
    }
}
