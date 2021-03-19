using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace sausage
{
    public class InputController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        public Vector2 inputDirection;
        public GameObject beginTouch;
        public GameObject dragTouch;
        public bool touchIsEnded;



        private void Update()
        {
            TouchInput();
            Debug.Log(inputDirection);
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

        }

        private void InputDirection()
        {
            inputDirection = (beginTouch.transform.position - dragTouch.transform.position)/Screen.width;
            
            Debug.Log(inputDirection);
        }

        public void TouchInput()
        {
            foreach (Touch touch in Input.touches)
            {
                Debug.Log(touch.phase);
                if (touch.phase == TouchPhase.Ended)
                {
                    touchIsEnded = true;
                }
                else
                {
                    touchIsEnded = false;
                }
            }
        }
    }
}