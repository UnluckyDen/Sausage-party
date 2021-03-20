using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Sausage : MonoBehaviour
    {
        public bool isGrounded;
        public bool isInAir;
        public bool landing;
        [SerializeField]
        public Rigidbody rigidBody;
        Movment movment;
        InputController input;
        TrajectoryRenderer trajectoryRenderer;
        AudioSource audioSource;

        // Start is called before the first frame update
        void Start()
        {
            input = FindObjectOfType<InputController>();
            rigidBody = gameObject.GetComponent<Rigidbody>();
            trajectoryRenderer = FindObjectOfType<TrajectoryRenderer>();
            movment = GetComponent<Movment>();
            audioSource = gameObject.GetComponent<AudioSource>();
            Debug.Log(audioSource);
        }

        // Update is called once per frame
        void Update()
        {
            DrawTrajectory();
            Moving();
            Landing();
        }

        void DrawTrajectory()
        {
                trajectoryRenderer.ShowTrajectory(rigidBody.transform.position, input.inputDirection);
        }

        void Moving()
        {
            if (input.touchIsEnded)
            {
                movment.Push(rigidBody, input.moveDirection, isGrounded);
                input.touchIsEnded = false;
            }
            if (isInAir)
            {
                input.moveDirection = Vector2.zero;
                input.touchIsEnded = false;
            }
        }

        void Landing()
        {
            if (landing)
            {
                audioSource.pitch = Random.Range(0.6f,1.8f);
                audioSource.Play();
            }
        }
    }
}