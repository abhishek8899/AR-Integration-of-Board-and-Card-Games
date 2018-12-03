using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bu : MonoBehaviour {

	public information[] items;
    private static List<information> cardsrecog;
    public Text character;
    public int allowed = 0;
    public static List<Button> buttons;
    public static Button dhaniya;
    public static GameObject go;

    public GameObject Allfruits1;
    public GameObject Canvas1;
    public GameObject Result;

    public Toggle carbohydrate;
    public Toggle protein;
    public Toggle fats;
    public Toggle vitaminA;
    public Toggle vitaminB;
    public Toggle vitaminC;

    void start()
    {
        
    }
   // public void selectbutton()
   // {
        //character = go.FindGameObjectWithTag("dhaniya").GetComponent<Text>();
        //character = dhaniya.GetComponent<Text>();
        //Debug.Log(character.text);
   // }

    public void Toggle_change()
    {
        if (carbohydrate.isOn)
        {
            int fg = PlayerPrefs.GetInt("flag1");
            if (fg == 1)
                PlayerPrefs.SetString("category", "carbohydrate");
            Debug.Log("carbohydrate");
        }
        if (protein.isOn)
        {
            int fg = PlayerPrefs.GetInt("flag1");
            if (fg == 1)
                PlayerPrefs.SetString("category", "protein");
            Debug.Log("protein");
        }
        if (fats.isOn)
        {
            int fg = PlayerPrefs.GetInt("flag1");
            if (fg == 1)
                PlayerPrefs.SetString("category", "fats");
            Debug.Log("fats");
        }
        if (vitaminA.isOn)
        {
            int fg = PlayerPrefs.GetInt("flag1");
            if (fg == 1)
                PlayerPrefs.SetString("category", "vitamina");
            Debug.Log("vitaminA");
        }
        if (vitaminB.isOn)
        {
            int fg = PlayerPrefs.GetInt("flag1");
            if (fg == 1)
                PlayerPrefs.SetString("category", "vitaminb");
            Debug.Log("vitaminB");
        }
        if (vitaminC.isOn)
        {
            int fg = PlayerPrefs.GetInt("flag1");
            if (fg == 1)
                PlayerPrefs.SetString("category", "vitaminc");
            Debug.Log("vitaminC");
        }
    }

    public void show_categorys()
    {
        Result.transform.gameObject.SetActive(false);
        Canvas1.transform.gameObject.SetActive(true);
        Allfruits1.transform.gameObject.SetActive(false);
    }
    public void show_fruits()
    {
        Result.transform.gameObject.SetActive(false);
        Canvas1.transform.gameObject.SetActive(false);
        Allfruits1.transform.gameObject.SetActive(true);
    }

    public void resetbutton()
    {
        PlayerPrefs.SetInt("winnervalue", -1);
        PlayerPrefs.SetString("winner", "NoneTillNow");
        PlayerPrefs.SetInt("flag1", 1);
        Result.transform.gameObject.SetActive(false);
        Canvas1.transform.gameObject.SetActive(false);
        Allfruits1.transform.gameObject.SetActive(true);
        return;
    }

    public void selectbutton()
    {
        Debug.Log("Toggled");
        int fg = PlayerPrefs.GetInt("flag1");
        Debug.Log("ifnved");
        //Debug.Log(fg);
        if (fg == 1)
        {
            int protein_value = PlayerPrefs.GetInt("pvalue");
            int carbo_value = PlayerPrefs.GetInt("cvalue");
            int fats_value = PlayerPrefs.GetInt("fvalue");
            int vita_value = PlayerPrefs.GetInt("vitavalue");
            int vitb_value = PlayerPrefs.GetInt("vitbvalue");
            int vitc_value = PlayerPrefs.GetInt("vitcvalue");
            PlayerPrefs.SetInt("flag1", 2);
            if (PlayerPrefs.GetString("category") == "carbohydrate")
            {
                PlayerPrefs.SetInt("winnervalue", carbo_value);
            }
            if (PlayerPrefs.GetString("category") == "protein")
            {
                PlayerPrefs.SetInt("winnervalue", protein_value);
            }
            if (PlayerPrefs.GetString("category") == "fats")
            {
                PlayerPrefs.SetInt("winnervalue", fats_value);
                Debug.Log(fats_value);
            }
            if (PlayerPrefs.GetString("category") == "vitamina")
            {
                PlayerPrefs.SetInt("winnervalue", vita_value);
            }
            if (PlayerPrefs.GetString("category") == "vitaminb")
            {
                PlayerPrefs.SetInt("winnervalue", vitb_value);
            }
            if (PlayerPrefs.GetString("category") == "vitaminc")
            {
                PlayerPrefs.SetInt("winnervalue", vitc_value);
            }

            PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
            Allfruits1.transform.gameObject.SetActive(true);
            Canvas1.transform.gameObject.SetActive(false);
            return;
        }
       // if (fg >= 2)
        //{
            PlayerPrefs.SetInt("flag1", 0);
            int carbo = PlayerPrefs.GetInt("cvalue");
            int protein = PlayerPrefs.GetInt("pvalue");
            int fats = PlayerPrefs.GetInt("fvalue");
            int vitamina = PlayerPrefs.GetInt("vitavalue");
            int vitaminb = PlayerPrefs.GetInt("vitbvalue");
            int vitaminc = PlayerPrefs.GetInt("vitcvalue");
            if (PlayerPrefs.GetString("category") == "carbohydrate")
            {
                Debug.Log("categorycarbohydrate");
                if (PlayerPrefs.GetInt("winnervalue") < carbo)
                {
                    PlayerPrefs.SetInt("winnervalue", carbo);
                    PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
                }
            }
            if (PlayerPrefs.GetString("category") == "protein")
            {
                Debug.Log("categoryprotein");
                if (PlayerPrefs.GetInt("winnervalue") < protein)
                {
                    PlayerPrefs.SetInt("winnervalue", protein);
                    PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
                }
            }
            if (PlayerPrefs.GetString("category") == "fats")
            {
                Debug.Log("categoryfats");
                if (PlayerPrefs.GetInt("winnervalue") < fats)
                {
                    PlayerPrefs.SetInt("winnervalue", fats);
                    PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
                }
            }
            if (PlayerPrefs.GetString("category") == "vitamina")
            {
                Debug.Log("categoryvitamina");
                if (PlayerPrefs.GetInt("winnervalue") < vitamina)
                {
                    PlayerPrefs.SetInt("winnervalue", vitaminb);
                    PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
                }
            }
            if (PlayerPrefs.GetString("category") == "vitaminb")
            {
                Debug.Log("categoryvitaminb");
                if (PlayerPrefs.GetInt("winnervalue") < vitaminb)
                {
                    PlayerPrefs.SetInt("winnervalue", vitaminb);
                    PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
                }
            }
            if (PlayerPrefs.GetString("category") == "vitaminc")
            {
                Debug.Log("categoryvitaminc");
                if (PlayerPrefs.GetInt("winnervalue") < vitaminc)
                {
                    PlayerPrefs.SetInt("winnervalue", vitaminc);
                    PlayerPrefs.SetString("winner", PlayerPrefs.GetString("iname"));
                }
            }
        Result.transform.gameObject.SetActive(true);
            Canvas1.transform.gameObject.SetActive(false);
            Allfruits1.transform.gameObject.SetActive(false);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       // }
       // Toggle_change();
    }
}
