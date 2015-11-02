using UnityEngine;
using System.Collections;

public class cameraSystem : MonoBehaviour {
	Vector3 deltMouse;
	Vector3 nowMouse;
	Vector3 edMouse;
	int frame;
	bool isDrag;
	bool isSetBom;
	float xspeed = 100f;
	float sx;
	float dx;
	float tx;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1)) {
			//Input Mouse position
			sx = Input.mousePosition.x;
		}
		//Drag
		if(Input.GetMouseButton(1)) {
			dx = Input.mousePosition.x;
			tx = sx - dx;
			//Rotate!
			GameObject.Find("cameraVector").transform.Rotate(0, tx / xspeed , 0);
		}

		if (isDrag) {
			isSetBom = false;
		}

		if (Input.GetMouseButtonDown (0) && isDrag == false) {
			//isDrag = true;
			frame = 0;
			isSetBom = true;
		}
		if (Input.GetMouseButtonUp(0)){
			isDrag = false;

		}

		if (Input.GetMouseButtonDown (1)) {
			isDrag = true;
			frame = 0;
		}
		if (Input.GetMouseButtonUp(1)){
			isDrag = false;
			
		}

		frame ++;
	}
}
