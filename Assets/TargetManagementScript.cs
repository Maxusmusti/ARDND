using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManagementScript : MonoBehaviour {
	public bool isVisible;
	public string name;
	public GlobalTargetManagementScript parent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setVisible() {
		isVisible = true;
		parent.addObject (name);
	}
	public void setInvisible() {
		isVisible = false;
		parent.removeObject (name);
	}
}
