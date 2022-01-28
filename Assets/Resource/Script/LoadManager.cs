using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickBack()
    {
        Debug.Log("다시하기");
        SceneManager.LoadScene(1);
    }
    public void OnClickMenu()
    {
        Debug.Log("메인메뉴");
        SceneManager.LoadScene(0);
    }
}
