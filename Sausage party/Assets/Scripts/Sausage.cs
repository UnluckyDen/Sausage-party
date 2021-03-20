using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class Sausage : MonoBehaviour
    {
        public bool isGroundent;
        [SerializeField]
        public Rigidbody rigidbody;
        Movment movment;
        InputController input;
        TrajectoryRenderer trajectoryRenderer;

        // Start is called before the first frame update
        void Start()
        {
            trajectoryRenderer = FindObjectOfType<TrajectoryRenderer>();
            movment = GetComponent<Movment>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void DrawTrajectory()
        {
            
        }
    }
}