<details>
<summary>Table of contents</summary>

- [Overview](#overview)
  - [Stakeholders](#stakeholders)
  - [Approvals](#approvals)
  - [Targets Audience](#targets-audience)
  - [Project Scope](#project-scope)
  - [Risks and assumption](#risks-and-assumptions)
  - [Requirements](#requirements)
  - [Configuration](#configuration)
  - [Non Functionnal requirements](#non-functionnal-requirements)
  - [Personae](#personae)
  - [Solution Overview](#overview)
    - [Students](#students)
    - [Staff](#staff)
    - [Janitor](#janitor)
  - [Use cases](#use-cases)
  - [Terminology](#Terminology)

</details>

# Overview

## Stakeholders

- JEANNIN Franck
- GOISBEAULT Sébastien
- Architect
- Users

## Approvals

- You need to come up with realistic and testable scenarios about access control, room usage, circulation, signage, furniture, storage, plugs, toilets, etc.

- The virtual setup needs to be as close as possible to the real setup.
- For instance, if a door has a lock in the real world, it would also require some sort of badge/key in the virtual world, a room that can only fit 10 people in the real world, will have the equivalent capacity in the virtual world, etc.  

- You need to obey the laws of physics in the virtual world, no super powers, you can’t walk across walls, fly, etc.
You are required to use virtual reality headsets (Oculus Quest 2) with Unity framework programmed in C# to simulate the entire building.

- Imagine profiles of users (personae) and the way they interact with the school during the day
- You need to figure out how to convert the bimx file into something usable with Unity

## Targets Audience

Our targets audience is composed of all the people who have an interest in ALGOSUP and want to discover the school by visiting its new layout. It include future and current students in order to have their opinion about what they think of the new design, potential investor could also be interested to have a more precise idea of the typical day in the school.

## Project Scope

For this project we need to create a VR[^3] simulation of a regular day at ALGOSUP in the next school building called the B3[^1] with features depending on your character and his role in the school. To verify if the architect's plan is correct and viable for a school.

We need to make some modification to the existing renovation plan in order to repair some possible mistakes made by the architect.

With this, ALGOSUP should be able to be on a whole new level to show the school, and people interested in one way or another in ALGOSUP could have a real school day experience.

This will be useful because we can imagine a presentation to some investors, future students or even just people interested in ALGOSUP will be able to visit the school all in remote with only a VR[^3] Headset.

## Risks and assumptions

- The simulation may not be compatible with all VR[^3] headset.

- We could have performances issues while using the headset.

- The simulation could make people motion-sick.

- We could run out of time to add a stable multi-user version.

## Requirements

- Should have a good feeling while moving in the building.
- Interract with as many objects as possible.
- Convert the B3[^1] 3D file into something usable with Unity.
- Get the most realistic possible simulation.
- Security System:
  - Door unlockable with Welcomr[^5]
- Have differents scenarios depending on the role chosen:
  - Don't do the same tasks all day long
  - Don't have access to the same place
  - Have differents schedule
- Upgrade the current state of the provided plan to provide a better experience:
  - Change the utilities of some rooms
  - Create an interior design
- NPC[^2] to replace current students

## Configuration

You will need to have a compatible headset, then download the application on the device and you are good to go.

## Non Functionnal Requirements

 - Multi-user
 - Time management
 - Security System
    - Software
    - Cameras
 - Fire alarm / security
    - Little red boxes
    - Extinguishers
    - Smoke detectors
- A map so users know where they are all the time.

## Personae

We thought about multiple cases:

First Student (with disability)

![Student](Files/1.MEUNIER_Jules.png)

Second Student

![Student](Files/1.FRANCIS_Claire.png)

Third Student

![Student](Files/1.TORRES_Marc.png)

Stakeholder

![Stakeholders](Files/1.TIRVALD_Lonus.png)

Janitor

![Janitors](Files/1.BARBAN_Yohann.png)

Staff

![Staff](Files/1.DUPONT_Marcel.png)

## Solution Overview

### Arrival Possibilities

There are differents ways students/staff can arrive to school:
  - By car/motorcycle that they can park behind the school.
  - By foot from their home or from train station. In that case they can just enter school since they don't have any vehicles.
  - By bicycle or scooter, in that case we would need a parking in order to properly park these.

### Students

![ArrivalTime](Files/UserFlow_Student_ArrivalTime.png)
![BreakTime](Files/UserFlow_Student_BreakTime.png)
![LunchTime](Files/UserFlow_Student_LunchTime.png)

### Staff

![StaffArrival](Files/StaffArrival.png)
![StaffBreak](Files/staffBreakTime.png)
![StaffLunch](Files/staffLunchTime.png)

### Janitor

![Janitor](Files/UserFlow_Janitor.png)

## Use Cases

This UseCase does not concern the school in itself but the simulation we will be programming.

<br>

![SADC](Files/UseCases.png)

## Terminology

[^1]: The B3 is an old building in the center of Vierzon, which is also the next location for the connected campus who are going to be composed by ALGOSUP, the CNAM and an incubator for start-up.

[^2]: NPC stand for Non Playable Character, will be an A.I implemented in the application.

[^3]: VR is the definition of virtual reality comes, naturally, from the definitions for both ‘virtual’ and ‘reality’. The definition of ‘virtual’ is near and reality is what we experience as human beings. So the term ‘virtual reality’ basically means ‘near-reality’. This could, of course, mean anything but it usually refers to a specific type of reality emulation.

[^4]: Motion sickness occurs due to a difference between the actual movement and the expected movement, which can cause illness in some users.

[^5]: Welcomr is a company that creates connected locks in order to unlock from a phone by the bluetooth technology