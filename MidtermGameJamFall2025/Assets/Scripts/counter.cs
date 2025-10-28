using NUnit.Framework.Constraints;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour
{
    public GameObject Diamond;
    public TextMeshProUGUI Counter;
    public int score;

    public counter counterscript;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Counter.text = "Spikes Dodged " + score;
    }
    public void Spawncube()
    {
        Instantiate(Diamond, new Vector2(Random.Range(-8f, 8f), 7f), Random.rotation);

    }
    private void OnTriggerEnter2D(Collider2D Collision) 
    {
        SceneManager.LoadScene("gameover");
    }
}
