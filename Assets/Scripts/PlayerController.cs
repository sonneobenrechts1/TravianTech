using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerController : MonoBehaviour
    {
        private bool _doAJump;

        private const float LANDED_Y = 0.5f;
        
        private float _jumpForce = 115f;

        [SerializeField]
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _doAJump = true;
            }
        }

        void FixedUpdate()
        {
            if (_doAJump)
            {
                Debug.Log("Jump");
                _rigidbody.AddForce(Vector3.up * _jumpForce * Time.fixedDeltaTime, ForceMode.Impulse);
                _doAJump = false;
            }

        }
    }
}