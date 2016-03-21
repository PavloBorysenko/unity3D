using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {
    public GameObject o;
	// Use this for initialization
  
	void Start () {
        o = GameObject.Find("my_game");
        
	}
	
	// Update is called once per frame
	void Update () {

	
	}
    void OnMouseDown()
    {
        o.GetComponent<general>().igual(this.gameObject.name);
       
    }
}
