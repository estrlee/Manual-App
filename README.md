# Manual-App

Welcome to Orano Acid Windows Applicaton to control the Arduino! <br>

This application will allow the user to control an Arduino and Relay board. Make sure that a Bluetooth module is connected to remotely control the Arduino. <br>

This application was specifically made to control the Orano Acid Team’s Arduino and its corresponding relay board. The form and Arduino code can be downloaded and changed to fit a variety of other projects. <br>

## Installation Instructions <br>

### Downloading Arduino Code and Connecting Bluetooth module: <br>
1.	Connect the Arduino to a computer and push the provided <a href ="https://github.com/estrlee/Manual-App/blob/master/windows_arduinocode.zip"> Arduino Code </a> to the connected Arduino.
2.	Disconnect the Arduino from the computer (Bluetooth module will not communicate with the Arduino if the Arduino is still connected to your computer.
3.	Add the Bluetooth module to your computer through the Bluetooth & other devices page in the settings. Name will appear as HC-06 or unknown device. Enter the password: 1234.
4.	Click on more Bluetooth options located on the Bluetooth & other devices settings page.
5.	Select the COM Ports tab and make note of the OUTGOING COM Port Number.

### Windows Application Installer: <br>
1.	Download and extract the Manual App Installer.zip file.
2.	Click on the file --> click debug file --> click the setup.exe file. Follow the on screen instructions.
3.	Open the Manual App.
4.	Select the corresponding OUTGOING COM Port number and click Connect/Disconnect (the Bluetooth module should have a solid light if connected properly).
5.	Your application is now ready!

