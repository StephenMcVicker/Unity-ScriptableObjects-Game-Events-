# Unity: ScriptableObjects Game Events System
Based on a great talk by Ryan Hipple, here is my improved version of his Game Event system for Unity


**Quick Note:**
This project doesn't use any namespaces. 
Conflicts with your own code my happen if you have any classes named the same.
There is 3 classes:
GameEvent
EventListener
EventAndResponse

## Why use this
At Unite Austin 2017, Ryan Hipple talked about the advantage of using scriptableobjects in Unity. 
The video is here:
https://youtu.be/raQ3iHhE_Kk?t=1964
Around 32 minutes in, he talks about creating an event system that allows you and your team to quickly work on features that can act independant. His example: Imagine a designer was working on a player HP bar. He would need to bring in the player into his test scene, maybe some sort of manager, and who knows what else just to do this one thing. With his system using Game Events, you can create a player "take damage" event and have the UI for the HP bar just listen to this event. The best part: You don't even need the player in the scene. Watch his video. He explains it better.

I started using his system but found it got pretty complex adding lots of Event Listener to a single game object so I changed up the code to make it list based. You add just 1 Event Listener component to your GameObject and you can add as many events you want and as many responses to each event as you want.

Here is my video on it:
https://www.youtube.com/watch?v=1ZK63Mp6yTY
In my example I set up an Inputfield. I have a simple script that once finished inputting it checks the length of the string. 
The script has 2 Game Events. 1 for if has enough characters and 1 if there isn't enough.
In the if statement of the script, simply Raise the correct Game Event. Anything that is listening to the event will react.
Add an Event Listener. 
Listen for each game event and just add what you want to happen if either is raised. This is really designer friendly as adding new events is as easy as: "Create > Game Event" in your project window.


## Installation
Just download the files and drag the EventSystem folder into your Asset folder (or any subfolder of your creation) in Unity.
