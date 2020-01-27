using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICompanyName : MonoBehaviour
{

    public static UICompanyName isntanceUI;
    public Text CompanyName_field;
    public GameObject CompanyName;
    public GameObject Ui;
    

    public void toGame()
    {
        DontDestroyOnLoad(CompanyName);
        DontDestroyOnLoad(Ui);
        SceneManager.LoadScene("SampleScene");
    }

    void Awake ()
    {
        if (isntanceUI == null)
        {
            isntanceUI = this;
        } else if (isntanceUI != this)
        {
            Destroy(gameObject);
        }
        
    }


}
