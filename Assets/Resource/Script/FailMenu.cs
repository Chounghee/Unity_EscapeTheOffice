using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FailMenu : MonoBehaviour
{
    public GameObject menuSet;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            Fail();
        
    }
    public void Fail()
    {
        
        if (menuSet.activeSelf)
        {           
            menuSet.SetActive(false);
            GameObject.Find("Player").GetComponent<HeadMove>().speedReturn();
            Time.timeScale = 1;
        }
        else
        {           
            menuSet.SetActive(true);
            GameObject.Find("Player").GetComponent<HeadMove>().speed0();
            Time.timeScale = 0;
        }          
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    
}
