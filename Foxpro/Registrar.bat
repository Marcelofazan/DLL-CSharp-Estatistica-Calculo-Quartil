@ECHO OFF
echo %cd%
C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe D:\DLLTeste3\DLLTeste3\Foxpro\DLLTeste3.dll /codebase /tlb
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe D:\DLLTeste3\DLLTeste3\Foxpro\DLLTeste3.dll /codebase /tlb
timeout /t 20
EXIT
