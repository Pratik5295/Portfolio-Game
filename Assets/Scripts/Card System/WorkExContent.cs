using System.Collections.Generic;
using UnityEngine;

namespace KrazyKrakenGames.DataManagement
{
    public class WorkExContent : CardContent
    {
        public List<WorkExSO> workExData = new List<WorkExSO>();

        public UIWorkEx workExPrefab;
        public Transform contentParent;

        public override void LoadData()
        {
            foreach (var item in workExData)
            {
                var data = item.GetData();

                var ui = Instantiate(workExPrefab, contentParent);
                ui.Populate(data);
            }
        }

        private void Start()
        {
            LoadData();
        }
    }
}
