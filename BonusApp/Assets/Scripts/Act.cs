using System;


[Serializable]
public class Act {

    public int cost;
    public string target;

    public Act(string cost, string target)
    {
        this.cost = Convert.ToInt32(cost);
        this.target = target;
    }

    public void makeAct(PlayerManager player)
    {
        player.score += cost;
        ActManager.AddNodeActs(this);
    }

    public override string ToString()
    {
        return target.ToUpper() + "=" + cost;
    }
}
