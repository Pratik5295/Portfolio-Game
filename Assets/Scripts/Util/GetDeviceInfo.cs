using TMPro;
using UnityEngine;

public class GetDeviceInfo : MonoBehaviour
{
    public float width;
    public float height;

    public TextMeshProUGUI labelText;

    private void Update()
    {
        GetScreenSize();
    }

    private void GetScreenSize()
    {
        width = Screen.width;
        height = Screen.height;

        labelText.text = $"Width:{width.ToString()} and Height:{height.ToString()}";
       
    }
}
