using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    void Start () {
        score = GetComponent<Text> ();
    }
    void Update()
    {
        score.text = scoreValue.ToString();
    }
}
