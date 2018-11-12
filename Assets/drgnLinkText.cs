using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drgnLinkText : MonoBehaviour {

    public int index = 0;
	public TargetManagementScript tms;
	public GameObject parentObj;
	public GameObject ARcam;

	// Use this for initialization
	void Start () {
        GameObject text = new GameObject();
        TextMesh t = text.AddComponent<TextMesh>();
		text.transform.parent = parentObj.transform;
    //    t.text = "new text set";
        Debug.Log("Initialized");
        bool check = true;
        string[] stats = System.IO.File.ReadAllLines("Assets/MonsterData.txt");
        string textVal = ""; ;
		bool nameIsSimple = true;
        while (check)
        {
            //Debug.Log(index);
			if (stats[index].Split('\t')[0].Equals(tms.name))
            {
                textVal = stats[index];
				text.SetActive (true);
                check = false;
				nameIsSimple = false;
            }
            else
            {
                index++;
            }
            if (index >= stats.Length)
            {
				textVal = tms.name;
				Debug.Log (tms.name);
                check = false;
				nameIsSimple = true;
				//text.SetActive (false);

            }

        }
		if (nameIsSimple) {
			t.text = textVal;
		} else {
			t.text = textVal.Split('\t')[0] + "\t" + textVal.Split('\t')[1] + "\t" + textVal.Split('\t')[2] + "\n" + textVal.Split('\t')[3] + "\t" +  textVal.Split('\t')[4] + "\t" + textVal.Split('\t')[5] + "\t" + textVal.Split('\t')[6] + "\n" + textVal.Split('\t')[7] +  "\t" + textVal.Split('\t')[8] + "\t" + textVal.Split('\t')[9];

		}

        t.fontSize = 100;
		t.transform.localScale = new Vector3 (.01f, .01f, .01f);
        Debug.Log("CHECK CHECK CHECK");
		t.transform.localPosition += new Vector3(0f, 1f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
