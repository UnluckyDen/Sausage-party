using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class TrajectoryRenderer : MonoBehaviour
    {
        private LineRenderer lineRenderer;
        Vector3[] points = new Vector3[10];
        [SerializeField]
        float lineDrawSizeCoefficient;

        // Start is called before the first frame update
        void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
        }

        public void ShowTrajectory(Vector3 origin, Vector3 speed)
        {
            lineRenderer.positionCount = points.Length;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = origin + speed * i *lineDrawSizeCoefficient;
            }
            lineRenderer.SetPositions(points);
        }
    }
}