ECHO OFF
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc -out:.\AlphaMobile.exe .\Client.cs .\AlphaMobile.cs
.\AlphaMobile.exe
del .\AlphaMobile.exe
PAUSE