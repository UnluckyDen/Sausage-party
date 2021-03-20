using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Movment : MonoBehaviour
    {
        [SerializeField]
        private float force;

        public void Push(Rigidbody rigidBody,Vector2 direction, bool isGrounded)
        {
            if (isGrounded)
            {
                rigidBody.AddForce(direction * force, ForceMode.Impulse);
            }
        }
    }
}