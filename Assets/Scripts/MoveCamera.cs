using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	[SerializeField] private float speed = 1.5f;
	private float X;
	private float Y;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * speed, Input.GetAxis("Mouse X") * speed, 0));
			X = transform.rotation.eulerAngles.x;
			Y = transform.rotation.eulerAngles.y;
			transform.rotation = Quaternion.Euler(X, Y, 0);
		}
	}
}
