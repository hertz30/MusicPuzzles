using UnityEngine.EventSystems;
using UnityEngine.UI;
 
/// <summary>
/// This is a custom button class that inherits from the default button. This allows us to have seperate events for left and right click, utilising all of the handy features of Button.
/// </summary>
public class UIButton : Button
{
    public UnityEngine.Events.UnityEvent onRightClick = new UnityEngine.Events.UnityEvent();
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Invoke the left click event
            base.OnPointerClick(eventData);
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            // Invoke the right click event
            onRightClick.Invoke();
        }
    }
}
 