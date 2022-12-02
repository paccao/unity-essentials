using UnityEngine;

public class BallTransform : MonoBehaviour
{
	[SerializeField] private Vector3 scaleChange = new Vector3(0.0005f, 0.0005f, 0.0005f);

	// Update is called once per frame
	void Update()
	{
		transform.localScale += scaleChange;
	}
}
