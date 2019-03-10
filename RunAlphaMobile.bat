ECHO OFF
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc -out:.\SingaporeClient.exe .\SingaporeClient.cs .\Client.cs .\AlphaMobile.cs
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc -out:.\NewYorkClient.exe .\NewYorkClient.cs .\Client.cs .\AlphaMobile.cs
.\SingaporeClient.exe
.\NewYorkClient.exe
del .\SingaporeClient.exe
del .\NewYorkClient.exe
PAUSE