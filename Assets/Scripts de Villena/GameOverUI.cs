using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public TMP_Text pointsText;

    void Start()
    {
        pointsText.text = "Puntos conseguidos: " + ScoreManager.points;
    }
}
