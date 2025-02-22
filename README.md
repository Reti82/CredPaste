# CredPaste
Paste credentials into remote desktops or TeamViewer or other logins

## Functionality
On startup the program checks the clipboard for changes.
I can copy the username from another program by copying it to the clipboard.
Then do the same for the password.
The user and password are only stored in memory, not physically on a drive.

To insert the credentials, simply activate the window where you want to send the keys.
Press Ctrl + Shift + P to paste. The application will now send the username, a tab key, the password, and then the Enter key to log in.
If "Password only" is checked, only the password and the Enter key will be sent.

![image](https://github.com/user-attachments/assets/e76f7888-c839-4552-838d-99ad25180efc)

To set new Credentials, simply click new and repeat the steps like on startup.

## Why was this developed?
I often use some remote desktops, TeamViewer connections, VDI's and so on and sometimes it is not possible to copy/paste the password from the password manager. 
I was using Keepass and there was a feature to automatically paste it by pressing a shortcut. Our company changed the password manager and this feature was missing. This is the reason.
