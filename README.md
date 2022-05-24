# KeyLocks Simple

簡易的鍵盤指示燈監控小程式  
Simple Keylocks LEDs Indicator  

## Features

* 低系統資源用量  
  Low system resources cost  
  (Icon only update at status change(scan every 80ms))
* 懸浮視窗功能(可隱藏)  
  Floating window(Hideable)
* 就是。很。簡。單。  
  Just. very. simple.
  
## Which environment I use
* .NET Framework 3.5+ (Maybe can run on Windows XP)  
  (可能可以在Windows XP上運作)
* Visual Studio 2019
* Release binary build and test on Windows 11

## Captures

![Floating Window and About Window](https://i.imgur.com/nfWS09R.png)

![Tray Icon](https://i.imgur.com/H0ncZCx.png)

## How to auto start this program on login?

### 如何在登入的時候就啟動這個程式？

1. Extract the program to a folder(Program will start from here)  
   解壓程式到一個資料夾(之後程式從這裡執行)  
   ![Step1](https://i.imgur.com/0WkVqCk.png)  

2. Create Shortcut  
   建立捷徑  
   ![Step2](https://i.imgur.com/RSHexn1.png)  

3. Rename it  
   重命名  
   ![Step3](https://i.imgur.com/P60fDng.png)  
4. Move shortcut to startup folder  
   將捷徑移動到"啟動"資料夾  
   ![Step4](https://i.imgur.com/s09Kx8k.png)  
   **For current user(目前使用者登入時):**  
   `%appdata%\Microsoft\Windows\Start Menu\Programs\Startup`  
   **For all users(所有人登入時):**  
   `C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup`
