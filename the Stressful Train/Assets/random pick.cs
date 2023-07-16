using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class NPCRequestFunction : MonoBehaviour
{
    public enum RequestType
    {
        GetWater,
        GetNapkins,
        GetFood
    }

    private RequestType currentRequest;
    private float requestTime;
    private float timeIntervalMin;
    private float timeIntervalMax;

    void Start()
    {
        currentRequest = RequestType.GetWater;
        requestTime = 0.0f;
        //time intervals 
        timeIntervalMin = 60.0f;     // 1 minute
        timeIntervalMax = 90.0f;     // 1.5 minutes
    }

    void Update()
    {
        requestTime += Time.deltaTime;
        //logic to reset time after choosing
        if (requestTime >= timeIntervalMin && requestTime <= timeIntervalMax)
        {
            ChooseRandomRequest();
            requestTime = 0.0f;
        }
    }
    //choosing the random request
    private void ChooseRandomRequest()
    {
        int requestIndex = Random.Range(0, 3);
        currentRequest = (RequestType)requestIndex;

        Debug.Log("The NPC requests " + currentRequest);
    }
}
