using UnityEngine;
using TMPro;

public class tiempo : MonoBehaviour
{
    public TMP_Text textpoints;
    public int points;
    public int pointsPerSecond = 1;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            points += pointsPerSecond;
            textpoints.text = "Puntos: " + points;
            timer = 0f;
        }
    }
}
