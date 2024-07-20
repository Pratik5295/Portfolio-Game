using KrazyKrakenGames.DataManagement;
using TMPro;
using UnityEngine;

public class UIEducation : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DegreeText;
    [SerializeField] private TextMeshProUGUI CollegeText;
    [SerializeField] private TextMeshProUGUI GraduationYearText;

    public void Populate(EducationData data)
    {
        DegreeText.text = $"{data.Degree}";
        CollegeText.text = $"{data.College}";
        GraduationYearText.text = $"{data.GraduationYear}";
    }
}
