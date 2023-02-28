# Notebook

# Links
- game ui database referencing for ui
    - https://www.gameuidatabase.com/

- day/night color scheme
    - https://codepen.io/bork/pen/WNrmWr

- what is interface
    - https://www.youtube.com/watch?v=MZOrGXk4XFI

- paper plane animation
    - https://www.youtube.com/watch?v=pNek1tRkhqg

- unity good naming convention
    - https://stackoverflow.com/questions/24586319/what-is-a-good-naming-convention-for-unity

- game programming patterns
    - https://gameprogrammingpatterns.com/architecture-performance-and-games.html

- unity inventory definitive tutorial
    - https://www.youtube.com/watch?v=oJAE6CbsQQA&t=1179s

- 2d grid building system
    - https://www.youtube.com/watch?v=G2w78Xk6UhU&t=0s

- jayanam inventory
    - https://www.youtube.com/watch?v=Hj7AZkyojdo&list=PLOyj0nn-asmaqBZ_hGoCh-PBlraNaHLyA&index=8

- time system unity
    - https://www.youtube.com/watch?v=Y_AOfPupWhU
    - https://www.youtube.com/watch?v=0nq1ZFxuEJY

- shader
    - realtime toon shader and outline blender 2.8 eve
        - https://www.youtube.com/watch?v=QLSZRfcUiQI
    - blender pixel art 1 min
        - https://www.youtube.com/watch?v=8uleyXAYl8E
    - Animated PIXEL ART Characters Sprites
        - https://www.youtube.com/watch?v=eSqb6II3WMM

- grass references
    - https://www.youtube.com/watch?v=aZ64y2-4xWQ
    - https://www.youtube.com/watch?v=Zp48BBbYLpA

# Artstyle refrences
- graveyard keeper

# Keywords
- toon shader
- outline shader
- pixel art shader
- cel shader
- halftone effect

# Structure

# Blackboard
- <blender camera settings>
    - orthographic
    - loc: x0, y-7.7, y11.6
    - rot: x36

- <animation for 2d charaters>
    - select every keyframe press t for interpolation | set constant
    - character has animation for every 15 degree
    - every angle has 8 frame animation
    - total 193 frame
    - camera keyframes 45 -> 25, 49, 73, 97, 121, 145, 169, 193 (8*3n+1)
    - 72 pixel 8 frame dope sheet animation 576 

- <geometry nodes>
    - prodecural damage

- <effects>
    - lens flare
    - god rays
    - rain drop ticks
    - leave glow
    - 

- <model making stones>

- <blender pixel setup>
    - set mataterial
    - res x y = 256
    - compression 0
    - samping 1
    - transparent

    - evee
    - 10 times of desired res 1280x1280
    - film transparent
    - filter size 0
    - color management view transform : standard
    - reduce radius on light
    - orthographic perspective
    - rotation x 65 z 45
    - add empty and parent to camera to control
    - compositor add 2 scale and pixelate inbetween
    - add free style
    - view layer properties

- <solid test on blender>
    - https://blender.stackexchange.com/questions/48/what-is-the-simplest-way-to-generate-a-dodecahedron
    - edit > pref > addon > extra objects mesh
    - add > mesh > math functino > regular solid

- <org: categories>
    - sound
    - programming
    - graphics
    - story
    - mechanics

- <gradient daynight scale>
    - 082955
    - f9cd7f
    - fbf4f3
    - f2eab6
    - eeb786
    - f37b5e
    - 2a2554

- <universal render pipeline>
    - window > package manager > search universal render pipeline
    - project > create > rendering > universal render pipeline > forward
    - edit > project settings > graphics: select uni rp

- <mindwork: bars>
    - static: health, mana, stamina, cast
    - dynamic: enemy health bar, construction bar

- <mindwork: time system ui>
    - hava tipini gorsel olarak gosteren ikon ve saat
    - gun, ay tarih, saat, hava durumu ikonu

- <mindwork: inventory save>
    - player in inventorisine dair item listesi tut
        - item unique idsi, inventory pozisyonu


- <computer science>
    - what is static

- <visual studio>
    - ctrl > m + o  collapse all functions
    - ctrl > k + u  uncomment
    - ctrl > k + c  comment out
    - f9 debug breakpoint add remove
    - f5 continue
    - ctrl alt a callstack?

- <interface>
    - data bulundurmamasi gereken bir sey
    - arayuzu
    - o class ile nasil etkilestiyorsun
    - fonksiyon cagrilarini bir araya topluyor

- <Naming conventions>
    - snake_case, camelCase, PascalCase
    - folder names PascalCase
    - class variables camelCase
    - often used two words written as one single word: 
        - ex. Pickup, Unregister, Id
    - bool variables is, does, exists start with 
        - ex. b_textActive
    - display element variables starts with 
        - display_text 
    - Classes and functions are PascalCase
    - file names
        - category names: ex. Animator Controllers AC_name
        - A for abstract class A_Item
        - I for interface I_Interface
        - S for system S_Inventory
        - T for test    T_Test
        - D for data class
    - 

- <image conventions>
    - item placeholder 
        - stroke 6px #000, fill #fff
        - name: a_itemName

- <inventory>
    - interaction methods
        - inspect
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
- <wind effect>
    - create > shader > splite lit graph

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

