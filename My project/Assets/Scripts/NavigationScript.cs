using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public Transform destination;
    public float speed = 2f;

    void Update()
    {
        if (destination != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                destination.position,
                speed * Time.deltaTime
            );
        }
    }
}
