using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class SausagePiece : MonoBehaviour
    {
        private Sausage sausage;
        // Start is called before the first frame update
        void Start()
        {
            sausage = GetComponentInParent<Sausage>();
        }

        private void OnCollisionStay(Collision collision)
        {
            if (collision.collider.CompareTag("Floor"))
            {
                sausage.isGrounded = true;
                sausage.isInAir = false;
                sausage.landing = false;
            }
        }
        private void OnCollisionExit(Collision collision)
        {
            if (collision.collider.CompareTag("Floor"))
            {
                sausage.isGrounded = false;
                sausage.isInAir = true;
                sausage.landing = false;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Floor"))
            {
                sausage.landing = true;
            }
        }
    }
}