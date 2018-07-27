using UnityEngine;
using UnityEngine.UI;

public class FillImageValue : MonoBehaviour
{

    public Image image;

    [Space]
    public int currentValue;
    public int maxValue;

    public void AddToCurrentValue(int value)
    {
        currentValue += value;
        if (currentValue > maxValue)
        {
            currentValue = maxValue;
        }
        UpdateImageFill();
    }
    public void SubtractFromCurrentValue(int value)
    {
        currentValue -= value;
        if (currentValue < 0)
        {
            currentValue = 0;
        }
        UpdateImageFill();
    }

    private void UpdateImageFill()
    {
        float fillValue = (float)currentValue / maxValue;

        if (image != null)
        {
            image.fillAmount = fillValue;
        }
    }
}
