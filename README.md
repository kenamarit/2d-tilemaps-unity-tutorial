# Unity 2D Tilemap Basics #

## Step 1: Create a new project ##

- Open Unity and create a new 2D project

## Step 2: Import assets ##

- Create a 'Sprites' folder and a 'Tiles' folder.

- Find the sprites to import in the finder, and drag-and-drop them into the 'Sprites' folder you just created in your Unity project.

- Highlight all the sprites, and set the Pixels Per Unit to 16. (16 because the image files are 16x16 pixels). Make sure you click Apply!

## Step 3: Create your tilemap GameObject and tilemap palette

- In the 'Hierarchy' window, select Create->2d Objects->Tilemap

- Create 4 duplicates of the Tilemap GameObject (found underneath the 'Grid' parent) and rename them: 'Water', 'Ground', 'Path', 'Foreground'

- In the 'Tile Palette' window, select 'Create New Palette.' Name your palette 'World' (or whatever you want) and click 'Create.' A file explorer window will pop up. Select the 'Tiles' folder you created in the previous step.

- Drag-and-drop all the sprites in the 'Sprites' folder into the 'Tile Palette' window.

## Step 4: Draw your world ##

- Draw your world
- Make sure you are drawing on the correct layer

## Step 5: Character Controller ##

- Create an empty GameObject called 'Player'
- Add Rigidbody2D component
	- Set Gravity Scale to 0
	- Set Freeze Rotation: Z (under Constraints section) to true

- Add 'PlayerMovementController' script to the 'Player' GameObject

- Create a 'PlayerRenderer' GameObject that is a child of 'Player'
- Add 'PlayerRenderer' script to this GameObject.

- Create an empty folder called 'Player'
	- Drag and Drop the 'AnimationClips' and 'AnimationSprites' folders into the 'Player' folder

- Drag-and-drop the PlayerController.controller file into the 'Player' folder.

- On the 'PlayerRenderer' gameObject, add a 'Sprite Renderer' component and an 'Animator' component
	- For the 'Sprite Renderer' component, select 'witch static00' as the Sprite.
		- Set the 'Order in Layer' to 100 so it renders above the world
	- For the 'Animator' component, select 'PlayerController' as the Controller.

- Now position the 'Player' gameobject so that it makes sense in the world. Make sure the Z is set to 0.

- If you press play, your character should move in the world using the arrow keys.

- Add 'BasicCameraFollow' script to Project
	- Drag-and-drop the script onto the 'Main Camera'

## Step 6: Colliders ##

- On the 'Player' gameObject, add a 'Circle Collider 2D' component.
	- Set the radius to 0.25 and the Y offset to -0.25. You can play with these values and use whatever makes sense with your character.
- On the 'Water' tilemap layer, add a 'Tilemap Collider 2D' component.
- On the 'Foreground-Collidable' layer, add a 'Tilemap Collider 2D' component.

## Advanced Topics Not Covered or Glossed Over: ##

- Animation clips and Unity Animator
- Rule Tiles and Rule Brushes
- Animated Tiles
- Isometric Tilemaps

## Assets: ##

- https://alexs-assets.itch.io/16x16-outdoors-tileset
- https://maytch.itch.io/free-16x16-pixel-art-8-directional-characters

## Additional resources: ##

- 2d Tilemap tutorial (similar to this one but more in-depth)
	-	https://www.raywenderlich.com/23-introduction-to-the-new-unity-2d-tilemap-system

- Isometric tilemap tutorial:
	- https://blogs.unity3d.com/2019/03/18/isometric-2d-environments-with-tilemap/

- Character Controller tutorial:
	- https://www.youtube.com/watch?v=tywt9tOubEY&ab_channel=Unity