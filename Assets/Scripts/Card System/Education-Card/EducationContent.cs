using KrazyKrakenGames.DataManagement;
using System.Collections.Generic;
using UnityEngine;

public class EducationContent : CardContent
{
    public List<EducationSO> workExData = new List<EducationSO>();

    public UIEducation workExPrefab;
    public Transform contentParent;


    private void Start()
    {
        LoadData();
    }

    public override void LoadData()
    {
        foreach (var item in workExData)
        {
            var data = item.GetData();

            var ui = Instantiate(workExPrefab, contentParent);
            ui.Populate(data);
        }
    }
}
