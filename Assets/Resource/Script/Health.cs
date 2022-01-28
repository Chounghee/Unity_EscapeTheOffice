using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Slider healthbar;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            healthbar.value -= 0.1f;
        }
        HPcount();
        HPDown();
        
    }
    void HPcount()
    {
        healthbar.value -= 0.05f * Time.deltaTime;
    }
    public void HPup()
    {
        healthbar.value += 0.3f;
    }
    public void HPDown()
    {
        if (healthbar.value <= 0)
        {
            //GameObject.Find("Player").GetComponent<HeadMove>().speed0();
            SceneManager.LoadScene(2);

        }
    }
}
