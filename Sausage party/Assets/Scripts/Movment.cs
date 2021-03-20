using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Movment : MonoBehaviour
    {
        [SerializeField]
        private float force;
        private InputController inputController;
        Sausage sausage;

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
        }

        private void Push()
        {
            if (sausage.isGroundent && inputController.touchIsEnded)
            {
                sausage.rigidBody.AddForce(inputController.moveDirection * force, ForceMode.Impulse);
                inputController.touchIsEnded = false;
            }
        }
    }
}