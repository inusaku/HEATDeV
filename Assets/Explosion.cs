using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float coefficient;   // 空気抵抗係数
	public float speed;         // 爆風の速さ
	public float timer;
	public bool isBom;

	void Start(){
		isBom = false;
		if(GameObject.Find("gameSystem").GetComponent<bomSetSystem>().kaisu == 0){
			speed = 50;
		}
		if(GameObject.Find("gameSystem").GetComponent<bomSetSystem>().kaisu == 1){
			speed = 100;
		}
		if(GameObject.Find("gameSystem").GetComponent<bomSetSystem>().kaisu == 2){
			speed = 400;
		}
	}

	void Update(){
		if(isBom == true){
			timer += Time.deltaTime;
		}
	}

	void OnTriggerStay(Collider col) {
		isBom = true;
		// 風速計算
		if(timer < 0.3f){
			var velocity = (col.transform.position - transform.position).normalized * speed;
			
			// 風力与える
			col.GetComponent<Rigidbody>().AddForce(velocity);
		}
	}
}