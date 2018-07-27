using UnityEngine;
using UnityEngine.UI;

public class HPTextDisplay : MonoBehaviour
{

    public Text textToUpdate;
    public FillImageValue HPBar;

    private void Update()
    {
        textToUpdate.text = HPBar.currentValue.ToString() + "/" + HPBar.maxValue.ToString();
    }
}
