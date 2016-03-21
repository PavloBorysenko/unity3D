using UnityEngine;
using System.Collections;

public class timerGame : MonoBehaviour {
    public float timeout = 20f;
    public AudioSource t;
    public AudioSource fon;
    public GameObject pers;
    public GameObject bascet;
    public TextMesh Tim;
    public TextMesh Score;
    public ballscript score;

	// Use this for initialization
	void Start () {
        fon.Play();
        Score.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (timeout > 0) {
            timeout -= Time.deltaTime;
            showTimer(timeout);
        }
        if (timeout < 6 && timeout > 5) {
            t.Play();
            
        }
        if (timeout <= 0) {
            fon.Pause();
            t.Pause();
            pers.SetActive(false);
          
            bascet.SetActive(false);
            showTimer(0.00f);
            ShowScore();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
           Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R)) { 
           Application.LoadLevel(0);
        }
            
	}
    public void showTimer(float count) {
        int min = 0;
        int sec = 0;
        int temp = (int)count;
        min = temp/60;
        sec = temp % 60;

        Tim.text = min.ToString()+":"+sec.ToString();
    
    }
    public void ShowScore(){
        Score.text= "Вы набрали: "+score.score+" очка(ов).\n Неплохо, но можно и больше!\n   R- попробовать еще ";
    }
}
