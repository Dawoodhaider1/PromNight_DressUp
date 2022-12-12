using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewButton : MonoBehaviour
{
    public GameObject SideBar_Left;
    public GameObject SideBar_Right;
    public GameObject LowerBanner_left;
    public GameObject LowerBanner_Right;
    public GameObject SubmitButton;

    public void PreviewSettings()
    {
        if (SideBar_Left != null && SideBar_Right != null)
        {
            //SideBars
            bool IsActive = SideBar_Left.activeSelf;
            bool IsActive_right = SideBar_Right.activeSelf;
            //LowerBanners
            bool IsActive_Left = LowerBanner_left.activeSelf;
            bool IsActive_Right = LowerBanner_Right.activeSelf;
            //Making sideBars and Lower Banners inactive if the condition gets true...
            SideBar_Left.SetActive(!IsActive);
            SideBar_Right.SetActive(!IsActive);
            LowerBanner_left.SetActive(!IsActive_Left);
            LowerBanner_Right.SetActive(!IsActive_Right);
            //Submit Button getting active...
            bool IsActive_3 = SubmitButton.activeSelf;
            SubmitButton.SetActive(!IsActive_3);
        }
    }
}
