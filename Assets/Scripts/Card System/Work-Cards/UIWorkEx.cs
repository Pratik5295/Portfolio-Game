using KrazyKrakenGames.DataManagement;
using TMPro;
using UnityEngine;

public class UIWorkEx : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI companyNameText;
    [SerializeField] private TextMeshProUGUI durationText;
    [SerializeField] private TextMeshProUGUI positionText;

    public void Populate(WorkExData data)
    {
        companyNameText.text = $"{data.CompanyName}";
        durationText.text = $"{data.Duration}";
        positionText.text = $"{data.WorkTitle}";
    }
}
