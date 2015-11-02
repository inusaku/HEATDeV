using UnityEngine;
using System.Collections;

public class bomSetSystem : MonoBehaviour {
	GameObject bom;
	Vector3 hitPos;
	public int kaisu;
	void Start () {
		kaisu = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if (Physics.Raycast(ray,out hit)){
				hitPos = hit.point;
				if(hit.collider.gameObject.tag == "stage"){
					if(kaisu == 0){
					bom = Instantiate(
						Resources.Load("bom_small"),
						hitPos,
						Quaternion.identity)as GameObject;	
					}
					if(kaisu == 1){
						bom = Instantiate(
							Resources.Load("bom_middle"),
							hitPos,
							Quaternion.identity)as GameObject;	
					}
					if(kaisu == 2){
						bom = Instantiate(
							Resources.Load("bom_big"),
							hitPos,
							Quaternion.identity)as GameObject;	
					}
				}
			}

		}
	}
	public void bomChange(){
		kaisu ++;
		if(kaisu == 3){
			kaisu = 0;
		}
	}
}

