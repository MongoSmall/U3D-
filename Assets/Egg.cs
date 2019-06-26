using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		//三秒钟以后销毁自己
		Destroy (gameObject,3);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
