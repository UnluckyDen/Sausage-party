using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Movment : MonoBehaviour
    {
        public Rigidbody rigidbody;
        private InputController inputController;

        // Start is called before the first frame update
        void Start()
        {
            inputController = FindObjectOfType<InputController>();
        }

        // Update is called once per frame
        void Update()
        {
            rigidbody.AddForce(inputController.inputDirection * 1000);
        }
    }
}