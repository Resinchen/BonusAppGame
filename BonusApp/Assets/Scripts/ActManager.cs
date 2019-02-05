using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

public class ActManager
{
    private static readonly string filenameListActs = "list_acts.txt"; //Список возможных действий
    private static readonly string filenameMadeActs = "made_acts.txt"; //Список сделанных действий

#if UNITY_ANDROID && !UNITY_EDITOR
    public static readonly string pathListActs = Path.Combine(Application.persistentDataPath, filenameListActs);
    public static readonly string pathMadeActs = Path.Combine(Application.persistentDataPath, filenameMadeActs);
#else
    public static readonly string pathListActs = Path.Combine(Application.dataPath, filenameListActs);
    public static readonly string pathMadeActs = Path.Combine(Application.dataPath, filenameMadeActs);
#endif

    //Запись в файл списка возможных действий
    private static void Save(string[] actStrings)
    {
        File.WriteAllLines(pathListActs, actStrings);
    }

    // Загрузка списка возможных действий
    private static string[] Load()
    {
        return File.ReadAllLines(pathListActs);
    }

    //Сохранение списка возможных действий
    public static void SaveActs(List<Act> acts)
    {
        string[] actsStrings = acts.Select(t => t.ToString()).ToArray();
        Save(actsStrings);
    }

    //Обновление в файле списка возможных действий
    public static void UpdateActs(Act act)
    {
        File.AppendAllText(pathListActs, act.ToString()+ "\n");
        Debug.Log("Updated");
    }

    // Загружаем в файл список по умолчанию
    public static void DefaultActs()
    {
        string[] content = {"СОН=-20", "ФАСТФУД=-100", "ПРОПУСК ПАРЫ=-75", "ПРОПУСК ТРЕНИРОВКИ=-50",
                "ОПОЗДАНИЕ=-20", "СЛАДКОЕ=-50", "АЛКОГОЛЬ 4°-8°=-10", "АЛКОГОЛЬ 8°-12°=-20", "АЛКОГОЛЬ 12°>=-50",
                "СНЕКИ=-100", "ДОМАШКА=-20", "ОБЕЩАНИЕ = -150", "НЕ ПОГУЛЯТЬ С СОБАКОЙ=-10", "МУСОР=-10",
                "ДОМАШНИЕ ДЕЛА=-15", "ЗАРЯДКА=15", "СОН=15", "ПРИЕМ ПИЩИ=10", "КУРИЦА И ДР.=5", "ДОМАШНИЕ ДЕЛА=15",
                "УГОСТИТЬ САШУ=15", "ПРОЧИТАТЬ ГЛАВУ=5", "ПОЙТИ НА ПАРУ=10", "ПОЙТИ НА ТРЕНЮ=10", "ДОМАШКА=10", "ПРОЙТИ 5 КМ=10",
                "ПРИВЕСТИ СЕБЯ В ПОРЯДОК=5", "НЕДЕЛЯ БЕЗ ПРОГУЛОВ=50", "НЕДЕЛЯ БЕЗ ПРОГУЛОВ ТРЕНЕРОВКИ=30", "ДОЛГОСРОЧНЫЙ СПИСОК=40",
                "ПОДАТЬ МИЛОСТЫНЮ=5", "ОБЕЩАНИЕ=20", "БАССЕЙН=15", "РИСУНОК/ЗАПИСИ=15"};
        File.WriteAllLines(pathListActs, content);
        Debug.Log("Droped");
    }

    // Загружаем из файла список действий (если файла нет, загружаем по умолчанию)
    public static List<Act> LoadActs()
    {
        if (!File.Exists(pathListActs))
        {
            DefaultActs();
        }

        string[] actsStringLoad = Load();
        List<Act> acts = new List<Act>();
        foreach (string actString in actsStringLoad)
        {
            string[] dataAct = actString.Split('=');
            acts.Add(new Act(dataAct[1], dataAct[0]));
        }
        return acts;
    }

    // Добавляем новое выполненное действие в список
    public static void AddNodeActs(Act act)
    {
        File.AppendAllText(pathMadeActs, "\n" + act.ToString());

    }

}