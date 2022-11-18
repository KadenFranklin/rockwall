import pandas as pd
from selenium import webdriver
from selenium.webdriver import ActionChains
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.support.ui import Select


spots = pd.read_csv('spots.csv')
holds = pd.read_excel(r"C:\Users\kaden\Documents\github\KadenFranklin.github.io\rockwall\sel\holds.csv")
hardware = pd.read_excel(r"C:\Users\kaden\Documents\github\KadenFranklin.github.io\rockwall\sel\hardware.csv")

spots_df = pd.DataFrame(spots, columns=["Num of list", "Spots 0", "Spots 1", "Spots 2", "Spots 3", "Spots 4", "Spots 5", "Spots 6", "Spots 7"])
holds_df = pd.DataFrame(holds, columns=["Hold ID?", "X-loc", "Y-loc", "Hold type", "Hold color", "[List of] routes"])
hard_df = pd.DataFrame(hardware, columns=["Hold ID?", "X-loc", "Y-loc", "Hold type"])

browser = webdriver.Chrome()

# Spots first:

# for i in spots_df.iterrows():         # i iterates through each row in the dataframe (1-14)
#     browser.get('https://localhost:44367/Spots/Create')
#     browser.refresh()
#     dis = i.__getitem__(1)        # dis is the row of the dataframe (determined by i)
#                                       (skip spot 0 because those are titles)
# ["Num of list", "Spots 0", "Spots 1", "Spots 2", "Spots 3", "Spots 4", "Spots 5", "Spots 6", "Spots 7"]

#    verify then make sure (Then assign variables and send keys)
#     for each in dis:
#        spot = each.split(", ")      # split the string into a list of spot locations in this section


# if ( ):
#     continue
# else:
#     for x,y in enumerate(spots_df):
#         browser.find_element_by_id(list[x]).send_keys(y)

#     browser.find_element_by_id("submit").click()

# or
#     browser.find_element_by_id("Name").send_keys(spot[0])
#     hold_id = browser.find_element(By.ID, "Holds_H_TreeID")
#     hold_id.send_keys(dis[0])
#     hold_loc_x = browser.find_element(By.ID, "Tree_Latitude")
#     tree_loc_x.send_keys(dis[2])
#     tree_loc_y = browser.find_element(By.ID, "Tree_Longitude")
#     tree_loc_y.send_keys(dis[3])

#     sel_loc = Select(browser.find_element(By.ID, "Tree_LocationName"))
#     location = browser.find_element(By.ID, "Tree_LocationName")
#     count = 1


# Hardware:

# Holds:

# for i in holdsdf.iterrows():
#     browser.get('https://localhost:44367/Holds/Create')
#     browser.refresh()
#     dis = i.__getitem__(1)
# ["Hold ID?", "X-loc", "Y-loc", "Spot-Pos", "Hold type", "Hold color", "[List of] routes"])

#    if verify that it is data
#    then make sure (Then assign variables and send keys)

# dis[0] = int HoldID
# dis[1] = int Sect_x
# dis[2] = int Sect_y
# dis[3] = int Spot_pos
# dis[4] = string Hold_Type
# dis[5] = string Hold_Color
# dis[6] = string List_of_routes
# Routes = dis[6].split(", ")
# for this in dis[6].spilt(", "):
    # routes.append(this)

# if ( ):
#     continue
# else:
#     browser.find_element_by_id("Hold").send_keys(spot[0])
#     hold_id = browser.find_element(By.ID, "Holds_HoldID")
#     hold_id.send_keys(dis[0])
#     hold_loc = browser.find_element(By.ID, "Holds_Position")
#     hold_loc.send_keys(dis,[2], dis[3])

#     sel_loc = Select(browser.find_element(By.ID, "Tree_LocationName"))
#     location = browser.find_element(By.ID, "Tree_LocationName")
#     count = 1

#         for option in sel_loc.options:
#             if option.text == dis[1]:
#                 location.send_keys(Keys.ENTER)
#                 break
#             if count == len(sel_loc.options):
#                 browser.get('https://localhost:44367/Locations/Create')
#                 new_loc = browser.find_element(By.ID, "Location_LocationName")
#                 new_loc.send_keys(dis[1])
#                 enter1 = browser.find_element(By.ID, "ENTER")
#                 ActionChains(browser).click(enter1).perform()
#                 browser.get('https://localhost:44367/Trees/Create')
#                 tree_id = browser.find_element(By.ID, "Tree_TreeID")
#                 tree_id.send_keys(dis[0])
#                 tree_lat = browser.find_element(By.ID, "Tree_Latitude")
#                 tree_lat.send_keys(dis[2])
#                 tree_long = browser.find_element(By.ID, "Tree_Longitude")
#                 tree_long.send_keys(dis[3])
#                 sel_loc = Select(browser.find_element(By.ID, "Tree_LocationName"))
#                 location = browser.find_element(By.ID, "Tree_LocationName")
#                 for opt in sel_loc.options:
#                     if opt.text == dis[1]:
#                         location.send_keys(Keys.ENTER)
#                         break
#                     else:
#                         ARROW_DOWN = u'\ue015'
#                         location.send_keys(ARROW_DOWN)
#             else:
#                 ARROW_DOWN = u'\ue015'
#                 location.send_keys(ARROW_DOWN)
#                 count += 1

# Routes:
# Name
# Date
# Setter
# Grade
# Description
# Note
# Holds

    # I dont have a source for this data yet,
    # I will have to manually enter it in the database

# List of Routes:
#



# https://github.com/KadenFranklin/DataEntry/blob/main/main.py