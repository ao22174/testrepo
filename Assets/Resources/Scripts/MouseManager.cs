using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MouseManager : MonoBehaviour
{
    public Text coordinates;
    public Text hextypeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
 
        if(hit.collider != null)
        {
            Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
            coordinates.text = "coordinates: " + hit.transform.GetComponent<Hex>().x + ", " + hit.transform.GetComponent<Hex>().y;
            hextypeDisplay.text = "hextype: " + hit.transform.GetComponent<Hex>().type;
        }
    }
}
