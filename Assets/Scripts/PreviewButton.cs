using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewButton : MonoBehaviour
{
    public GameObject previewButton;
    public GameObject previewButton_2;
    public GameObject SubmitButton;

    public void PreviewSettings()
    {
        if (previewButton != null)
        {
            bool IsActive = previewButton.activeSelf;
            bool IsActive_2 = previewButton_2.activeSelf;
            previewButton.SetActive(!IsActive);
            previewButton_2.SetActive(!IsActive_2);
            bool IsActive_3 = SubmitButton.activeSelf;
            SubmitButton.SetActive(!IsActive_3);
        }
    }
}
