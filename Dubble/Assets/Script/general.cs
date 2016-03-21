using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class general : MonoBehaviour {
    //public Texture2D img;
    //public GameObject obg;
	// Use this for initialization
    public TextMesh Tim;
    public TextMesh Score;
    public TextMesh startText;
    public float timeout ;
    public AudioSource t;
    int score;

    GameObject[] main=new GameObject[8] ;
    GameObject[] pole = new GameObject[8];
    public GameObject temp;
    
    public List<Sprite> img;
    bool game = false;
	void Start () {
        for (int i = 0; i < 8; i++) {
           main[i]= GameObject.Find("main"+(i+1));
           pole[i] = GameObject.Find("pole" + (i + 1));

        }
       Enar_mass();
       score = 0;
       timeout = 0;
        //Material m = obg.GetComponent<Material>();
        //m.mainTexture = img;

	}
	
	// Update is called once per frame
	void Update () {
        if (game)
        {
            startText.text = "";
        }
        else {
            
            
            startText.text = "Для старта нажмите \n пробел";
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Space) && (!game))
        {
            game = true;
            score = 0;
            timeout = 120f;
            showScore();
            Enar_mass();
        }

        if (timeout > 0)
        {
            timeout -= Time.deltaTime;
            showTimer(timeout);
        }
        if (timeout <= 0)
        {
            game = false;
        }
      
	}
   public void Enar_mass() {
        int i = 0;
        List<int> zap = new List<int>();
        for (; ;) {
            bool doble = false;
            int j = Random.Range(0, 42);
            foreach (int n in zap) {
                if (n == j) {
                    doble = true;
                }
            }
            if (doble) {
                continue;
            }
            if (i < 8) {
                SpriteRenderer m = main[i].GetComponent<SpriteRenderer>();
                m.sprite = img[j];
                zap.Add(j);
                i++;
                Debug.Log(i);
            }
            else if (i >= 8 && i < 16) {
                SpriteRenderer m = pole[i - 8].GetComponent<SpriteRenderer>();
                m.sprite = img[j];
                zap.Add(j);
                i++;
            }
            if (i >= 16) {
                break;
            }
        }
        int x = Random.Range(0, 8);
        int y = Random.Range(0, 8);
        SpriteRenderer tempimg = pole[x].GetComponent<SpriteRenderer>();
        SpriteRenderer tempind2 = main[y].GetComponent<SpriteRenderer>();
        tempind2.sprite = tempimg.sprite;
        temp = main[y];


        for (int z = 0; z < 8; z++) { 
        moveobg(main[z]);
        moveobg(pole[z]);
        
        }

       // moveobg(pole[x]);
    }
   public void moveobg(GameObject item) {
       Transform t = item.GetComponent<Transform>();
      // float[] size1 = {0.95f,0.8f,0.7f };
       float size = Random.Range(0.95f, 0.50f);
     //  float size1 = float.Parse(size / 100);
      // Debug.Log(size);
       t.localScale = new Vector3(size, size, 1f);
       t.eulerAngles = new Vector3(0, 0, Random.Range(0, 350));
   
   }
  public void igual(string name){
      if (game) { 
      if(temp.gameObject.name==name){ 
      score++;
      t.Play();
      showScore();
      Enar_mass();
     
     }
     }
  }
  public void showTimer(float count)
  {
      int min = 0;
      int sec = 0;
      int temp = (int)count;
      min = temp / 60;
      sec = temp % 60;

      Tim.text = min.ToString() + ":" + sec.ToString();

  }
  public void showScore() {
      Score.text = score.ToString();
  }

}
