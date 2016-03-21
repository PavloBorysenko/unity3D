using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
    public TextMesh textStart;

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;

    public GameObject hero;

    public GameObject timeStart;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject tir1;
    public GameObject tir2;
    public GameObject tir3;
    public GameObject fonar;
    public GameObject statu;
    public GameObject kanistra;
    public GameObject moto;
    



	// Use this for initialization
	void Start () {
        textStart.text = "Забейте  как можно больше мячей!!!)))\n Для старта нажмите пробел";   

	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ball1.SetActive(true);
            ball2.SetActive(true);
            ball3.SetActive(true);
            ball4.SetActive(true);
            ball5.SetActive(true);
            ball6.SetActive(true);

            textStart.text = "";

            hero.SetActive(true);
            box1.SetActive(true); 
            box2.SetActive(true); 
            box3.SetActive(true); 
            tir1.SetActive(true); 
            tir2.SetActive(true); 
            tir3.SetActive(true); 
            fonar.SetActive(true); 
            statu.SetActive(true); 
            kanistra.SetActive(true); 
            moto.SetActive(true); 



            timeStart.SetActive(true);
        }
	
	}
}
