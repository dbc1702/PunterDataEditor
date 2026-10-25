''' <summary>
''' Application entry point for Punter Data Editor.
''' 
''' This is the starting point of the application where we create and show MainForm.
''' </summary>
Imports System.Windows.Forms

Friend Module Program

    ''' <summary>
    ''' Main entry point for the application. Creates MainForm and displays it.
    ''' MainForm handles loading dog names from CSV and opening record views on double-click.
    ''' </summary>
    Friend Sub Main(args As String())
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub

End Module