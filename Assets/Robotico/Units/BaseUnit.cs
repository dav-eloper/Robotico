using UnityEngine;

public class BaseUnit : MonoBehaviour
{   
    // Update is called once per frame
    protected virtual void Update()
	{
        transform.rotation = Quaternion.Euler(0f, 90f * Time.unscaledTime, 0f);
		transform.position = new Vector3(Mathf.Cos(Time.unscaledTime), Mathf.Sin(Time.unscaledTime), 0.5f * Mathf.Cos(Time.unscaledTime));
	}
}
