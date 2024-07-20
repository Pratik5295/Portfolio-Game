using TMPro;
using UnityEngine;

namespace KrazyKrakenGames.DataManagement
{
    public class PortfolioCard : MonoBehaviour
    {
        public string cardTitle;

        public TextMeshProUGUI titleText;

        //Content
        [SerializeField] private CardContent cardContent;

        private void Start()
        {
            titleText.text = cardTitle;
        }
    }
}
