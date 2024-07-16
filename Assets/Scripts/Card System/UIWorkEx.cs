using KrazyKrakenGames.DataManagement;
using TMPro;
using UnityEngine;

public class UIWorkEx : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI companyNameText;

    public void Populate(WorkExData data)
    {
        companyNameText.text = $"{data.CompanyName}";
    }
}
