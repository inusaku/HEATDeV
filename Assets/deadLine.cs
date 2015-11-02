using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deadLine : MonoBehaviour {
	private Slider slider;
	float sliVal;
	int stageCount;
	// Use this for initialization
	void Start () {
		slider = GameObject.Find("stageSlider").GetComponent<Slider>();
		stageCount = GameObject.FindGameObjectsWithTag("stage").Length - 1;
		slider.maxValue = stageCount;
		sliVal = stageCount;
	}
	
	// Update is called once per frame
	void Update () {
		stageCount = GameObject.FindGameObjectsWithTag("stage").Length - 1;
		if(sliVal > stageCount){
			sliVal -= 0.5f;
		}
		slider.value = sliVal;
	}
	void OnCollisionStay(Collision collision){
		Destroy (collision.gameObject);
	}
}
