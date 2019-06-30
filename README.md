# PoolExample
Sample code of pooled resource solution used in [RoboVDino](https://alexbairgames.itch.io/robovdino). The intent of these two classes is to allow re-use of resources that are expensive to setup and tear-down. Usage follows this pattern:

* Each game Scene has an instance of PoolManager and an instance of PrefabPool for each type of pooled resource used in that scene.
* Objects in the loaded game scene can request pooled resources from the PoolManager using a specific get method for that resource
* When a PrefabPool gets a request for its game object, it will
1. Check if it already has an available resource to return or
2. Make a new resource
* Pooled resources are configured to automatically turn themselves in to the PoolManager (typically a trigger during an animation), making that resource available again.
* Because different Scenes will usually have differing quantities of pooled resources, the PoolManager and PrefabPool are torn down at the end of a game Scene and new instances initialized in the next Scene.

Both classes are derived from [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html), the base class for any Unity3D framework object that listens for game Scene events.
