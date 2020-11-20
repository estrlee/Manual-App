# Manual-App

Welcome to Orano Acid Windows Applicaton to control the Arduino! <br>

This application will allow the user to control an Arduino and Relay board. Make sure that a Bluetooth module is connected to remotely control the Arduino. <br>

This application was specifically made to control the Orano Acid Team’s Arduino and its corresponding relay board. The Application and Arduino code can be downloaded and changed to fit a variety of other projects. <br>

## Installation Instructions <br>

### Downloading Arduino Code: <br>
1.	Connect the Arduino to a computer and push the provided [Arduino Code file](https://github.com/estrlee/Manual-App/blob/master/windows_arduinocode.zip) to the connected Arduino.
2.	Disconnect the Arduino from the computer (Bluetooth module will not communicate with the Arduino if the Arduino is still connected to your computer).

### Connecting to Bluetooth module: <br>
1.	Search for the "Bluetooth & other devices settings" page in your computer search bar. 
2.  Click on "Add Bluetooth or other device"
3.  Select Bluetooth.
4.  Look for HC-06 or unknown device. Enter the password: 1234.

#### Checking Bluetooth module COM Port Number
    You must be connected to the correct COM port to control the Arduino.
1.	Go to the "Bluetooth & other devices settings" page in your settings.
2.	Click on "More Bluetooth options"
3.  Select the "COM Ports" tab.
4.  Make note of the OUTGOING COM Port Number. Use this COM port to connect to the Ardunio. 

### Windows Application Installer: <br>
1.	Download and extract the [Manual App Installer](https://github.com/estrlee/Manual-App/blob/master/Manual%20App%20Installer.zip)
2.	Click on the file --> click debug file --> click the setup.exe file. Follow the on screen instructions.
3.	Open the Manual App.
4.	Select your corresponding OUTGOING COM Port number and click Connect/Disconnect (the Bluetooth module should have a solid light if connected properly).
5.	Your application is now ready!

