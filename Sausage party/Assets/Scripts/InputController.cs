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

        public void OnDrag(PointerEventData eventData)
        {
            dragTouch.transform.position = eventData.position;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log(gameObject.name);
            beginTouch.transform.position = eventData.position;
            dragTouch.transform.position = eventData.position;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            InputDirection();
        }

        private void InputDirection()
        {
            inputDirection = beginTouch.transform.position - dragTouch.transform.position;
            inputDirection.Normalize();
            Debug.Log(inputDirection);
        }
    }
}