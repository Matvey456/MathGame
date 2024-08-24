using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public void GetScore(TMP_Text scoreText)
    {
        scoreText.text = $"Iq: {StaticHolder.iq}";
    }
}
