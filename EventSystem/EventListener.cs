using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//using SubjectNerd.Utilities;

public class EventListener : MonoBehaviour
{
    //[Reorderable]
    public List<EventAndResponse> eventAndResponses = new List<EventAndResponse>();

    private void OnEnable()
    {

        if (eventAndResponses.Count >= 1)
        {
            foreach (EventAndResponse eAndR in eventAndResponses)
            {
                eAndR.gameEvent.Register(this);
            }
        }


    }
    private void OnDisable()
    {
        if (eventAndResponses.Count >= 1)
        {
            foreach (EventAndResponse eAndR in eventAndResponses)
            {
                eAndR.gameEvent.DeRegister(this);
            }
        }
    }

    [ContextMenu("Raise Events")]
    public void OnEventRaised(GameEvent passedEvent)
    {
        for (int i = eventAndResponses.Count - 1; i >= 0; i--)
        {
            // Check if the passed event is the correct one
            if (passedEvent == eventAndResponses[i].gameEvent)
            {
                //Debug.Log("Called Event named: " + eventAndResponses[i].name + " on GameObject: " + gameObject.name);
                eventAndResponses[i].EventRaised();
            }
        }
    }
}

[System.Serializable]
public class EventAndResponse
{
    public string name;
    public GameEvent gameEvent;
    public UnityEvent response;

    public void EventRaised()
    {
        response.Invoke();
    }
}