using UnityEngine;

public class BabyDucksCode : MonoBehaviour
{
    private int duckCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addDuck()
    {
        duckCount++;
        Debug.Log("Baby duck added! Total baby ducks: " + duckCount);

        //todo: instantiate baby duck and make it follow the mother, etc.
    }

    public void removeAllDucks()
    {
        //if Player level gets increased: set duckCount = 0;
    }
}
