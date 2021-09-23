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

* **Shapr3D** - Shapr3D is a user-friendly, cross-platform design app that is compatible with all major desktop CAD software. We can import projects and export work directly to our rendering, manufacturing, drafting, or splicing tools. All the components of the centrifugal pump will be drawn on a 1:1 scale using Shapr3D.

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
With the "Specification" function, we want to show the specs and asset information of the pump. Specs include data on **suction/delivery size, flow capacity, power rating and so on.** And the Asset information includes the **asset code, model type, status and so on.** 



![image](https://user-images.githubusercontent.com/59663734/134480484-d25ef6a5-f00b-4be5-a6b7-e28a6f18b3a8.png)

When uploading the model target package, Unity would create a Model Target Object with the pump situated at the origin. We then upload the JPG pictures(Information panels) in Unity and then make them a child of the Model Target. We adjust the pictures w.r.t the pump model target and run the file. 


https://user-images.githubusercontent.com/59663734/133890710-73dc6b6a-fcc7-48f2-86aa-fcfde5e88da6.mp4


### Function 2: Simulation
The goal of the "Simulation" function is to show the working of the pump as it would be in real-life. It should show where water comes in and goes out and how the impeller works in this context. 

We do not need to show the whole pump in this function so we hide the pump model in white. The model target pump gives us the origin to add more 3D objects on top hence, we have a reference point to add the impeller.

We want to show the inflow and outflow direction of water. A prefab of a Realistic Waterfall FX that could work. When importing it to Unity, we need to configure its settings for it to work in our context. I created a Game Object named **alpha_watefall** and then add the FX effects and sound that would make the water flow realistically.

![image](https://user-images.githubusercontent.com/59663734/134482607-0ae21ed7-c505-4ece-9032-e53101d2bda8.png)


For the water to animate endlessly, we need to write a script in order to adjust the flow of the water. We do this by initializing a public object speedx and speedy at the top. Time. deltaTime is the amount of seconds it takes for the engine to process the previous frame. Using equation **Distance = speed x time**, we get the distance we want to project the flow of water in direction X or Y using offsetx or offsety.

```
public class AnimatedUVs : MonoBehaviour {
		public float speedY = 0.5F;
		public float speedx = 0.0F;
		private float offsety = 0.0F;
		private float offsetx = 0.0F;
		private Renderer rend;
		void Start() {
				rend = GetComponent<Renderer>();
		}
		void Update() {
				offsety += Time.deltaTime * speedY;
				offsetx += Time.deltaTime * speedx;
				rend.material.SetTextureOffset("_MainTex", new Vector2(offsetx,offsety));
		}
}
```

https://user-images.githubusercontent.com/59663734/133890872-d2a9d460-c231-46df-b46e-8af01116a647.mp4



### Function 3: Working
Function 3 should constitute the full working mechanisms of the pump - pipe connecting to flanges, shafts, impeller, mechanical seal and motor. What we want to demonstrate in this function is how the pump works.

Since we already draw the pump in 3D and the pipes, we need to connect an AC motor at the end. We also want to see the impeller rotate. To do so, we write a C# script which will continuously rotate the impeller:

```
public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(200, 0, 0) * Time.deltaTime);
    }
}
```

Basically a Vector3(0,0,0) is a position on the 3D space. First 0 is the X axis, second one is Y axis and third 0 is Z axis. You can use it to set some GameObject over an exact position or even to move something over time on the desired axis only, using the "Update method" for example.

Every object in a Scene has a Transform. It's used to store and manipulate the position, rotation and scale of the object. Every Transform can have a parent, which allows you to apply position, rotation and scale hierarchically. This is the hierarchy seen in the Hierarchy pane. 

While this will give a user a good indication of the working of a pump, we will still need to explain what each part does. For example, what is the function of a mechanical seal?, how is the impeller connected? and so on. The essence of this AR app is to get every information in one app. Hence, we do not want the user to google or go on YouTube to search for it. Instead what I did is embed a YouTube video explaining the function of the pump inside the project.

![image](https://user-images.githubusercontent.com/59663734/134483946-e254d2ae-55da-4596-a485-5619d8db3d8a.png)

We start by searching a YouTube video of our choice and download it to MP4. Next, we import it in Unity. We create a plane in Unity and position it where we would want the video to be displayed. Then, we click on “Add Component” to the plane and add the video we downloaded. We configure the settings such as “Loop”, “Play on awake” and so on. 


https://user-images.githubusercontent.com/59663734/133922312-36de52ac-cff6-49f6-ab13-9c3bae6c5f4a.mp4


### Function 4: X-section
What we want to show in this function is the anatomy of the pump. We want to show the user how the inside of the pump is, that is, the connections without him disassembling the pump. We start by doing different cross-sections along different planes(X, Y , and X&Y).

![image](https://user-images.githubusercontent.com/59663734/134484292-5ce8abcb-5e6f-4b04-adff-db5dd4c8e50b.png)

Unity accepts files in OBJ or FBX, hence we can use a software like “CAD Exchanger” to convert our files. We need to import one X-section 3D file at a time in one Scene. We start by importing the Y-plane x-section.

![image](https://user-images.githubusercontent.com/59663734/134484448-f049201e-fecd-499e-a501-b44253cff13e.png)

Now we need to label the parts. We start by adding a “3D Text” and change the text to what we want. We also want to show a line pointing the text to the part. In Unity we cannot add 2D objects as such. Instead we add a 3D Cylinder object and with the Scale Tool we change its dimensions to make it the line we want. The result should be as such:

https://user-images.githubusercontent.com/59663734/133921766-1b29266d-2f22-4617-a24e-93ce0c7eefb8.mp4


### Function 5: Exploded View
In the Exploded-View function, we want to show the disassembling procedure of the machine, the number of parts it contains and its names, but most importantly this will help the maintenance operators to disassemble the machine virtually. Without picking a screw driver or a wrench, we intend to make the disassembling process similar if it was done in real-life.

We start by importing the full 3D model of the pump in FBX format. We group the parts that will explode at the same time, for example, the bolts and nuts of the flanges. I named it from 1st to 10th and the parts that will not explode are left as it was. Next, we create the Endpoints, the position we would want our 3D parts to move when being exploded, as empty GameObjects. For example, the top bots and nuts have coordinates (0,0,0) and we would want to displace it only in the Z-axis. Hence, we create an empty GameObject of coordinates (0,0,0.297). We repeat the process for the other 9 parts.

![image](https://user-images.githubusercontent.com/59663734/134484834-b5eec3a5-177a-43a1-8ed1-c1e9c56cc446.png)

Next we need to write a script that would take the initial position of the parts, the final position and displace them to their final position when pressing a button.

We start by calling the libraries we would need:

```
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
```

Next, I created a counter for the ten 3D parts that will be exploded and initialize their initial positions. Then, the button will initially have the “Explode” text written on it before exploding and “Combine” text on it after exploding such that when pressing on the latter will combine all the parts.

```
    void Start()
    {
        Counter = 0;
        for(int i = 0; i < 10; i++)
        {
            tempPos[i].x = transform[i].position.x;
            tempPos[i].y = transform[i].position.y;
            tempPos[i].z = transform[i].position.z;
        }        
    }

    public void onExplode()
    {
        if (isExplode)
        {
            isExplode = false;
            btn.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Explode";
        }
        else if (!isExplode)
        {
            isExplode = true;
            btn.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Combine";
        }
        turn[Counter] = true;
    }
```

If someone presses on the “Explode” button, the parts will move to their respective Endpoints and the Counter will start from 0 to 9. When the Counter reaches 9, the panel which will display the parts name will then be shown.

```
    void Update()
    {        
        if (turn[Counter])
        {
            if (isExplode)
            {
                transform[Counter].position = Vector3.MoveTowards(transform[Counter].position, EndPoint[Counter].position, speed * Time.deltaTime);
                if (transform[Counter].position == EndPoint[Counter].position)
                {
                    Counter++;
                    if (Counter >= 10)
                    {
                        turn[Counter - 1] = false;
                        for(int i = 0; i < Counter; i++)
                        {
                            transform[i].GetChild((transform[i].childCount) - 1).gameObject.SetActive(true);
                        }
                        Panel.SetActive(true);
                        Counter = 9;
                    }
```

And if the “Combine” button is pressed, the parts move back to their initial positions and the panel is stopped showing.

```
            else if (!isExplode)
            {
                for (int i = 0; i < Counter+1; i++)
                {
                    transform[i].GetChild(transform[i].childCount - 1).gameObject.SetActive(false);
                }
                Panel.SetActive(false);
                transform[Counter].position = Vector3.MoveTowards(transform[Counter].position, tempPos[Counter], speed * Time.deltaTime);
                if (transform[Counter].position == tempPos[Counter])
                {
                    Counter--;
                    if (Counter <= -1)
                    {
                        turn[Counter + 1] = false;
                        Counter = 0;
                    }
                    else
                    {
                        turn[Counter] = true;
                        turn[Counter + 1] = false;
                    }
                }
            }
```

We create a Canvas where we will insert our Button and Panel. We again click and drag these components into the PumpController Panel.


https://user-images.githubusercontent.com/59663734/133921783-e517cf9b-42b1-428d-af88-7a53e4ffa9fd.mp4



### Function 6: Maintenance



https://user-images.githubusercontent.com/59663734/133921792-7a9df872-1a43-4067-abed-3f37c8b524f1.mp4


# Further Improvement

# Conclusion
