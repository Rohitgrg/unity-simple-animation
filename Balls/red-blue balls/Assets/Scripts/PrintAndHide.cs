using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    public int i = 0;
    public new string name;
    int rnd;
    // Start is called before the first frame update
    void Start()
    {
        rnd = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        name = gameObject.name;
        Debug.Log(name + ":" + i);
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag.Equals("Blue") && i == rnd)
        {
            rend.enabled = false;
        }
        i++;
    }
}
