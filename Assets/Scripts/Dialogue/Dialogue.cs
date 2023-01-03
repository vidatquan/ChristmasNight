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
    public string[] textForSad; //dùng cho hàm random text
    [TextArea(3, 10)]
    public string[] textForThanks; //dùng cho hàm random text
    [TextArea(3, 10)]
    public string[] textForWish; //dùng cho hàm random text
}
