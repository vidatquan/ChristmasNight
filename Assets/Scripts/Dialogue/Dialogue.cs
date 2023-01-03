using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea(3,10)]
    public string[] sentences;
    [TextArea(3, 10)]
    public string[] textForSad; //d�ng cho h�m random text
    [TextArea(3, 10)]
    public string[] textForThanks; //d�ng cho h�m random text
    [TextArea(3, 10)]
    public string[] textForWish; //d�ng cho h�m random text
}
