using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class FishSpawner : MonoBehaviour
{
    public GameObject game_area;
    public GameObject fish_prefab;

    public int fish_count = 0;
    public int fish_limit = 10;
    public int fish_per_frame = 1;

    public float spawn_circle_radius = 150.0f;
    public float death_circle_radius = 160.0f;

    public float fastest_speed = 20.0f;
    public float slowest_speed = 1.0f;

    void Start()
    {
        
    }


    void Update()
    {
        MaintainPopulation();
    }

    void MaintainPopulation()
    {
        if(fish_count < fish_limit)
        {
            for(int i=0; i<fish_per_frame; i++)
            {
                Vector3 position = GetRandomPosition();
                FishCode new_fish = AddFish(position);
            }
        }
    }

    Vector3 GetRandomPosition()
    {
        float offSet = Random.Range(430, 830);
        Vector3 position = Random.insideUnitCircle.normalized * offSet;
        
        position += transform.position;

        return position;
    }
    FishCode AddFish(Vector3 position)
    {
        fish_count += 1;
        GameObject new_fish = Instantiate(
            fish_prefab,
            position, Quaternion.FromToRotation(Vector3.up, (game_area.transform.position - position)),
            gameObject.transform
        );

        FishCode fish_script = new_fish.GetComponent<FishCode>();
        fish_script.fish_spawner = this;
        fish_script.game_area = game_area;
        fish_script.speed = Random.Range(slowest_speed, fastest_speed);

        return fish_script;
    }
}
