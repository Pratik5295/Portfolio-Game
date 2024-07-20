using UnityEngine;

namespace KrazyKrakenGames.DataManagement
{
    [System.Serializable]
    public struct EducationData
    {
        public string Degree;
        public string College;
        public string GraduationYear;
    }

    [CreateAssetMenu(fileName = "Education SO", menuName = "Krazy Kraken/Data/EducationSO")]
    public class EducationSO : ScriptableObject
    {
        [SerializeField] private EducationData data;

        public EducationData GetData() => data;
    }
}
