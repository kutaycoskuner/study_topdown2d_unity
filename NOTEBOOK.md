# Notebook

# Links
- game ui database referencing for ui
    - https://www.gameuidatabase.com/

- what is interface
    - https://www.youtube.com/watch?v=MZOrGXk4XFI

- paper plane animation
    - https://www.youtube.com/watch?v=pNek1tRkhqg

- unity good naming convention
    - https://stackoverflow.com/questions/24586319/what-is-a-good-naming-convention-for-unity

# Keywords

# Structure

# Blackboard
- <interface>
    - data bulundurmamasi gereken bir sey
    - arayuzu
    - o class ile nasil etkilestiyorsun
    - fonksiyon cagrilarini bir araya topluyor

- <Naming conventions>
    - snake_case, camelCase, PascalCase
    - folder names PascalCase
    - class variables camelCase
    - id kisaltmasi buyuk yaziliyor ex: ID
    - Classes and functions are PascalCase
    - file names
        - category names: ex. Animator Controllers AC_name
        - A for abstract class A_Item
        - I for interface I_Interface
    - 

- <image conventions>
    - item placeholder 
        - stroke 6px #000, fill #fff
        - name: a_itemName

- <inventory>
    - acquiring methods
        - pick up
        - gather
        - loot
        - steal
        - craft
    - script: Item
    - script: ItemData | Item | 
    - inventory ui, shop iu, container ui, crafting ui
        - itemid
        - itemname
        - category
        - icon
        - model
        - prefab

- <item categories>
    - equipables
        - apparel
        - weapons
        - shields
        - tools
        - instruments
    - consumables
        - potions
        - scrolls
        - food
    - placeable (could only placed allowed places have long despawn time can be locked to prevent despawn)
        - furniture
        - oven
        - wall
        - seeds
    - interractables
        - letters
        - books
        - runes
    - material
        - seed
        - ingredient (herbs and food material)
        - metals
        - gems
    - misc
        - keys
        - gold

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
- <character animation>
    - on player folder rigt click create animator controller
    - add animator component to player
    - window > animation > animation
    - window > animation > animator
    - create new folder animations
    - select images with shift drag to animation window
    - create another animation
    - select animator
    - create parameter from left
    - create links between states
        - conditions add parameter
        - disable has exit time
        - transition duration 0
    - open script'

- <adding follow camera>
    - package manager: cinemachine
    - top menu > gameobject > cinemachine > 2d camera
    - virtual camera > follow > plaeyer
    - virtual camera > select pixelperfectextension


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

