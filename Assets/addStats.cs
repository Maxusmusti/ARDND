using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addStats : MonoBehaviour {

    public Text text;
    public int index = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("Initialized");
        bool check = true;
        string[] stats = System.IO.File.ReadAllLines("MonsterData.txt");
        while (check)
        {
            Debug.Log(index);
            if (stats[index].Split('\t')[0].Equals("Swarm of Bats"))
            {
                text.text = stats[index];
                check = false;
            }
            else
            {
                index++;
            }
            if (index >= stats.Length)
            {
                check = false;
                text.text = "ERROR";
            }

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
