''' <summary>
''' Main form for Punter Data Editor - displays list of greyhounds and opens record view on double-click.
''' </summary>
Imports System.IO

Partial Public Class MainForm
    ''' <summary>
    ''' The main dog dataset path (read-only).
    ''' </summary>
    Private ReadOnly DatasetPath As String = "../data/dogs_dataset.csv"

    ''' <summary>
    ''' Event handler: triggered when a dog name is selected. Double-click opens record view.
    ''' </summary>
    Private Sub DogListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DogListView.SelectedIndexChanged
        If DogListView.SelectedItem IsNot Nothing Then
            Dim selectedDogName = CStr(DogListView.SelectedItem)

            ' Clear previous selection for cleaner UI
            Me.DogListView.SelectedIndex = -1

            ' Show status message
            Me.StatusLabel.Text = $"Selected: {selectedDogName}"
        Else
            Me.StatusLabel.Text = "Ready"
        End If
    End Sub

    ''' <summary>
    ''' Event handler for double-click on dog name to open record view.
    ''' </summary>
    Private Sub DogListView_DoubleClick(sender As Object, e As EventArgs) Handles DogListView.DoubleClick
        ' TODO: Create and show record view form for selected dog
        Me.StatusLabel.Text = "Double-click to view dog details (record view)"
    End Sub

    ''' <summary>
    ''' Loads all dogs from CSV into the list.
    ''' </summary>
    Private Sub LoadDogs()
        If Not File.Exists(DatasetPath) Then
            Me.DogListView.Items.Clear()
            Me.StatusLabel.Text = $"Error: Dataset not found at {DatasetPath}"
            Return
        End If

        Me.StatusLabel.Text = "Loading dogs..."

        Try
            Dim lines As String() = System.IO.File.ReadLines(DatasetPath).ToArray()
            Dim dogNames As New List(Of String)

            For i = 1 To lines.Length - 1  ' Skip header at index 0
                Dim parts = lines(i).Split(",")
                If parts.Length >= 2 Then
                    dogNames.Add(parts(1))
                End If
            Next

            Me.DogListView.Items.AddRange(dogNames.ToArray())
            Me.StatusLabel.Text &= $" Loaded {dogNames.Count} dogs"
        Catch ex As Exception
            Me.StatusLabel.Text = $"Error loading dataset: {ex.Message}"
        End Try
    End Sub

    ''' <summary>
    ''' Form initialization - runs once when form loads.
    ''' </summary>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DogListView.Items.Clear()  ' Clear default template items
        Me.LoadDogs()
    End Sub

    ''' <summary>
    ''' Helper property to get selected dog name from list.
    ''' </summary>
    Public ReadOnly Property SelectedDogName As String
        Get
            If DogListView.SelectedItem IsNot Nothing Then
                Return CStr(DogListView.SelectedItem)
            Else
                Return String.Empty
            End If
        End Get
    End Property
End Class