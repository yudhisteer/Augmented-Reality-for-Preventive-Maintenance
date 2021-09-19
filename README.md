# Augmented-Reality-for-Preventive-Maintenance

For my final year internship at RT Knits Ltd, my objectives were to find ways in improving the predictive/preventive maintenance of machines in the Cutting Dept. Using the “5 Whys“ tool to tackle the source of the problem, the root-cause was found to be a lack of knowledge in how the machines function which led to an improper maintenance. This result in the time interval between successive maintenance to wane.

I started with a small but complex machine - a centrifugal pump - to demonstrate the maintenance technicians the proper way of doing maintenance and to train them on the mechanisms of the machine.

While RT Knits was starting projects on IoT, Cloud Computing and AI, I decided to have a deeper look on how Augmented Reality would be a benefit for the company as it was an untapped technology for RT Knits at the time.

## What is Augmented Reality?
Augmented reality (AR) is an experience where designers enhance parts of users’ physical world with computer-generated input. Designers create inputs—ranging from sound to video, to graphics to GPS overlays and more—in digital content which responds in real time to changes in the user’s environment.

Under the umbrella term extended reality (XR), AR differs from virtual reality (VR) and mixed reality (MR):

* AR — Design for digital elements to appear over real-world views, sometimes with limited interactivity between them, often via smartphones. Examples include Apple’s ARKit and Android’s ARCore (developer kits), the Pokémon Go game.

* VR — Design of immersive experiences that isolate users from the real world, typically via headset devices. Examples include PSVR for gaming, Oculus and Google Cardboard, where users can explore, e.g., Stonehenge using headset-mounted smartphones.


* MR — Design to combine AR and VR elements so digital objects can interact with the real world; therefore, you design elements that are anchored to a real environment. Examples include Magic Leap and HoloLens, which users can use, e.g., to learn more directly how to fix items.

## Types of AR
There are several types of augmented reality in use today. From marketing to gaming, there are a lot of businesses in the exploration phase of utilizing this emerging technology. Below are the main ones:

![AR1](https://user-images.githubusercontent.com/59663734/133935928-9d5e6c46-ec6a-4653-b0f9-b3c518c40720.jpg)

In the projects that follow, I used **Object Tracking** AR to create a Model Target to track an object and **Marker-Based** AR to create a dashboard upon recognising a certain picture.

## Industrial AR
Industrial augmented reality (AR) is an integral part of Industry 4.0 concepts, as it enables workers to access digital information and overlay that information with the physical world. 

Researchers have observed up to 50% performance improvement when using AR solutions. It’s especially clear that augmented reality in industry helps:

- Speed up industrial operations.
- Increase production process efficiency.
- Reduce error occurrence.

This, of course, translates into significant financial benefits for companies.

## Augmented Reality Project - Phase 1
The scope of this project was to optimize and look for new opportunities and efficient methods of doing preventive maintenance. 

Each year lot of foreigners from Bangladesh, Madagascar, Sri Lanka and India come to RT Knits to work as maintenance operators. Prior to work, they are trained on the machines operating at RT Knits. The goal of the training is to find answers to the questions below:

- What is the function of the machine?
- How do they operate?
- What are the common breakdowns they have?
- How to repair them?
- How to do daily/weekly/monthly maintenance?

Only after these intense training will they be allowed to operate on these machines without being supervised.  Most of the foreign maintenance operators know only their native language, i.e, only Bangla, Sinhala, Malagasy or Hindi. They struggle in learning Creole language let alone English. And most of these training are in Creole language. **Language is a barrier for them during training.** While some can quickly adapt to a new language, others take years in understanding the Creole Language. 

#### Mission of Project:

1. Allow maintenance to be done by less-skilled workers. 
When recruiting, RT Knits hand-pick each of the maintenance operators who have had similar experience in machines before in order to come work in Mauritius. With the AR app, we hope we could bridge the gap of a newcomer and someone experienced in order to understand the function of a machine.


2. Devise a new way of training maintenance operators.
While for now they are trained in group and language seems to be a problem for some of them, with the AR app the operators could learn at their own pace and decrease the learning curve in learning new machines.

3. Optimize daily/weekly/monthly/yearly maintenance 
For now an operator performs maintenance using a checklist for each individual machine. With the AR app, we will eliminate the paper checklist and allow the use of their mobile devices to do the job.

## Procedure:

## 1. Outline

#### Software used:

* **Unity Engine** - Unity gives users the ability to create games and experiences in both 2D and 3D, and the engine offers a primary scripting API in C#, for both the Unity editor in the form of plugins, and games themselves, as well as drag and drop functionality. The language that's used in Unity is called C# (pronounced C-sharp). All the languages that Unity operates with are object-oriented scripting languages.

* **SDK: Vudoria** - The Vuforia SDK supports a variety of 2D and 3D target types including ‘markerless’ Image Targets, 3D Model Target, and a form of addressable Fiducial Marker, known as a VuMark. Vuforia provides Application Programming Interfaces (API) in C++, Java, Objective-C++, and the .NET languages through an extension to the Unity game engine.

The app for the first phase will consist of 6 functions:

![Copy of Internship 2020 (2)](https://user-images.githubusercontent.com/59663734/133936344-e254656c-cd99-4604-8f5e-9155eb4310d9.jpg)

## 2. Model Targets Test
Since I am using Superimposition AR, I needed to design the whole pump with a scale of 1:1. Using a vernier calliper I took the necessary measurements and designed the pump accordingly.

Next we want our AR app to first recognise the pump and superimpose 3D objects on top of it. Since, we will be viewing the app using our mobile, the application will not be static. A viewer would want to see around the pump using his mobile. Hence, where we could use an Image Target to superimpose 3D objects, this will not be the ideal solution. What we need is to use a **Model Target Generator(MTG)** using the Vuforia Engine. 

Using the MTG application, we import our 3D model of the pump and create a guide view. This guide view would be adaptive tracking, that is, a viewer would be able to move around the pump when viewing through his mobile without the app losing track of the pump.

![image](https://user-images.githubusercontent.com/59663734/133936543-7517117c-992c-4f74-9741-55f1c3f1b39e.png)

To create a guide view we rotate the pump such that it displays a side of the pump which the viewer will see most of the time. We then download it as a package to be uploaded in Unity.

We should also test our guide view using the MTG app in our mobile to be sure that it is well tracking our pump. In order to pass the test, we should see a white outline around the pump and when moving around, the adaptive tracking function would keep the guides stable as shown below.

![image](https://user-images.githubusercontent.com/59663734/133936584-2fddcfbd-d22c-4d29-9651-27d60f88fdd6.png)

## 3. Building the App 

### Function 1: Specification






https://user-images.githubusercontent.com/59663734/133890710-73dc6b6a-fcc7-48f2-86aa-fcfde5e88da6.mp4



https://user-images.githubusercontent.com/59663734/133890872-d2a9d460-c231-46df-b46e-8af01116a647.mp4




https://user-images.githubusercontent.com/59663734/133922312-36de52ac-cff6-49f6-ab13-9c3bae6c5f4a.mp4





https://user-images.githubusercontent.com/59663734/133921766-1b29266d-2f22-4617-a24e-93ce0c7eefb8.mp4



https://user-images.githubusercontent.com/59663734/133921783-e517cf9b-42b1-428d-af88-7a53e4ffa9fd.mp4






https://user-images.githubusercontent.com/59663734/133921792-7a9df872-1a43-4067-abed-3f37c8b524f1.mp4
