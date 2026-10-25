''' <summary>
''' Required Designer file for Visual Studio 2026 designer integration.
''' This form displays a list of dog names and opens record view on double-click.
''' </summary>
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.ComponentModel

Partial Public Class MainForm
    Inherits Form
    ''' <summary>
    ''' InitializeComponent initializes all form controls through the Designer.
    ''' All layout is done in Visual Studio 2026 designer, not in code.
    ''' </summary>
    Private Sub InitializeComponent()
        ' Main container for dog name list
        Me.DogListView = New ListBox()
        Me.DogListView.Location = New Point(10, 40)
        Me.DogListView.Size = New Size(380, 250)
        Me.DogListView.Font = New Font("Segoe UI", 9F)

        ' Label for dog name list header
        Me.DogNameLabel = New Label()
        Me.DogNameLabel.Location = New Point(10, 10)
        Me.DogNameLabel.Text = "Dog Names"
        Me.DogNameLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)

        ' Status label for messages and feedback
        Me.StatusLabel = New Label()
        Me.StatusLabel.Location = New Point(10, 305)
        Me.StatusLabel.Text = "Ready"
        Me.StatusLabel.Font = New Font("Segoe UI", 8F, FontStyle.Italic)

        ' Set form properties for designer
        Me.Text = "Punter Data Editor"
        Me.Size = New Size(420, 350)
    End Sub

    ''' <summary>
    ''' Dog name list view control created in designer.
    ''' </summary>
    Private WithEvents DogListView As ListBox

    ''' <summary>
    ''' Label showing "Dog Names" header.
    ''' </summary>
    Private WithEvents DogNameLabel As Label

    ''' <summary>
    ''' Status label for displaying messages and feedback.
    ''' </summary>
    Private WithEvents StatusLabel As Label
End Class