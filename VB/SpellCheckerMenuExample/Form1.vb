Imports DevExpress.XtraBars
Imports DevExpress.XtraSpellChecker
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace SpellCheckerMenuExample
    Partial Public Class Form1
        Inherits Form

        Private popupMenu1 As New PopupMenu()
        Private barManager1 As New BarManager()

        Public Sub New()
            InitializeComponent()
            AddHandler spellChecker1.PrepareSuggestions, AddressOf spellChecker1_PrepareSuggestions
            barManager1.Form = Me
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
            spellChecker1.ParentContainer = Me
            spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True

            popupMenu1.Manager = barManager1
            AddHandler barManager1.QueryShowPopupMenu, AddressOf barManager1_QueryShowPopupMenu

            ' Add spelling menu to the standard controls.
            barManager1.SetPopupContextMenu(textBox1, popupMenu1)
            barManager1.SetPopupContextMenu(richTextBox1, popupMenu1)
        End Sub

        Private Sub barManager1_QueryShowPopupMenu(ByVal sender As Object, ByVal e As QueryShowPopupMenuEventArgs)
            Dim position As Point = e.Control.PointToClient(e.Position)
            Dim [error] As DevExpress.XtraSpellChecker.Rules.SpellCheckErrorBase = spellChecker1.CalcError(position)
            e.Cancel = [error] Is Nothing
            Dim commands As List(Of SpellCheckerCommand) = spellChecker1.GetCommandsByError([error])
            If commands IsNot Nothing Then
                popupMenu1.ItemLinks.Clear()
                For Each command As SpellCheckerCommand In commands
                    Dim item As New BarButtonItem(barManager1, command.Caption)
                    item.Enabled = command.Enabled
                    item.Tag = command
                    AddHandler item.ItemClick, AddressOf OnPopupMenuItemClick
                    popupMenu1.ItemLinks.Add(item)
                Next command
                Dim itemShowSpellingForm As New BarButtonItem(barManager1, "Show Spelling Form")
                AddHandler itemShowSpellingForm.ItemClick, AddressOf OnPopupMenuShowSpellingForm_ItemClick
                popupMenu1.ItemLinks.Add(itemShowSpellingForm)
            End If
        End Sub

        Private Sub OnPopupMenuItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            TryCast(e.Item.Tag, SpellCheckerCommand).DoCommand()
        End Sub

        Private Sub OnPopupMenuShowSpellingForm_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            spellChecker1.Check(Me.ActiveControl)
        End Sub

        #Region "#preparesuggestions_event"
        Private Sub spellChecker1_PrepareSuggestions(ByVal sender As Object, ByVal e As PrepareSuggestionsEventArgs)
            Dim pattern As String = "(De|de)[a-z]+x[a-z]*s+"
            Dim rgx As New System.Text.RegularExpressions.Regex(pattern)
            If rgx.IsMatch(e.Word) Then
                e.Suggestions.Insert(0, New SuggestionBase("DevExpress", 0))
            End If
        End Sub
        #End Region ' #preparesuggestions_event
    End Class
End Namespace
