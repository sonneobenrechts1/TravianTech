using UnityEngine;

namespace DefaultNamespace
{
    public class CameraController : MonoBehaviour
    {
        public Transform target;

        void LateUpdate()
        {
            var newPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = newPosition;
            transform.LookAt(target);
        }

    }
}