Module MainModule
    Dim OSMajor As String
    Sub Main()
        'Declaration Of Variables

        Dim OSName = My.Computer.Info.OSFullName
        Dim OSVer = My.Computer.Info.OSVersion
        Dim OSArch As String
        '
        'For Windows 10 ONLY convert build number to scheme ex. 1903
        If OSVer = "10.0.18362.0" Then
            OSVer = "1903"
        Else OSVer = My.Computer.Info.OSVersion
        End If
        '
        'Determine if x64 or x86
        If System.Environment.Is64BitOperatingSystem = True Then
            OSArch = "x64"
        Else
            OSArch = "x86"
        End If
        '
        'Write results to command line
        Console.WriteLine($"Your Computer Is Running : {OSName} {OSVer} {OSArch}")
        'Break
    End Sub

End Module
