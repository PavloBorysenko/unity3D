using UnityEngine;
using System.Collections;

public class ballscript : MonoBehaviour {
    public int score = 0;
    public AudioSource pointsound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "basketball"||col.gameObject.name == "basketball (1)"||
            col.gameObject.name == "basketball (2)"||col.gameObject.name == "basketball (3)"||
            col.gameObject.name == "basketball (4)"||
            col.gameObject.name == "basketball (5)"||col.gameObject.name == "basketball (6)")
        {
            score++;
            pointsound.Play();
        }
    }
    void OnGUI() {
        GUI.Box(new Rect(0, 0, 100, 30), "Очки: " + score);
        GUI.Box(new Rect(0, 33, 100, 30), "R : Рестарт " );
    }
}
