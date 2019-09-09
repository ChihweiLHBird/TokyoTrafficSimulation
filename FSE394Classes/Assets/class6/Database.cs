using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    private int agents_num;
    private int agents_reachGoal;

    // Start is called before the first frame update
    void Start() {
        agents_num = 0;
        agents_reachGoal = 0;
    }

    public int Get_agents_reachGoal() {
        return agents_reachGoal;
    }

    public int Get_agents_num() {
        return agents_num;
    }

    public void Set_agents_reachGoal(int new_num) {
        agents_reachGoal = new_num;
    }

    public void Add_agents_num() {
        agents_reachGoal++;
    }

    public void Add_agents_reachGoal()
    {
        agents_reachGoal++;
    }

    public void Set_agents_num(int new_num)
    {
        agents_reachGoal = new_num;
    }
    // Update is called once per frame
    public void Update() {
        
    }
}
