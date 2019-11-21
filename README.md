

# Game Prototype
//Let goed bij het maken, schrijven en bijhouden van dit document op de **[prestatie-indicatoren](https://drive.google.com/drive/folders/1y8l0Zr4E8b6gYJui_pSzQaoWr-gEr6JN?usp=sharing)**. Deze toon je aan
//in dit document.*

For this assignment we have created a prototype of a game. In this prototype we have created the core mechanics of the game, so we can add more features to the game later. In this case the core mechanics are as followed.
- User input
- Player movement
- Enemy pathfinding

## Features
//Wanneer je een specifiek onderdeel wilt uitlichten kun je dat in deze sectie benoemen.

- We still need to do these ones. [Awesome Algoritme](link)
- [Specifieke Mechanic](link)

## Software Anaylse
//Welke software heb je voor deze proefopdracht onderzocht? En waarom heb je uiteindelijk gekozen voor de //gekozen Software. Benoem hier specifieke argumenten.

Unity

- Advantages

  

> Objectively

  

- You can easily work with assets.

The main advantage of working with Unity is that the asset workflow is extremely efficient. You can simply drag, drop and duplicate them anywhere you need.

  
  

> Subjective

- Lots of experience.

One of the advantages of using Unity is that we have lots of experience with the engine.

- We know where to obtain new and reliable information.

Another advantage of using Unity is that we know where to obtain reliable information, we know fairly well where to find what we need in the Unity API.

Worst case scenario, we can always ask our teachers for help.

- We can create a working prototype within a small amount of time.

Another advantage of using Unity is that we can create a functional product within a small window of time.

This is mostly due to our experience, but the layout of the engine also plays a big part in this.

  

- Disadvantages

  

> Objectively

- Unity compiles unused libraries.

When you export a Unity project all unused libraries will also be compiled.

For example: When you never use the UnityEngine.Networking in your project, Unity will still compile the library, even though it will never be used in your game.

  

> Subjective

- The Unity - Github workflow is terrible.

The workflow between Unity and Github is the absolute worst.

We have had numerous issues with branches deleting important files, merge errors over literally nothing, it's an absolutely horrible combination.

- The quality of 3d scenes is not ideal.

The quality of a 3d rendered scene isn't that great, you can always see that the antialiasing isn't working properly.

There are also a few lightning and rendering issues. One of the most common rendering issues is when you have 2 objects of the exact same color placed within each other.

The issue with this is that unity doesn't have a strict rendering order, and thus creates epileptic visual glitches on sides of the cube.

- To are too many options.

Simply put: There are just to many options.

For example: When you import a 3d model, there are about 30 different options on how to render the model.

Most of these options have a dropdown menu with another 4 options.

  ---------------

Unreal Engine

- Advantages

  

> Objectively

- Unreal uses c++

The code-based advantage of Unreal is that you write code on c++. If we compare c++ with c#, we can clearly see that c++ is better performance wise. This is because c# uses a lot of libraries, which in c++ you need to include yourself, so you never compile libraries you don’t use.

  

> Subjective

- Unreal engine has amazing graphics.

Compared to Unity, Unreal has amazing graphics, both model rendering and lighting effects.

This is of course something we truly want for our game eventually.

- With the Unreal engine you can simply use "blueprints" to headstart your project.

When asking our colleagues about their opinions and experiences with Unreal, they started talking about "blueprints".

They mentioned that they both love and hate them, the part they like about these blueprints it that it gives your project a head start.

You can create the foundation of your project within a couple of days, of course only if you know what you are doing.

  

- Disadvantages

  

> Objectively

2 Je moet beginnen met templates, je kan weinig zonder template

- You have to start with templates.

In Unreal there are numerous templates to start from, and you can start from scratch. The only problem with this is to start from scratch, you need to be fairly familiar with the engine to even understand how to start.

- The templates are based on blueprints.

The templates in Unreal are mostly based on blueprints. The problem with this is that these blueprints have a limited functionality according to our colleagues. Besides this problem, these blueprints almost completely remove the programming part of that which the blueprint is intended for. This means you can not finetune that element of your game.

  

> Subjective

- Unreal engine is difficult to learn in a small amount of time.

As of what we heard, and learned from opening Unreal engine for the first time, it takes a long time to learn.

Unfortunately, this is time we just don't have, since we only have 2 weeks to finish this project.

- The engine uses an enormous amount of performance.

The moment our laptops started up Unreal, we immediately had performance issues.

We asked a few of our colleagues if they also had these issues, and they all responded that it was fairly normal for Unreal to use almost all of your laptops GPU.

- The blueprinting feature simply removes the programming part out of your game.

When we asked our colleagues for their opinion on the blueprint system, they both hated and loved it.

They mostly disliked this system because is removes the programming element out of your project.

Which we, as programmers find fairy stupid.

  ------

**--- Conclusion ---**

## Learning purposes
- Creating a game prototype, so we can learn how to start with the core mechanics
- Learning the basics of path finding
- Learn how to create and export 3d models
- Learn to import 3d models correctly
- Learn about teamwork in small teams

## Schedule
| | Monday | Tuesday | Wednesday | Thursday | Friday |
| --- | --- | --- | --- | --- | --- |
|Week 46 - 2019| Documentation, EnemyMovement.cs| EnemyMovement.cs, Model sizes | InputHandler.cs , KeyboardInput.cs, Enemy pathfinding | InputHandler.cs, KeyboardInput.cs | PlayerMovement.cs, Enemy pathfinding |
|Week 47 - 2019 | PlayerInput.cs, PlayerMovement.cs | PlayerMovement.cs, InputHandler.cs, Enemy pathfinding | PlayerDeath.cs, EnemyDeath.cs | Optimising scripts, adding extra comments | Finalising and exporting project |

## Sources
- [Pathfinding](https://www.youtube.com/watch?v=mP7ulMu5UkU)
- [Keyboard input](https://docs.unity3d.com/ScriptReference/Input.html)
