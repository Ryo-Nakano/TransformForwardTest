using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	[SerializeField] float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position += speed * transform.TransformDirection (Vector3.up);

		Move ();


	}

	//PLayerの移動
	void Move()
	{
		//y軸正方向に進む
		this.gameObject.transform.position += speed * transform.TransformDirection (Vector3.up);

		//右に進む
		if(Input.GetKeyDown("right") == true){
			//			transform.Rotate(new Vector3(0,1,0));
			this.transform.rotation = Quaternion.Euler(0, 0, 270);
		}

		//左に進む
		if(Input.GetKeyDown("left") == true){
			this.transform.rotation = Quaternion.Euler(0, 0, 90);
		}

		//上に進む
		if(Input.GetKeyDown("up") == true){
			this.transform.rotation = Quaternion.Euler(0, 0, 0);
		}

		//下に進む
		if(Input.GetKeyDown("down") == true){
			this.transform.rotation = Quaternion.Euler(0, 0, 180);
		}




	}


}
