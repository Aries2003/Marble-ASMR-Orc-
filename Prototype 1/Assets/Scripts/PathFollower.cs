using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PathFollower : MonoBehaviour
{
    public PathCreator pathCreator1;
    public PathCreator pathCreator2;
    public float speed = 5;
    float DistanceTravelled;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // print("up");
        if (AddRoute.LvlTeller % 2 == 0)
        {
            speed = 40;
            DistanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator1.path.GetPointAtDistance(DistanceTravelled);
        }
        if (AddRoute.LvlTeller % 2 != 0)
        {
            speed = 5;
            DistanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator2.path.GetPointAtDistance(DistanceTravelled);
        }

    }
}
