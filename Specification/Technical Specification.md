# Technical Specification

Technical Specifications for the project B3

### Last uptaded

07/03/2022

## Team

## Teams Members

|Members|Roles |
|:---:|:---:|
|[Arthur Lemoine](https://github.com/arthur-lemo1ne)| Tech Leader|
|[Théo Diancourt](https://github.com/TheoDct)| Project Manager|
|[Martin Lorut Gauriat](https://github.com/MartinLorutGauriat)| Team Member|
|[Karine Vinette](https://github.com/KarineVinette)| Team Member|
|[Nicolas Mida](https://github.com/Nicolas-Mida)| Team Member|
|[Alexandre Bobis](https://github.com/AlexandreBobis)| Team Member|

## Reviewers

[Franck Jeannin](https://github.com/frje),

[Sébastien Goisbeault](https://github.com/sgoisbeault)

## Context

<!-- For this project we wanted to create the next location of ALGOSUP into a fully immersive experience thanks to the VR[^5] technology, it should be used by the people who wants to discover what is a day at ALGOSUP -->

For this project, we were interested in verifying whether the plan provided by the architect for the renovation of the ALGOSUP building is viable for a school that can accommodate 180-200 people,

Thus we will need to obey to the law of physics and realistic scenarios all day long,

<!-- ## Solution

We thought of creating a simulation of a typical day at ALGOSUP in VR, by this way we can check if the plan provided by the architect is correct and viable, the simulation must be as realistic as possible. -->

<!-- WIP -->

<!-- ## Problems

- 3D Model not optimized for a VR simulation
-  -->

## Solution

<!-- The goal for this project is to have the most immersive and complete experience with all the features we wanted, -->

To resolve the possible problem, we have thought of numerous solutions for this project to have the most efficient way to interract with all the things related to the school while in VR, in order to have the most optimized experience as a users:

### Current solution

- We are looking to reshape the 3D model to gain in performance and change the functions of some rooms:
It will take a lot of time, despite this we might be able to have a far better experiences as a users with a redesigned models and a gain of performances

- 

- Testing the simulation with NPC who are going to represents students, stakeholders, staff if everything is at the right place and is good for a building supposed to hold almost 200 peoples.

### Limitations

- We could be limited by the VR headset capability,

- We probably wouldn't be able to run the simulation on other VR headset,

- Don't be able to run properly a server to host the multi-users functionnality,

- Some people might experience motion-sickness,

### Test Plan

We thoughts about making a Sandbox to developp our functionnality in order to have test all along the project and don't be affected by the ressources required to display the B3 in Unity.

## Costs

This project costs actually nothing to us,

- VR headset are provided by ALGOSUP.
- We don't mind about using premium assets.

We might need to pay if we build a multi-users service based with a server and we don't host it on our PC.

## Release

It's a school project, planned to not be released on another platform however if the need were to arise we have the possibility to release it on "Unity Play"

After a possible release if we have things to change we can make an update and provide an document so users know about the new features/corrected bugs via Patch Notes.

## MVP

The Minimum Viable Product is a simple simulation of the B3[^3] where the user can walk into it.

## Out of scope

- Fully usable on all VR[^5] headsets
- Interract with the NPC[^4] by the voice
- Make multi-users simulation

<!-- ## Technologies Used

[.NET](https://docs.microsoft.com/fr-fr/dotnet/)

[Unity](https://Unity.com/)

[GitHub](https://github.com/TheoDct/ALGOSUP_2022_Project_4_D/tree/main) -->

## Ressources

For this project, the architect give us a 3d file in .ifc[^6] of the building and a 2d plan in .pdf[^7]

To try the simulation all along the project we have been provided with the virtual reality headsets : Oculus Quest 2[^5]

## Technologies Used

We will use these softwares to achieve the project :

Unity[^8] :

- Pro Builder[^9]
- Netcode[^10]
- Relay[^11]
- Lobby[^12]
- Vivox[^13]

Visual Studio[^14]

Git[^15]

CAD Exchanger[^16]

<!-- ## .NET Version

6.0

We used this version because it's the last version of .NET and we wanted to use something up-to-date -->

## Unity Version

2020.3.29f1

We used this version because it's the last LTS[^2] version in order to have the best stability throughout the project.

### Templates of project Unity

We decided to use the template URP[^1] because it will simplify the rendering at the end of the project, it will also allow us to use a graphic tool to program shaders in order to have better graphics and effects in the simulation.

We will also develop the core of the software on 3D models before adapting it to a VR format to be more efficient, so we won't have to build every time we want to run the program.

## Device compatibility

VR headset :

- Oculus Quest[^4]
- Oculus Quest 2

## Download at

[GitHub](https://github.com/TheoDct/ALGOSUP_2022_Project_4_D)

## Work Estimates

### Tasks

- Rebuild from scratch the 3D Model of the Building based on the existing one
- Make furnitures

- Program the features needed:
    - Interract with objects
    - Storage System
    - Security System
        - Door locked with Welcomr, should be unlocked via bluetooth
    - Have differents scenarios depending on the chosen role
        - Students
        - Staff
        - Stakeholders
    - NPC to replace stakeholders
    - Settings Menu

- Build a multi-users service
- Possibly put the game on a downloadable platform

### Milestones

B3 Model finished: 03/15/22
Functionnality finished: 03/07/22
Adaptation to VR platform finished: 04/10/22

Oral exam: 04/07/22

## Terminology

[^1]: URP stand for Universal Render Pipeline, it's a prebuilt scriptable render pipeline made in order to easily optimized graphic across a range of platforms.

[^2]: Long Term Support, means this version of the software is going to provide a better stability all along the project.

[^3]: The B3 is the next location for the school ALGOSUP located in the center of Vierzon.

[^4]: NPC stands for Non Playable Character and refers to characters that users will not be able to play as.

[^5]: The Oculus Quest is a Virtual reality headset who can run a program without any cords or a PC.

[^6]: An ifc file is a CAD data exchange file format intended for description of architectural, building and construction industry date.

[^7]: An pdf file is a file format developed to present documents, including text formatting and images.

[^8]: Unity is a game engine designed to create games for a wide range of devices.

[^9]: Pro Builder is a native 3D model editor of Unity.

[^10]: Netcode is a native tool from Unity used to build multiplayer foundation system by allows the user to connet to a host by its IP and port.

[^11]: Relay is a native tool from Unity used to build the connexion link from an users to another.

[^12]: Lobby is a native tool from Unity used to create an entry point from a users to another.

[^13]: Vivox is a native tool from Unity used to let all users from a same lobby to talk to each other.

[^14]: Visual Studio is a source-code editor made by microsoft used to write code.

[^15]: Git is a software used to centralize our work throughout the project.

[^16]: CAD exchanger is a software used to convert an .ifc file to an .fbx file in order to use it with Unity.
