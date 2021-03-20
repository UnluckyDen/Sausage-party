using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sausage
{
    public class CameraFollow : MonoBehaviour
    {
        //change to privete
        public Transform target;

        [SerializeField]
        float smoothSpeed;
        [SerializeField]
        Vector3 offset;

        private void LateUpdate()
        {
            Follow(Time.deltaTime);
        }

        private void Follow(float delta)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothhedPosition = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed/delta);
            transform.position = smoothhedPosition;
            transform.LookAt(target);
        }
    }
}
