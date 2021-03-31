# Draxeous
# Draxeous by Dichill
# Visit us https://draxeousoffical.wixsite.com/officialrelease
# If your using this, take not this has a license!
# Draxeous Copyright Statement
# Draxeous API | Available for Dichill / Programmers
import os
import time as t
import pyautogui
from WORKMINES import WorkMinesSettings
import datetime
now = datetime.datetime.now()
py = pyautogui

# Starting
os.system("cls")
os.system("color a")
print("[Credits] =========================================================")
print("WorkMines Automated Bot is now Starting")
print("Created by Dichill")
print("[Commencing in]  ===================================================")
print(WorkMinesSettings.Cmd + "Starting in 5")
t.sleep(1)
print(WorkMinesSettings.Cmd + "Starting in 4")
t.sleep(1)
print(WorkMinesSettings.Cmd + "Starting in 3")
t.sleep(1)
print(WorkMinesSettings.Cmd + "Starting in 2")
t.sleep(1)
print(WorkMinesSettings.Cmd + "Starting in 1")
t.sleep(1)
print("[Log]  =============================================================")
# Doing the work
t.sleep(WorkMinesSettings.MessageBoxClose_Seconds)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Closing MessageBox"))
py.click(WorkMinesSettings.Coordinates.MessageBoxClose) # Messagebox Close
t.sleep(WorkMinesSettings.PlayAd_Seconds)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Playing Ad"))
py.click(WorkMinesSettings.Coordinates.PlayAd) # Play Ad
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Waiting for Respond"))
t.sleep(WorkMinesSettings.GoBack_Seconds)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Going Back"))
py.click(WorkMinesSettings.Coordinates.GoBack) # Go Back
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Restarting"))
os.system("""D:\PyCharm Python Projects\venv\Scripts\python.exe" "C:/Saves/WORKMINES/Worker_PlayBack.py""")



