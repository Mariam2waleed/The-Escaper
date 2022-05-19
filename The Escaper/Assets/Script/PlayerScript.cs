using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private int health=100;
    public Text healthText;
    public Slider healthSlider;
    public Camera mycamera;
    private AudioSource s;
    public AudioClip attackSound;

    public void Start(){
        s = mycamera.GetComponent<AudioSource>();

    }

    public void takeDamage(){
        health-=10;
        healthText.text= "Health "+health+"%";
        healthSlider.value =health/100f;
        s.PlayOneShot(attackSound);

        if (health == 0){
            SceneManager.LoadScene("LOSE");

        }
    }

    public void OnTrigger(Collider x){
        
    }

}
