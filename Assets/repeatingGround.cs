using UnityEngine;
using System.Collections;

public class repeatingGround : MonoBehaviour {
	public GameObject player;
	public GameObject ground;
	public GameObject sphere;
	Transform car;
	Transform ground1;
	Transform spherePos;
	private Vector3 startPos;
	// Use this for initialization
	void Start () {
		car = player.GetComponent<Transform> ();
		ground1 = ground.GetComponent<Transform> ();
		spherePos = sphere.GetComponent<Transform> ();
		startPos = car.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Mathf.Abs(car.position.x - startPos.x) > 40
			|| Mathf.Abs(car.position.z - startPos.z) > 40) {	
			ground1.position = new Vector3 (spherePos.position.x,
				-2.5f,
				spherePos.position.z);

			startPos = car.position;
		}
	}
}
