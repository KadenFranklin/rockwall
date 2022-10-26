# rockwall


My first real venture into independent website development. I intend- for my senior capstone project- to create a website of The Hendrix College Rockwall. The function of the website will serve to be an interactive tool to make accessible my favorite part of my college. It will also serve as a tool to maintain a record of the rock wall for future use.

The remainder of this markdown file will contain various notes pertaining to the development of this project.

## A Data dictionary

|Feature | DataType | Description|
|:--------|:----------|:------------|
|X-loc | list | Array of the sections X coordinates.|
|Y-loc | list | Array of the sections Y coordinates.|
|X | int | The sections X coordinate, used to index the arrat X-loc|
|Y | int | The sections Y coordinate, used to index the arrat Y-loc|
|Spot | int | A numeric representation of a spots location in a section. |
|H_x | int | Integer describing the x-axis of a hold's section |
|H_y| int | Integer describing the y-axis of a hold's section  |
|H_s | int | Integer describing a hold's spot (pos in a sections spot list)|
|H_c | str | Describes what color a hold is. |
|H_t | str | Describes what type a hold is. |
|H_routes | list: str | List of the names of routes, which this hold is a part of.|
|Hold | list: int | [H_x, H_y, H_s, H_c, H_t] |
|Hold-list | list: lists | A list of lists, containing the variables associated with this particular hold. The first list, Hold contains everything needed to map the hold to a section. The second list, is H_routes, a list of routes associated with the hold.  |
|Spot-list | list: int | A list of integers expressing the number of spots, located in associated section |
|Section-dict | dict: str, list | The dictionary associated with a particular section. Contains: Spot-list, Hold-list |
|Section | dict : tuple(x)(y), Section-dict | A 3' x 3' 'section' of the wall, which is expressed as a dictionary of tuple and another dict, containing attributes of that section|
|R-name | str    |  The name of the associated rock climbing route, an element of route-list   |
|R-date |  str  |  The date in which the route was set  |
|R-author |  str   |  The name of the route setter  |
|R-comments |  str   | Additional comments possibly helpful to completion of the route   |
|R-rating |  str   |  The difficult of said route expressed on a 5.6- 5.14 scale (Top rope) or V0-V14 scale(Boulder) |
|R-tape |  str   |  The color of tape with the associated route, an element of tape-colors   |
|Route |   tuples(x,y): list[Hold-list]  | A collection of holds in their associated spots along with other data. It will contain one of each of the variables mentioned above, along with a dictionary of tuples(x,y): list[Hold-list]|

* The X coordinate being its location horizontally on the wall.
* (0, being the furthest left section, and 14 being the furthest right section)

* The Y coordinate being its location vertically on the wall.
* (0, being the closest to the ground, and 8 being the closest to the ceiling)

* 	The wall is composed of a total of 112 sections,
* 	in total there are 8 rows (vertical) x 14 columns (horizontal) of sections of wall

# Static Lists:
hold_type = ['Bulb', 'Crack', 'Flake', 'Foot', 'Crimp', 'Horn', 'Jug', 'Ledge', 'Pinch', 'Pocket', 'Sloper', 'Under-Cling']

route_list = [ 'fish[v2]', 'Pebble[v3]', 'Jump master', 'Hey Peter', 'yellow[v5]', 'Gaston', 'G_2' 'feather[v4]', 'Peacock', 'space-tape', 'red-roan' "reeces'-folley", 'Turtle-soup[v3]', 'lightning[v3]', 'Owl Route', 'that_one[v5]' 'hawaii[v3]', 'Chicken neck', 'red_2' 'Cytoplasm', 'Green Gaston', 'America_the_great', 'purple[v2]', 'cupcake', 'flames[v2]', 'yellow[v2]', 'Traverse', 'teal', 'cupcake', 'zebra', 'white(arret)'  ]

pos_spots = ["Far-Top-Left", "Far-Left-Upper", "Far-Upper-Left", "Top-Left", "Far-Left", "Left-Upper", "Top-Middle", "Left", "Center-Left", "Center-Top-Left", "Center-Top", "Top", "Center-Top-Right", "Center-Right", "Right", "Right-Upper", "Far-Right", "Top-Right", "Far-Upper-Right", "Far-Right-Upper", "Far-Right-Lower", "Far-Top-Right", "Center", "Center-Bottom-Right", "Right-Lower", "Far-Lower-Right", "Bottom-Right", "Far-Bottom-Right", "Center-Bottom", "Bottom", "Bottom-Middle", "Bottom-Left", "Center-Bottom-Left", "Left-Lower", "Far-Lower-Left", "Far-Bottom-Left", "Far-Left-Lower"]



# Additional information:
  * a size of 3' ^2  (Three square feet) per section of wall
  * : 	We find the total surface area of the rock wall to be 1008 (If it was completely flat)
  * The true surface area of the wall would involve much more calculation because of the variation in surface depth on the overhang.
  * There are a total of 13 ropes affixed to the wall via top bolts (9 quickdraws, 4 repel devices)
  * The ropes are located in between the seem where sections of the wall meet.
  * Any given section of wall can have an average of _ spots.

      Every spot may contain 1 hold.

	  Some spots are used to a fix hardware sometimes needed for an ascension to the wall.

	  Such hardware is denoted as its own type of hold in the data.

  * For a semi descriptive visual reference please refer to the file, 'diagram_1', or 'diagram_2'.
