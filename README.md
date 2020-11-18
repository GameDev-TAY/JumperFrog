![WhatsApp Image 2020-11-04 at 08 44 05](https://user-images.githubusercontent.com/57855070/98078036-f4b04180-1e79-11eb-9bde-48b3d32a201f.jpeg)

This project was done as part of the "Computer Game Development" course at Ariel University.

You can see the assignment at the following link:

https://github.com/gamedev-at-ariel/gamedev-5781/blob/master/04-unity-triggers/homework.pdf

We created a game where a frog has to cross the road without getting hit by cars. We created three lanes that simulated the road, and we created a 
spawner for each lane that schedules the object that represents the cars at some random time. We built a code that moves the cars in a continuous 
movement from right to left (or vice versa) and the player according to the input from the arrow keys. We used a trigger to check if the player was run over on the way, 
and another trigger to check if the player reached the other side successfully.

We first positioned a road as a background with 3 lanes. We then placed the frog on the side of the road and added to the frog a script for the movement that includes an animation of the frog (we got the animation when we downloaded the assets).
We then added car spawns at different speeds and different time ranges on both sides of the road. It should be noted that when the car object exits the road it is destroyed.
Finally we put another wall that says “you win” and the caption only appears when the frog touches the wall and there is a touch recognition, i.e. the trigger of the victory was activated.
The car overturns the frog and kills it, the trigger of loss is activated.

You can play the game here:

https://gamedev-tay.itch.io/ju

![image](https://user-images.githubusercontent.com/57855070/99500757-74aecf00-2983-11eb-9c3d-5bbb5a1d6ab1.png)

We took the assets from: <br />
https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085 <br />
https://assetstore.unity.com/packages/3d/characters/animals/toxic-frogs-132963 <br />

