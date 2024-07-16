using UnityEngine;

namespace KrazyKrakenGames.DataManagement
{
    [System.Serializable]   
    public struct WorkExData
    {
        public string CompanyName;
        public string Duration;
        public string WorkTitle;
    }

    [CreateAssetMenu(fileName = "Work Ex", menuName = "Krazy Kraken/Data/Work Ex")]
    public class WorkExSO : ScriptableObject
    {
        public WorkExData data;

        public WorkExData GetData() => data;
    }
}
