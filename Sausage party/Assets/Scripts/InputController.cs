using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace sausage
{
    public class InputController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        public Vector2 inputDirection;
        public Vector2 moveDirection;
        public GameObject beginTouch;
        public GameObject dragTouch;
        public bool touchIsEnded;
        public bool touchIsMoved;

        private void Update()
        {
            TouchInput();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            beginTouch.transform.position = eventData.position;
            dragTouch.transform.position = eventData.position;
        }

        public void OnDrag(PointerEventData eventData)
        {
            dragTouch.transform.position = eventData.position;
            InputDirection();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            inputDirection = Vector2.zero;
        }

        private void InputDirection()
        {
            inputDirection = (beginTouch.transform.position - dragTouch.transform.position) / Screen.width;
            moveDirection = (beginTouch.transform.position - dragTouch.transform.position) / Screen.width;          
        }

        public void TouchInput()
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    touchIsEnded = true;
                    touchIsMoved = false;
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    touchIsMoved = true;
                }
            }
        }
    }
}