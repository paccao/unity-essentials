using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
	[SerializeField] private Vector3 rotateChange = new Vector3(0f, 1.8f, 0f);

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(rotateChange);
	}
}
