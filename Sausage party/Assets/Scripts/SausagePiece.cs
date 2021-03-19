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
                sausage.isGroundent = true;
            }
        }
        private void OnCollisionExit(Collision collision)
        {
            if(collision.collider.CompareTag("Floor"))
            sausage.isGroundent = false;
        }
    }
}