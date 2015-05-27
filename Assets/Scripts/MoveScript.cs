using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// 1 - переменные
	
	/// <summary>
	/// Скорость объекта
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	/// <summary>
	/// Направление движения
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	
	private Vector2 movement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// 2 - Перемещение
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);

	}

	void FixedUpdate()
	{
		// Применить движение к Rigidbody
		Rigidbody2D rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
		rigidBody2D.velocity = movement;
	}
}
