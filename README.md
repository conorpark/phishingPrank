# greatestPhishingPrank
A prank designed to help a certain roommate with a Smite MOBA addiction. Explaination of attack methodology and the potential of an HTML phishing email.

Warning: The code included in this repository is for demonstration and educational purposes only. Do not use this code for illegal acts. 
Additional warning: Long explaination ahead..

After one programming class, I decided to use my newfound skills to code a prank. My roommate is addicted to the MOBA PC game Smite, denying him access would encite the desired reaction. 

Before coding, decided to gather info about the target (roommate) to custom tailor an attack vector, something I term Target Oritented Attack. 

Info Gathered:
- Target is in college
- Target is Male
- Target has an Nvidia gpu gaming pc
- Target plays smite
- Email of target
- Target encounters crashes from underpowered gpu

With these 6 data points, I can now setup a successful attack against the target.

Purpose: Make program that closes Smite.exe, so target cannot access game

![alt tag](http://prntscr.com/ch75tb)

Payload - winipn form. Program runs in background, scans for Smite.exe service, and closes it.

Package - Fake Nvidia Graphics Driver Installer. Target isn't going to download Payload on his own. The "driver installer" 
          provides the means of attack.

Delivery System - Email. A meticulously crafted phishing email designed to convince target to download "driver installer".

______________________________________________________________________________________________________________________________
Ultimately the attack was successful, and roommate was prevented from playing Smite.exe. The realistic phishing email easily convinced target to download the gpu driver installer, which installed the payload. Since this was a prank, "mlg antivirus.exe" was provided
to uninstall winipn, allowing target to play Smite.exe once more. 


