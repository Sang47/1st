using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	/// 1 - скорость движения
	public Vector2 speed = new Vector2(50, 50);
	
	// 2 - направление движения
	private Vector2 movement;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 3 -  извлечь информацию оси
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - движение в каждом направлении
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}

	void FixedUpdate() {
		// 5 - перемещение игрового объекта
		//Rigidbody2D rigidBody2D;
		//rigidBody2D = gameObject.GetComponent<"Rigidbody2D">();
		Rigidbody2D rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
		rigidBody2D.velocity = movement;
	}
}
