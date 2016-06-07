using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	public GameObject ApplePrefab;
	public float speed = 1f;
	public float leftAndRightEdge = 10f;
	public float chanceToChangeDirections = 0.1f;
	public float secondsBetweenAppleDrops = 1f;


	void Start () {
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	
	}
	void DropApple(){
		GameObject Apple = Instantiate (ApplePrefab) as GameObject;
		Apple.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		//change direction
		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs
				(speed);
			//move right
		} else
			if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs
				(speed);
			//move left
		}
	}
	void FixedUpdate(){
			if (Random.value < chanceToChangeDirections) {
				speed *= -1;
			}
	}
}
