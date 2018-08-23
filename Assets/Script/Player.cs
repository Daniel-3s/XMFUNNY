using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int blood = 100;
    private int mood = 100;
    private int hunger = 100;
    public int Blood
    {
        get { return blood; }
        set { blood = value; }
    }
    public int Mood
    {
        get { return mood; }
        set { mood = value; }
    }
    public int Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.G))
        {
            int id = Random.Range(1, 3);
            Bag.Instance.StoreItem(id);
        }
	}
}
