using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICompanyName : MonoBehaviour
{

    public static UICompanyName instanceUI;
    public InputField inputField;
    public string CompanyName_field;
    public GameObject CompanyName;
    

    public void toGame()
    {
        PlayerPrefs.SetString ("CompanyName", CompanyName_field);
        DontDestroyOnLoad(CompanyName);
        SceneManager.LoadScene("SampleScene");
    }

    void Awake ()
    {
        if (instanceUI == null)
        {
            instanceUI = this;
        } else if (instanceUI != this)
        {
            Destroy(gameObject);
        }
        
    }
    
    /*void Start()
    {
        CompanyNamed = true;
    }*/

    void Update()
    {
        if (CompanyName_field != inputField.text)
        {
            CompanyName_field = inputField.text;
        }
    }


}
