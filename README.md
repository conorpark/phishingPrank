# phishingPrank
A prank designed to help a certain roommate with a Smite MOBA addiction. README contains explaination of attack methodology and the potential of an HTML phishing email for use as an attack vector.

<strong>Warning: The code included in this repository is for demonstration and educational purposes only.</strong>

<h2>Story behind prank </h2>
If you had the opportunity to pull the perfect prank, would you? During my first programming class, I decided to use my newfound skills for such an endeavor. My roommates and I prank each other on a monthly basis, and it was my turn to do so. I figured denying a certain roommate access to Smite when the new patch (with new heros/levels) came out would incite a funny reaction ("rage"). 

To ensure the prank was successful, I followed a series of steps to ensure a successful attack. Before coding, I gathered info about the target (roommate) to custom tailor an attack vector, something I term a Target Oritented Attack. 

Info Gathered:
- Target is in college
- Target is Male
- Target has an Nvidia gpu gaming pc
- Target plays smite
- Email of target
- Target encounters crashes from underpowered gpu

With these 6 data points, I could now setup a successful attack against the target.

<h2>Attack Description</h2> 
<p>Purpose of program: Make program that closes Smite.exe, so target cannot access game</p>
</br>
**I think this missle effectively describes the attack software**
</br>
<img height ="450" src="http://image.prntscr.com/image/67a3e8f2d2084ad799576b3eb03404c2.png" />
</br>

Payload - winipn form. "Windows Network Application" Program runs in background, scans for Smite.exe service, and closes it.
</br>
<img height ="300" src="http://image.prntscr.com/image/43889fc8677a407384315c45c1fb7758.png" />

Package - Fake Nvidia Graphics Driver Installer. Target isn't going to download Payload on his own. The "driver installer" 
          provides the means of attack.
</br>
<img height ="300" src="http://image.prntscr.com/image/1b8419428cb344ad81c94a8e67d8cc29.png" />
</br>
<img height ="300" src="http://image.prntscr.com/image/2f3316ea257e49ca8e285ad047627363.png" />

Delivery System - Email. A meticulously crafted phishing email designed to convince target to download "driver installer".

______________________________________________________________________________________________________________________________
<h2> Conclusion </h2>
Ultimately the attack was successful, my roommate fell for it hook, line, and sinker. The realistic phishing email easily convinced him to download the gpu driver installer, which installed the payload preventing access to Smite. Since this was a prank, a certain "mlg antivirus.exe" program was provided to uninstall the payload, allowing him to play Smite.exe once more. All files, including the "antivirus", are provided in the repository. Certain links/features have been removed to make the code harmless.

The purpose of this prank is to demonstrate that after 1 programming class in vb.net, using the Visual Studio IDE, and Dreamweaver, a potential attacker can create a convincing HTML phishing email to launch a potential attack. Phishing emails are common, and many organizations give trainings designed to boost awareness about the threat. However, with a bit of social engineering and detail-oritented design, a HTML email can look official and include invisible embed links to malicious files rather than attachments. 

Would you be able to detect this as fake?
<br>
<img height ="750" src="http://image.prntscr.com/image/adc635147fc743379b3fc167a3c57c30.png" />
</br>


