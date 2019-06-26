using UnityEngine;
using System.Collections;

public class Bucket : MonoBehaviour {

	//速度 方向 时间 


	//向量 = 速度+方向

	//执行一次 当前脚本被执行到的第一帧时间
	// Use this for initialization
	void Start () {
	
		Debug.Log ("执行次数");

	}

	//执行完第一帧以后的每一帧
	// Update is called once per frame
	void Update () {
	
		//点击键盘A 
		if(Input.GetKey(KeyCode.A)){
			print ("AAAA执行次数");

			//position 是一个vector的结构体

			// = new Vector3(-2,0.7f,0)  坐标 一次性赋值时是一个坐标点
			// += new Vector3(-2,0,0);   向量  反复修改时是一个向量
			//Time.deltaTime 一秒钟执行一次
			transform.position += new Vector3(-5*Time.deltaTime,0,0);


		}

		if(Input.GetKey(KeyCode.D)){
			transform.position += new Vector3(5*Time.deltaTime,0,0);


		}



	}



}
