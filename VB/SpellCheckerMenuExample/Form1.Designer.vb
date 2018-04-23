Namespace SpellCheckerMenuExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling2 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling3 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(12, 12)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(231, 81)
            Me.spellChecker1.SetSpellCheckerOptions(Me.textBox1, optionsSpelling1)
            Me.textBox1.TabIndex = 0
            Me.textBox1.Text = "Standard TextBox Control" & ControlChars.CrLf & ControlChars.CrLf & "the the errror dedxs"
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.Location = New System.Drawing.Point(277, 12)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(290, 326)
            Me.spellChecker1.SetSpellCheckerOptions(Me.richTextBox1, optionsSpelling2)
            Me.richTextBox1.TabIndex = 1
            Me.richTextBox1.Text = "Standard RichTextBox Control" & ControlChars.Lf & ControlChars.Lf & "the the errror"
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.EditValue = "DevExpress MemoEdit Control" & ControlChars.CrLf & ControlChars.CrLf & "the the errror"
            Me.memoEdit1.Location = New System.Drawing.Point(12, 109)
            Me.memoEdit1.Name = "memoEdit1"
            Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
            Me.memoEdit1.Size = New System.Drawing.Size(231, 229)
            Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling3)
            Me.memoEdit1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(579, 352)
            Me.Controls.Add(Me.memoEdit1)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.textBox1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private textBox1 As System.Windows.Forms.TextBox
        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private richTextBox1 As System.Windows.Forms.RichTextBox
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace

