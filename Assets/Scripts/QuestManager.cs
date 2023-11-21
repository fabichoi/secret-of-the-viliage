using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    Dictionary<int, QuestData> questList;

    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    void Update()
    {
        questList.Add(10, new QuestData("첫 마을 방문", new int[] { 1000, 2000 }));

    }

    public int GetQuestTalkIndex(int id)
    {
        return questId;
    }
}
