using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

	[Range(1.0f,100.0f)]
	public float speed;

	[Range(-5.0f, 5.0f)]
	public float fallSpeed;

	private float hor;
	private float ver;
	private Transform tform;

	// Use this for initialization
	void Start () {
		this.tform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		hor = Input.GetAxis ("Horizontal");
		ver = Input.GetAxis ("Vertical");
		tform.Translate (Vector3.right * hor * speed * Time.deltaTime);

	}
}
