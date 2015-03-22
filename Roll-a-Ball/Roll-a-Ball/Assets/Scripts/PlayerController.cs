using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	public Rigidbody rb;
	public float speed;
	public Text ScoreText;

	private int count;




	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
	}

	void Update()
	{

	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

		rb.AddForce(movement*speed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText();
		}

	}

	void SetCountText()
	{
		ScoreText.text = "Count: " + count.ToString ();
	}

}
