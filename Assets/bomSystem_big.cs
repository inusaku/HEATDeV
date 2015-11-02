using UnityEngine;
using System.Collections;

public class bomSystem_big : MonoBehaviour {
	GameObject bomber;
	GameObject bakuhu;
	float life;
	bool isTama;
	// Use this for initialization
	void Start () {
		life = 3.0f;
		isTama = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 0.0f && isTama == false) {
			bakuhu = Instantiate (
				Resources.Load ("prefab/bakuhatu_big"),
				this.transform.position,
				Quaternion.identity)as GameObject;
		}
		life -= 0.1f * Time.deltaTime * 60.0f;
		if(life < -0.11f){
			Destroy(this.gameObject);
		}
	}
	void OnTriggerStay(Collider collision){
		if(collision.gameObject.tag == "tama"){
			Debug.Log ("" + isTama);
			isTama = true;
			life = 0f;
			bomber = Instantiate(
				Resources.Load ("prefab/bakuhatu_big"),
				this.transform.position,
				Quaternion.identity)as GameObject;	
		}
	}
}
