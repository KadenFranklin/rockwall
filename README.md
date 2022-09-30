# rockwall


My first real venture into independent website development.
I intend- for my senior capstone project- to create a website of The Hendrix College Rockwall. The function of the website will serve to be an interactive tool to make accessible my favorite part of my college. It will also serve as a tool to maintain a record of the rock wall for future use.

The remainder of this markdown file will contain various notes pertaining to the development of this project.

'section' 	- a square component of which the wall is composed of 112 such squares
            - located by indexing arrays of, x-loc, and y-loc
'hold' 			- multiform plastic component which is attached to the wall for one to grab
'spot' 			- stationary threaded hole in which a hold is positioned.
'route'			- a collection of holds in a predetermined pattern which one would attempt for a challenge
'wall'			- an annual collection of said routes maintained by Hendrix College Climbing Coalition Historian

A section of the wall's location coordinates to correspond to its location in physical space

* The X coordinate being its location horizontally on the wall.
* (0, being the furthest left section, and 14 being the furthest right section)

* The Y coordinate being its location vertically on the wall.
* (0, being the closest to the ground, and 8 being the closest to the ceiling)

* 	The wall is composed of a total of 112 sections,
* 	in total there are 8 rows (vertical) x 14 columns (horizontal) of sections of wall

# Additional information:
  * a size of 3' ^2  (Three square feet) per section of wall
  * : 	We find the total surface area of the rock wall to be 1008 (If it was completely flat)
  * The true surface area of the wall would involve much more calculation because of the variation in surface depth on the overhang.
  * There are a total of 13 ropes affixed to the wall via top bolts (9 quickdraws, 4 repel devices)
  * The ropes are located in between the seem where sections of the wall meet.
  * Any given section of wall can have an average of _ spots.
    #  Every spot may contain 1 hold.
    #  Some spots are used to a fix hardware sometimes needed for an ascension to the wall.
    #  Such hardware is denoted as its own type of hold in the data.

  * For a semi descriptive visual reference please refer to the file, '_'.
