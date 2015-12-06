#Xamarin.Android.jCIFS

This is a C# binding [project](http://github.com/sushihangover/Xamarin.Android.jCIFS) for the Java CIFS (jCIFS) Client Library (version 1.3.18) for Samba networking.

##Notes:

There is a free Andriod app by [LyseSoft](http://www.lysesoft.com/products/andsmb/) that uses JCIFS to build a full Android Samba application. 

The reason to mention this app is not an endorsment, but rather if you are having SMB/Samba connection issues using the Xamarin.Android.jCIFS bindings and JCIFS. You should try this app to see if it can connect to your SMB file server shares to confirm any problems that you might be having since it uses the same Java library.

>[AndSMB](http://www.lysesoft.com/products/andsmb/) is a SMB (Samba/CIFS) client for Android devices. It allows connecting to shared folders hosted on Windows or Samba servers over Wifi/3G/4G. It allows managing several connections with authentication. It comes with both a device file browser and a SMB file browser. It provides download and upload support for files and folders. You can rename, delete, get file details and create folders. It comes with share feature for gallery. Browse and transfer intents are available for third party applications. Root access is not needed.

##Connecting to OS-X File Sharing:

I have had problems using the JCIFS library to connect to OS-X's file shares if the client is not a member of a Wins domain. If your OS-X 10.11.x installation is a stand alone install, like most non-corporate installs will be, I have not **any** success in connecting. If you know of a fix, please open a Gituhb [issue](https://github.com/sushihangover/Xamarin.Android.jCIFS/issues) to share your findings. Thanks.

 