using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class TrajectoryRenderer : MonoBehaviour
    {
        private LineRenderer lineRenderer;
        Vector3[] points = new Vector3[10];

        Sausage sausage;
        InputController inputController;

        // Start is called before the first frame update
        void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
            sausage = FindObjectOfType<Sausage>();
            inputController = FindObjectOfType<InputController>();
        }

        public void ShowTrajectory(Vector3 origin, Vector3 speed)
        {
            lineRenderer.positionCount = points.Length;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = origin + speed * 0.3f * i;

            }
            lineRenderer.SetPositions(points);
        }
        private void Update()
        {
            ShowTrajectory(sausage.rigidbody.transform.position, inputController.inputDirection);
        }
    }
}