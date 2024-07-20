using UnityEngine;

namespace KrazyKrakenGames.DataManagement
{
    /// <summary>
    /// This is a concrete implementation of the contract
    /// We need this intermeideate class as Unity doesnt support interface in inspecctor yet
    /// </summary>
    public class CardContent : MonoBehaviour, ICardContent
    {
        public virtual void LoadData()
        {

        }
    }
}
