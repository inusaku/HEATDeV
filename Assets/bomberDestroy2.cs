using UnityEngine;
using System.Collections;

public class bomberDestroy2 : MonoBehaviour {
	float life;
	GameObject[] bomber;
	// Use this for initialization
	void Start () {
		life = 3.0f;
		int count = 0;
		foreach (Transform child in transform)
		{
			//child is your child transform
			child.transform.localPosition = new Vector3(
				Random.Range(-0.1f, 0.1f),
				Random.Range(-0.1f, 0.1f),
				Random.Range(-0.1f, 0.1f)
				);
			//Debug.Log ("Child[" + count + "]:" + child.name);
			count++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 0.0f) {
			Destroy(this.gameObject);
		}
		life -= 0.1f * Time.deltaTime * 60.0f;
	}
}