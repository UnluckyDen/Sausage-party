using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Sausage : MonoBehaviour
    {
        public bool isGrounded;
        public bool isInAir;
        [SerializeField]
        public Rigidbody rigidBody;
        Movment movment;
        InputController input;
        TrajectoryRenderer trajectoryRenderer;

        // Start is called before the first frame update
        void Start()
        {
            input = FindObjectOfType<InputController>();
            rigidBody = gameObject.GetComponent<Rigidbody>();
            trajectoryRenderer = FindObjectOfType<TrajectoryRenderer>();
            movment = GetComponent<Movment>();
        }

        // Update is called once per frame
        void Update()
        {
            DrawTrajectory();
            Moving();
        }

        void DrawTrajectory()
        {
                trajectoryRenderer.ShowTrajectory(rigidBody.transform.position, input.inputDirection);
        }

        void Moving()
        {
            if (input.touchIsEnded)
            movment.Push(rigidBody, input.moveDirection, isGrounded);
            if (isInAir)
            {
                input.moveDirection = Vector2.zero;
                input.touchIsEnded = false;
            }
        }
    }
}