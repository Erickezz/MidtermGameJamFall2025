using UnityEngine;

public class diamonder : MonoBehaviour
{

    public GameObject diamond;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cubers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cubers()
    {
        Instantiate(diamond, new Vector2(Random.Range(-8f, 8f), 7f), diamond.transform.rotation);
    }
}
