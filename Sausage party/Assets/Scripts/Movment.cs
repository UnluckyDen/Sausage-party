using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Movment : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody rigidbody;
        [SerializeField]
        private float force;
        private InputController inputController;
        Sausage sausage;
        public Vector3 playerPosition;

        // Start is called before the first frame update
        void Start()
        {
            sausage = gameObject.GetComponent<Sausage>();
            inputController = FindObjectOfType<InputController>();
        }

        // Update is called once per frame
        void Update()
        {
            Push();
            PlayerPosition();
        }

        private void Push()
        {
            if (sausage.isGroundent && inputController.touchIsEnded)
            {
                rigidbody.AddForce(inputController.inputDirection * force);
                inputController.touchIsEnded = false;
            }
        }

        private void PlayerPosition()
        {
            playerPosition = rigidbody.transform.position;
        }
    }
}