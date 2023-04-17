UnityXNA
========

![Screenshot 2023-04-16 174033](https://user-images.githubusercontent.com/1466920/232324104-25284d30-25f5-4356-9bb7-48316624bdfa.png)

Proof of concept demo'ing the execution of a 2D XNA game sample in the Unity3D engine with zero code changes to game source code.

**Note: Make sure to import the assets correctly into Unity**
![image](https://user-images.githubusercontent.com/1466920/232458357-4383a4b3-e7aa-4fca-97fe-c2937f547178.png)

**Disclaimer: I've received a lot of emails asking if UnityXNA is suitable for porting an existing XNA game to Unity. The short answer is: it is, if you're prepared to do the leg work yourself. UnityXNA only implements the bare minimum of the XNA API in order to get the Platformer sample working. If your project uses any parts of the XNA API that the Platformer sample does not, you will need to add support for this yourself. Due to personal time constraints and the nature of this project as a tech demo only, I can offer no support for UnityXNA. Source code is provided for the curious and as a nice starting point for more serious emulation of XNA in Unity.**

**A good resource is also the source code of the [MonoGame](https://github.com/MonoGame/MonoGame/tree/develop/MonoGame.Framework) project for better understanding.**