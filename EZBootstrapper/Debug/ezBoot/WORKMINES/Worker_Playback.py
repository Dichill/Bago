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

t.sleep(WorkMinesSettings.MessageBoxClose_Seconds2)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Closing MessageBox"))
py.click(WorkMinesSettings.Coordinates.MessageBoxClose)
t.sleep(WorkMinesSettings.PlayAd_Seconds2)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Playing Ad"))
py.click(WorkMinesSettings.Coordinates.PlayAd)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Waiting for Respond"))
t.sleep(WorkMinesSettings.GoBack_Seconds2)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Going Back"))
py.click(WorkMinesSettings.Coordinates.GoBack)
print("[" + now.strftime("%Y-%m-%d %H:%M:%S" + "]" + " Restarting"))
os.system("""D:\PyCharm Python Projects\venv\Scripts\python.exe" "C:/Saves/WORKMINES/Worker_PlayBack.py""")
