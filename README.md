
# Project Title

InverseKinematicsRobotArm is a project that combines a 6-degree-of-freedom (6DOF) robot arm with a desktop application that controls it using inverse kinematics. The application allows users to control the robot arm's movements and create custom motion paths.

## Lessons Learned

Acest proiect implementeaza principiile SOLID

S - Single-responsiblity Principle
// Funcțiile Start() și Update() sunt responsabile pentru diferite sarcini, deci sunt separate corespunzător.

O - Open-closed Principle
// Funcția CalculateAngles() a fost adăugată și este deschisă pentru extensie, dar codul existent este închis pentru modificare.

L - Liskov Substitution Principle
// Funcția CalculateAngles() este înlocuibilă cu orice altă funcție care produce același rezultat.

I - Interface Segregation Principle
// Funcția start() este împărțită în două bucle care stochează fiecare proprietăți diferite ale obiectelor copil în liste separate.

D - Dependency Inversion Principle
// Funcția CalculateAngles() nu depinde de nicio clasă concretă, ci doar de abstracții (în acest caz, tablouri Vector3)
## Run Locally

Clone the project

```bash
  git clone https://github.com/itsmemarius/Inverse-Kinematics-project.git
```

Install Unity

```bash
  Go to https://unity.com
```

Open the project

Click the Play button to launch the app.


## Authors

- [@itsmemarius](https://github.com/itsmemarius)

