# phishingPrank
A prank designed to help a certain roommate with a Smite MOBA addiction. README contains explaination of attack methodology and the potential of an HTML phishing email for use as an attack vector.

<strong>Warning: The code included in this repository is for demonstration and educational purposes only.</strong>

<h1>Story behind prank </h1>
If you had the opportunity to pull the perfect prank, would you? During my first programming class, I decided to use my newfound skills for such an endeavor. My roommates and I prank each other on a monthly basis, and it was my turn to do so. I figured denying a certain roommate access to Smite when the new patch (with new heros/levels) came out would incite a funny reaction ("rage"). 

To ensure the prank was successful, I followed a series of steps to ensure a successful attack. Before coding, I gatheedr info about the target (roommate) to custom tailor an attack vector, something I term a Target Oritented Attack. 

Info Gathered:
- Target is in college
- Target is Male
- Target has an Nvidia gpu gaming pc
- Target plays smite
- Email of target
- Target encounters crashes from underpowered gpu

With these 6 data points, I can now setup a successful attack against the target.

<h1>Purpose: Make program that closes Smite.exe, so target cannot access game</h1>

**I think this missle effectively describes the attack software**
<br>
<img height ="450" src="http://image.prntscr.com/image/67a3e8f2d2084ad799576b3eb03404c2.png" />
</br>

Payload - winipn form. "Windows Network Application" Program runs in background, scans for Smite.exe service, and closes it.

Package - Fake Nvidia Graphics Driver Installer. Target isn't going to download Payload on his own. The "driver installer" 
          provides the means of attack.

Delivery System - Email. A meticulously crafted phishing email designed to convince target to download "driver installer".

______________________________________________________________________________________________________________________________
Ultimately the attack was successful, and roommate was prevented from playing Smite.exe. The realistic phishing email easily convinced target to download the gpu driver installer, which installed the payload. Since this was a prank, "mlg antivirus.exe" was provided
to uninstall winipn, allowing target to play Smite.exe once more. All files, including the "antivirus", are provided in the repository. Certain links/features have been removed to make the code harmless.

The purpose of this prank is to demonstrate that after 1 programming class in vb.net, Visual Studio IDE, and Dreamweaver, a potential attacker can create a convincing HTML phishing email to launch a potential attack. Phishing emails are common, and many organizations give trainings designed to boost awareness about the threat. However, with a bit of social engineering and detail-oritented design, a HTML email can look official and include invisible embed links to malicious files. 

Would you be able to detect this as fake?
<br>
<img height ="750" src="http://image.prntscr.com/image/adc635147fc743379b3fc167a3c57c30.png" />
</br>


