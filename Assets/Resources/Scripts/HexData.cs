using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HexData", menuName = "My game/Hex Data")]
public class HexData : ScriptableObject 
{
    public string hex_name;
    public int wood_gen;
    public int food_gen;
    public int metal_gen;
    public Color hex_color;
}