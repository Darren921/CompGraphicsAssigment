Readme including all required explanations and supporting documentation. The
explanation must include the following:
▪ How was the item implemented (what was modified and done differently
from the class and labs to fit the context of your scene?), how does your
scene benefit from the way the item was implemented?


The lighting  implemented was diffuse, ambient, and specular lighting and was applied to the ground, walls and signs, to make those elements highlighted as it changes the visibility for those key elements and can make the grade more difficult as needed, it also helped the feel of the scene with diffuse, diffuse and ambient having a more dark feel to the scene, and specular making  the edge of the map and the signs more visible. Also, please note that diffuse, diffuse and ambient have harder-to-see differences due to there being less light in the scene. These lighting effects are toggled by 1,2,3 respectively, with implemented via shader graph, and mainly follow the math found in the slides but also allow players to apply a texture with the lighting effect applied to it.        


For the color grading, we added a cool, warm and custom LUT. These three give us a different look in the game, depending on which one we choose. These can be changed in the game by toggling between 4,5,6 to give us different looks. This helped give looks that we thought made the game look more interesting rather in a way we thought was cool.  

For our blending shader, we added it to our enemy object giving him a texture and changing the color to red to make it more scary and ghost-like which we thought was cool. We applied the Alpha blending effect which essentially blends two colours in a way that makes it somewhat transparent. This in turn gave a more menacing and ghost-like appearance to the demon. Please note that the demon is less visible as there are sound 
effects

Toon shader was implemented on the trees of the scene to change the graphical feel compared to the original game and implemented via shader graph, with it being referenced from this video (https://www.youtube.com/watch?v=lYGWP0UpiO0), I left out the texture section as I wanted to leave it untextured and wanted to keep it different to the old game.

Bump mapping was implemented on the rock of the scene to help the player have a landmark that stands out, and since it looked out of place at first I blended it with a toon shader to make it look less jarring and also added a value of the strength of the bump mapping for it to adjust as needed.

The Inverted Hull outline was referenced from this video(https://www.youtube.com/watch?v=vje0x1BNpp8&t=58s) and creates an outline that is separate from the object and doesn't render front faces this is beneficial as it doesn't suffer from the less visible outline that the rim lighting. Also, I added a texture and emission to highlight the outline generated.  

**Course Project**

improvements 
-Added assets
-Changed look
- added textures to most objects
- fixed bugs
- Scene change to support lighting 
- Complete switch to shader graph (not color grading)

Textures

Normal mapping-All relevant textures were given normal mapping, using the texture to normal node which auto creates a 2d sampler with a normal then we connect to to a normal strength node to adjust the look. Trees were disregarded with the express intent to not have the player distracted.
Tiling and offset-In order to prevent completely stretching the texture all samplers have this node in order to place repeating uvs in place of having one texture stretching, especially for the terrain and the water.  

Visual effects

Decals-We used shader graph to make a decal effect that we used to add to the wall at the end when the player escapes. A decal is essentially a texture that you can add to other surfaces in this case we added it to a wall so rather than texturing the whole wall just so it can have this small detail we can add the texture and move it around as we wish. From the base shader graph we used we added threshold so that we can change the look of the texture by giving it a cutoff value that will help us tune it for the effect we want. To make this texture we started with a square base as it was easier to render for us, we first calculate the clip-space positions getting us the positions we need in the clip space. This texture also utilizes inverse view projection so that we can view things in world space more accurately. Using this we then calculate the world space positions that fixes our view on the texture in world view. Then we use transform so that its also viewable in object space, then we also make a bounding box to give the effect constraints. We finish up by adding the texture so we can add our texture in unity to finish up the look. For the threshold we just added a float to the alpha clip threshold so that we can then use a slider to help change the amount in unity. 

Water-To make the water effect we used shader graph so we can have something the player can see as he leaves and walks across to the end. The water effect is just an object that is given vertex shader that will affect the object's vertices so that it will have a wave effect. We also added blend so that we can add another texture to the water to give us more unique look. To make this effect we need to be able to change the speed and strength of the water so we can choose how high and how fast we want the waves to move. Since this object will be moving we added a time node so that it will be continuously moving by multiplying it with the speed then adding it to the position. We then multiply it with the wave strength to give us an offset vector. Then get another position node for our object space so we can add it to the rest, finally adding an option to add in our textures. We also added the option to blend another texture using the blend node, this gave us a water effect that we were happy with.

glass-We added glass on to a shed in order to create a temporary safe place that fades in and out in order to represent the instability of the area and to not directly clash with the visuals of the area. In order to create this we used a tutorial which displacement map and screen color to have the scene influence the color of the glass and to create the distortion effect, and a way to change the color of the tint, what we added was the distance influencing the alpha, using the glass’s position and camera distance subtracted by a minimum distance, it disappears when you are too far away and vice versa with the help of alpha clipping 

FOV-For the Final effect we added a Fov type effect to mimic the screen effect of taking damage to have the blood moon effect to get players focused and to narrow the fov. This effect is created by creating a circle in using the uv then centering it and then applying the power equation to enlarge the circle and then lerping it between the complete white texture and the effect and saturating it to.



![Base game](https://github.com/user-attachments/assets/25751c0a-45f1-412a-bcb1-7b0a5647f4d3)

![Monstershader-ezgif com-optimize](https://github.com/user-attachments/assets/325bb0e6-57b0-40b8-86eb-82bdb832081a)

![Lightingingame-ezgif com-optimize](https://github.com/user-attachments/assets/0d4dc0e9-503e-48c9-b23f-ccc89fac1e26)

![monster with shader](https://github.com/user-attachments/assets/e867c59d-ebd1-4fca-9a81-eb6d378df2d4)

![sign with shader](https://github.com/user-attachments/assets/b7aa1ff0-751c-4a27-ab3a-465f68425a1e)

![Rocks with shader](https://github.com/user-attachments/assets/dafe8b9f-325c-4c85-b08c-4865137768be)





