using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOne : MonoBehaviour
{

    public GameObject spawnCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("w"))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("d"))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("a"))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("f"))
        {
            print("You pressed F");
        }
    }
    public void printTextB()
    {
        print("Why did you click");
    }
    public void playSound()
    {
        GetComponent<AudioSource>().Play();
        print("sound is playing");
    }
    public void spawnRedCube()
    {
            Instantiate(spawnCube, new Vector3(5, 5, 5), Quaternion.identity);
    }

    public void spawn100RedCube()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(spawnCube, new Vector3(5, 5, 5), Quaternion.identity);
        }

    }

}
