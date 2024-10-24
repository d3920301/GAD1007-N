# Gameplay Scripting Design Document

by me :)

## HELLO
hiii so we are completely scrapping the pinball game, and the smile for me game. 

We are focusing on the jousting game by expanding the gameplay. We are adding a store, and maybe a death state?

Jousting - Between rounds we go to the shop. We can change gear here to better suit our next opponent. (More health, or more armour) - Cant use every item at the same time. Use transform movement?

## Contents

1. [Game Ideas](#game-ideas)
    1. [Movement](#movement)
    2. [Microinteractions](#microinteractions)
2. [Art Style](#art-style)
3. [Music and Sound](#music-and-sound)

## Game Ideas

- Jousting

- Pinball but player can control movement

- Nobody has rigidbody 2d and has to move with transform :(

### Movement

Jousting game? THis lets you have interesting movement mechanincs because you are on a horse? - Tough to control?

A game where you have to bounce off the wall as hard as you can? - Let the player go really fast but also has very tight control/

Player can only move forward? Use translate? Bouncing off env lets change direction to get to goal? <- This one doesn't NEED to have rigidbody. Let phase through props/walls? Use collider to manage restrictions? 
^ <- WHAT IF THIS ONNE WAS IN 3D AND THE STYLE OF SMILE FOR ME? LIKE THE NPCS GET MAD/DISAPOINTED IF YOU PASS THROUGH THEM? A world that lives without rigidbodys? Going from :grin: to :slight_frown:

### Microinteractions

Jousting - Bodies from prev rounds on the ground?

Pinball - Dents in walls? (SECRET: HITTING THE WALL ENOUGH TIMES IN THE SAME SPOT BREAKS OPEN WALL???)

NHR2DAHTMWT - NPCs get sadder and sadder every time you pass through them

Since we have to make at least one direct players... In pinball level, there is a door that can obviosly be broken through.

Since we have to make at least one restrict players... In NHR2DAHTMWT level, if NPCs get sad enough they will chase the and reset the player's transform. This resets their agro.

## Art Style

Jousting - 2D pixel art

Pinball - Flat 2D

NHR2DAHTMWT - 3D Smile For Me :)/2D/Some billboard characters

## Music and Sound

Jousting - 8-bit sound effects.

Pinball - Upbeat, fast. Realistic.

NHR2DAHTMWT - Kind of creepy, non-sensical.
