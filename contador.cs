using UnityEngine;
using TMPro;

public class contador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coletavelText;

    public void textUpdate(int value)
    {
        coletavelText.text += value.ToString();
    }
}
