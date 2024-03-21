using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDropdown : MonoBehaviour
{
    public Image oldImg;
    public Sprite[] newimg;
    public Dropdown dropdown;
   public void ChangeImage(Dropdown dropdown)
    {
        oldImg.sprite = newimg[dropdown.value];
    }
}
