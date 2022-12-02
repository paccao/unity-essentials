using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown("space"))
		{
			SceneManager.LoadScene("FloorIsLava");
			print("Scene restarted");
		}
	}
}
