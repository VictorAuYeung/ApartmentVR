# ApartmentVR
Apartment Tour VR using Unity and Oculus Integration.

This project is __incomplete__, and is intended as a demo. Further optimizations can be made to in-headset UI, more effective and less laggy lighting, as well as movement controls.

This project was created using Unity and Unity's Oculus Development Kit.
For information on how to use the folders and preview the project, see: https://docs.unity.com/

## Features
### 360 Degree Movement:
Moving around the virtual environment is handled by the left Oculus Controller joystick. Push the joystick in the intended direction to move.

### Field of View and Looking Around:
By default, looking around is already handled by the __Oculus Headset__. However, the right Oculus Controller joystick can be used to face a different direction. (Note that this _may not_ work properly, and only works in the horizontal axis.)

### Object Interaction:
Currently, the only interactable objects are UI elements and _doors_. UI elements can be selected via the controller pointer mechanic, where a Raycast is created on the most recently active controller (Left or Right) towards the UI Menu, and can be controlled just like a virtual cursor. This is a standard mechanic in most VR UI menus.

_Doors_ are a slightly buggy feature, and open upon proximity to the user. Further optimizations can be done with doors.

## Additional Info
This project is intended for the Oculus Quest headset and is intended to be built for Android within Unity.
