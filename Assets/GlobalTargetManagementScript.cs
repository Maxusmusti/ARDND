using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTargetManagementScript : MonoBehaviour {
	public ArrayList visibleObjects = new ArrayList();

	public void addObject(string name) {
		visibleObjects.Add (name);
		//Debug.Log (visibleObjects.Count);
	}

	public void removeObject(string name) {
		visibleObjects.Remove (name);
		//Debug.Log (visibleObjects.Count);
	}
}
