using UnityEngine;
using System.Collections;

public class proba : MonoBehaviour {
    public GameObject obg;
    public Sprite img;
	// Use this for initialization
	void Start () {


        SpriteRenderer m1 = obg.GetComponent<SpriteRenderer>();
        m1.sprite = img;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
