using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject hexPrefab;
    public 
    // Start is called before the first frame update
    int width = 20;
    int height = 20;

    float oddRowXOffset = 0.496f;
    float zOffeet = 0.803f;

    public HexData woodHex;
    public HexData metalHex;
    public HexData foodHex;
    public HexData defaultHex;

    HexData hexData;


    void Start()
    {
        for (int x = 0; x < width; x ++){
            for (int y = 0; y < height; y++){
                float xPos = x;
                if(y %2 == 1){
                    xPos += oddRowXOffset;
                }
                float randomHexGen = Random.Range(0,100);

                if (randomHexGen <= 50) {
                    hexData = defaultHex;
                }
                else if (randomHexGen > 50 && randomHexGen <= 70){
                    hexData = foodHex;
                }
                else if (randomHexGen > 70 && randomHexGen <= 90){
                    hexData = woodHex;
                }
                else if (randomHexGen > 90 && randomHexGen <= 100){
                   hexData = metalHex;
                }

                GameObject hex =  (GameObject)Instantiate(hexPrefab, new Vector3(xPos,y * zOffeet, 0), Quaternion.identity);
                hex.GetComponent<SpriteRenderer>().color = hexData.hex_color;
                hex.name = hexData.hex_name + "_" + "(" + x + "_" + y + ")";
                Hex hexAttributes = hex.AddComponent<Hex>();
                hexAttributes.x = x;
                hexAttributes.y = y;
                hexAttributes.type = hexData.hex_name;
                hexAttributes.wood_gen = hexData.wood_gen;
                hexAttributes.food_gen = hexData.food_gen;
                hexAttributes.metal_gen = hexData.metal_gen;

                hex.transform.SetParent(this.transform); 
                
            
    
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
