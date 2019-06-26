using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	//生成点
	public GameObject BurnPoint;

	//鸡蛋
	public GameObject EggObj;


	//鸡蛋生成时间间隔
	public float BurnTime =3;
	//计时器
	private float _timer=0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		//设置云的运动

		transform.position += new Vector3 (2*Time.deltaTime,0,0);

		if(transform.position.x >5){
			print ("大于5了");
			//取左不取右  左开右合
			float randomNum = Random.Range (-10,0); 

			transform.position += new Vector3 (randomNum,0,0);
		}


		//恒定一秒钟付一次值
		_timer += Time.deltaTime;
		if(_timer>BurnTime){

			//鸡蛋的生成
			GameObject egg = Instantiate(EggObj);

			//设置鸡蛋的生成点
			egg.transform.position = BurnPoint.transform.position;




			_timer = 0;
		}
			
	

	}



}
