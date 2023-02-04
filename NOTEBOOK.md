# Notebook

# Links

# Keywords

# Structure

# Blackboard
- <size of character sheets>
    - 8x8 16x16 32x32 48x48
    - keywords
        - 2d pixel character spritesheet
        - flipbook

- <asset links>
    - traveler
        - https://itch.io/login?return_to=https%3A%2F%2Fitch.io%2Fg%2Fhappyrat113%2Fthe-traveler%2Fadd-to-collection%3Fsource%3Dbrowse&intent=add_to_collection
    - zegley 2d platformer 
        - https://zegley.itch.io/2d-platformermetroidvania-asset-pack
    - mystic woods
        - https://game-endeavor.itch.io/mystic-woods/download/eyJpZCI6MTMyMTQ3MSwiZXhwaXJlcyI6MTY3NTQyNDQwOX0%3d.7Br9OvAR%2fdyL%2bO0ZLMdxMrMtF9A%3d

- <basic character animations>
    - idle
    - walk
    - run
    - croutch
    - combat stance

# Procedure
- create art folder
- open character sprite sheet on inspector
    - advanced > filter mode: point (no filter)
    - advanced > compression: none
    - sprite mode: single / multiple depending on sheet
    - open sprite editor
        - slice based on cell count, splice, apply
    - drag drop first frame to scene to create game object
    - change name, tag to player
    - transform 0 0 0 
    - create folder characters > player
        - drag game object to player folder to create prefab
    - main camera on inspector
        - change background color to: 202020 blue tint 121618 222526
        - size 1
        - add component: pixel perfect camera
            - tick upscale screen size
    - game: aspect ratio 16:9
    - add game object > 2d > tile map > rectangular
        - change grid size 0.16x
    - window > 2d > tilepalette
        - slice plains, pixel per unit same size as your palet insert tile palette
        - add overlay 2d tileset
        - add collisionobjects 2d tileset
    - window > package manager
        - change packages in project to unityregistry
        - search input system
        - add player go component > player input
        - click right top icon on the main frame and scale down the icon
        - on player input component > create actions: PlayerInputActions
        - on player go add component > custom script: PlayerController
        - set script
        - on palyer go add component rigidbody2d
            - set bodytype to kinematic
        - onplayer go add component box collider2d


# How to
- <collision is too wide>
    - reduce collision offset in your script

- <change text editor of unity>
    - on top left window > edit > preferences > external tools > external script editor

- <faster switch between play and edit mode>
    - edit > project settings > editor 
        - enter play mode options
        - reload domain disabled
        - reload scene enabled

- <template setup>
    - unity projesini yaratirken git root dosyasini sec 

