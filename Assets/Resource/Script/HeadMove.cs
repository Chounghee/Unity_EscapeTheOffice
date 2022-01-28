using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 2.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    public GameObject scoreText;

    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    AudioSource audioSource;

    public GameObject Image;
    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
        
    }
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }
    void Update()
    {
        
        moveVector = Vector3.zero;
        
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.y = verticalVelocity;
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);

        LevelSound();
    }
    public void SetSpeed()
    {
        speed += 1f;
    }
    public void speed0()
    {
        speed = 0f;
    }
    public void speedReturn()
    {
        speed = 2.0f;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            PlaySound("Obs");          
            speed = 0.0f;
            Invoke("SceneChange", 0.2f);           
            
        }
        else if (other.gameObject.tag == "Heart")
        {
            PlaySound("heart");
            other.gameObject.SetActive(false);
            GameObject.Find("GameManager").GetComponent<Health>().HPup();
        }
        else if (other.gameObject.tag == "Coin")
        {
            PlaySound("coin");
            other.gameObject.SetActive(false);
            GameObject.Find("Player").GetComponent<Score>().coin();
        }
        else
        {
            scoreText.SetActive(false);
        }
        
    }
    void PlaySound(string action)
    {
        switch (action)
        {
            case "coin":
                audioSource.clip = audio1;
                break;
            case "heart":
                audioSource.clip = audio2;
                break;
            case "Obs":
                audioSource.clip = audio3;
                break;
            case "level":
                audioSource.clip = audio4;
                break;
        }
        audioSource.Play();
    }
    void SceneChange()
    {
        SceneManager.LoadScene(2);
    }
    public void LevelSound()
    {
        if (Score.Level >= Score.num)
        {
            PlaySound("level");
            Score.num++;
            Image.SetActive(true);
        }
        else
        {
            Image.SetActive(false);
        }
        
    }

}
