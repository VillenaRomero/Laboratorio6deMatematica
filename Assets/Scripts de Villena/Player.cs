using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public int lifeplayer = 3;
    public string scenefallide;
    public TextMeshProUGUI lifeText;

    void Start()
    {
        ScoreManager.life = lifeplayer; 
        UpdateLifeText();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            lifeplayer--;
            ScoreManager.life = lifeplayer; 
            UpdateLifeText();

            if (lifeplayer <= 0)
            {
                ScoreManager.points = FindFirstObjectByType<tiempo>().points;
                SceneManager.LoadScene(scenefallide);
            }
        }
    }

    void UpdateLifeText()
    {
        lifeText.text = "Vida: " + lifeplayer;
    }
}
