using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(Button))]

public class dhaniyascript : MonoBehaviour {

    // Use this for initialization
    public Button actionButton1;
    //public GameObject textdisplay;
    public information dhaniya;
    public information wheat;

    public Text displaytext;
    public Text display_carbohydrate;
    public Text display_protein;
    public Text display_vitamina;
    public Text display_vitaminb;
    public Text display_vitaminc;
    public Text display_fats;

    public GameObject Canvas1;
    public GameObject Allfruits1;

    //public AudioClip sound;
    //private Button button { get { return GetComponent<Button>(); } }
    //private AudioSource source { get { return GetComponent<AudioSource>(); } }

    string readpath;
    string writepath;

    List<information> Details = new List<information>();

    void Start ()
    {
        Details.Add(dhaniya);
        Details.Add(wheat);
        if (PlayerPrefs.GetInt("flag1") == 0)
            PlayerPrefs.SetInt("flag1", 1);
        Initializevalues();
        //gameObject.AddComponent<AudioSource>();
        //sound.clip = sound;
        //source.playOnAwake = false;
        actionButton1.onClick.AddListener(() => { Displaycharacter(this.gameObject); });
    }

    void Initializevalues()
    {
        dhaniya.item = "dhaniya";
        //dhaniya.carbohydrates = 6;
        //dhaniya.protein = 3;
        wheat.item = "wheat";
        //wheat.carbohydrates = 71;
        //wheat.protein = 1;
    }

    
    void Displaycharacter (GameObject a)
    {
        //Debug.Log(a.name);
        //source.playOneShot(sound);
        TextAsset flag1 = Resources.Load<TextAsset>("flag");
        string[] data = flag1.text.Split(new char[] { '\n' });
        string car,pro;
        //Debug.Log(data[0]);
        //Debug.Log(data.Length);
        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            if(row[0]==a.name)
            {
                display_carbohydrate.text = row[1];
                display_protein.text = row[2];
                display_vitamina.text = row[3];
                display_vitaminb.text = row[4];
                display_vitaminc.text = row[5];
                display_fats.text = row[6];
                Debug.Log(row[1]);
                Debug.Log(row[2]);
                Debug.Log(row[3]);
                Debug.Log(row[4]);
                Debug.Log(row[5]);
                Debug.Log(row[6]);
                break;
            }
        }
        displaytext.text = a.name;
        int tmp;
        //information temp = Details.Where(obj => obj.item == a.name).SingleOrDefault();
        PlayerPrefs.SetString("iname", displaytext.text);
        int.TryParse(display_carbohydrate.text, out tmp);
        PlayerPrefs.SetInt("cvalue", tmp);
        int.TryParse(display_protein.text, out tmp);
        PlayerPrefs.SetInt("pvalue", tmp);
        int.TryParse(display_fats.text, out tmp);
        PlayerPrefs.SetInt("fvalue", tmp);
        int.TryParse(display_vitamina.text, out tmp);
        PlayerPrefs.SetInt("vitavalue", tmp);
        int.TryParse(display_vitaminb.text, out tmp);
        PlayerPrefs.SetInt("vitbvalue", tmp);
        int.TryParse(display_vitaminc.text, out tmp);
        PlayerPrefs.SetInt("vitcvalue", tmp);
    }

    public void showResult()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
