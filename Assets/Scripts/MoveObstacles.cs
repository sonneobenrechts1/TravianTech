using UnityEngine;
namespace DefaultNamespace
{
    public class MoveObstacles : MonoBehaviour
    {
        void Update()
        {
            transform.Translate(Vector3.right *(-2) * Time.deltaTime, Space.World);
        }

    }
}