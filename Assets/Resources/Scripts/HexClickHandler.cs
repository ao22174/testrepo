using UnityEngine;
using UnityEngine.EventSystems;

public class HexClickHandler : MonoBehaviour, IPointerClickHandler
{
    public GameObject uiPanel; // Reference to the UI panel you want to display.
    private bool isPanelVisible = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        Debug.Log(name + " Game Object Clicked!");
        {
            if (isPanelVisible)
            {
                // Close the UI panel if it's already open.
                uiPanel.SetActive(false);
                isPanelVisible = false;
            }
            else
            {
                // Open the UI panel if it's closed.
                uiPanel.SetActive(true);
                isPanelVisible = true;
            }
        }
    }
}