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
