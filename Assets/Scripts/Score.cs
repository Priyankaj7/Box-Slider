using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Score : MonoBehaviour {

    public float scorecount;
    public float hiscorecount;
    public float pointsps;
    public Text scoretext;
    public Text HighScore;
    public bool pointsincrese;

    void Start()
    {
        if (PlayerPrefs.GetFloat("HighScore") != null)
        {
            hiscorecount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update () {

        if (pointsincrese)
        {
            scorecount += pointsps = Time.deltaTime;
        }
        if (scorecount > hiscorecount)
        {
            hiscorecount = scorecount;
            PlayerPrefs.SetFloat("HighScore", hiscorecount);
        }
        scoretext.text = "Score : " + Mathf.Round(scorecount);
        HighScore.text = "Best Score : " + Mathf.Round(hiscorecount);
		
	}
}
