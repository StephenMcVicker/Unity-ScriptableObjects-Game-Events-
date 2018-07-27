# Unity: ScriptableObjects Game Events System


Based on a great talk by Ryan Hipple, here is my improved version of his Game Event system for Unity


**Quick Note:**
This project doesn't use any namespaces. 
Conflicts with your own code may happen if you have any classes named the same.
There are 3 classes:
GameEvent
EventListener
EventAndResponse

## Why use this

At Unite Austin 2017, Ryan Hipple talked about the advantage of using scriptable objects in Unity. 
The video is here (HIS TALK):
https://youtu.be/raQ3iHhE_Kk?t=1964
Around 32 minutes in, he talks about creating an event system that allows you and your team to quickly work on features that can act independently. His example: Imagine a designer was working on a player HP bar. He would need to bring in the player into his test scene, maybe some sort of manager, and who knows what else just to do this one thing. With his system using Game Events, you can create a player "take damage" event and have the UI for the HP bar just listen to this event. The best part: You don't even need the player in the scene. Watch his video. He explains it better.

I started using his system but found it got pretty complex adding lots of Event Listener to a single game object so I changed up the code to make it list based. You add just 1 Event Listener component to your GameObject and you can add as many events as you want and as many responses to each event as you want.

Here is MY video on it:
https://www.youtube.com/watch?v=1ZK63Mp6yTY
In my example, I set up an Input field. I have a simple script that once finished inputting it checks the length of the string. 
The script has 2 Game Events. 
1 for if it has enough characters and 1 if there isn't enough.
In the if statement of the script, simply Raise the correct Game Event. Anything that is listening to the event will react.
Add an Event Listener. 
Listen for each game event and just add what you want to happen if either is raised. This is really designer-friendly as adding new events is as easy as: "Create > Game Event" in your project window.


## Installation
Just download the files and drag the EventSystem folder into your Asset folder (or any subfolder of your creation) in Unity.

## Usage and Sample Project

Start by creating a game event:

![CreateGameEvent](https://i.imgur.com/MKbDJDu.png)

You will need something to raise the event.
Here is an example with a button and a script that raises the event when the button is pressed.

![ButtonEventRaise](https://i.imgur.com/oBsLpWp.png)

You can just add a public GameEvent variable to your code and do 
```c#
eventName.Raise(); 
```
wherever you need.
Next, you need to add an Event Listener to the object that needs to "listen" for an event to be raised.

[!eventRaised](https://i.imgur.com/GyaLgKh.png)

Add an element to the list (it will default to 0). 
Set the Game Event to listen for by dragging the game event into the slot or clicking on the Game Event variable and finding it in your project.
You can listen out for different types of events. You can pass in strings, ints, floats, and bools by setting them in the game event or by setting them before calling the "eventName.Raise".
Example:
```c#
eventName.sentInt = 5;

eventName.Raise();
```
This can then be used with the event type "Respone For Sent Int" as long as your function takes in an int as a parameter.

That's it really.
Check out the sample.

Download Game Event System Demo to see this in action.
Our example game development scenario includes a player inside a game world, some UI, and a game object for keeping keyboard input separate.  

![sample](https://i.imgur.com/ludHm1p.png)

Yeah, it's basic. 
Here is what the scene looks like:

![scene](https://i.imgur.com/xDCTJNJ.png)

I kept Input as it's own object to show how modular this system really is.
You don't NEED to have the player on screen to send events the keys were pressed for raising the moving events.
You can use WASD to move. You can even hide and show the player using the buttons on screen.

You will notice the HP bar does nothing. This is intentional.
If you go into the "Game Events" folder you will see 2 events for Damage and Heal.

![damage](https://i.imgur.com/WyEqd3l.png)

Using the custom inspector we can raise the event right from viewing the actual event asset. This is great for debugging and quicking checking if an event is firing.
You will also notice the sent int is 1. This is the damage to the HP.
The HP bar has a simple script for filling the bar by having a current value and max value and converting that to a value the fill image can understand.
Try damage and heal the player from the editor's events.


If you found any of that confusing, watch MY video above or reach out to me on Twitter: https://twitter.com/stephenmcvicker

## Remember

The goal is to keep everything modular/data-driven and designer-friendly. 
You will need to create some helper scripts at some points.
This is designed so you can add features or subtract them without breaking anything.
Try to keep your event listeners to parent objects of the objects you want to affect. If your game object is disabled it won't raise the event so use your parents! 
On your event raised you can add a listener to display/update UI, spawn in an object or effect, play an animation or even play a sound. There is a lot you can do with this system if you just experiment and play with it.
