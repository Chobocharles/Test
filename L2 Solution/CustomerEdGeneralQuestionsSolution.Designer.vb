﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerEdGeneralQuestionsSolution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerEdGeneralQuestionsSolution))
        Me.btnSimilarIncidents = New System.Windows.Forms.Button()
        Me.btnDidntWork = New System.Windows.Forms.Button()
        Me.btnWorked = New System.Windows.Forms.Button()
        Me.txtGeneralQuestionSolution = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnSimilarIncidents
        '
        Me.btnSimilarIncidents.Location = New System.Drawing.Point(102, 223)
        Me.btnSimilarIncidents.Name = "btnSimilarIncidents"
        Me.btnSimilarIncidents.Size = New System.Drawing.Size(111, 23)
        Me.btnSimilarIncidents.TabIndex = 3
        Me.btnSimilarIncidents.Text = "&Similar Incidents"
        Me.btnSimilarIncidents.UseVisualStyleBackColor = True
        '
        'btnDidntWork
        '
        Me.btnDidntWork.Location = New System.Drawing.Point(176, 194)
        Me.btnDidntWork.Name = "btnDidntWork"
        Me.btnDidntWork.Size = New System.Drawing.Size(111, 23)
        Me.btnDidntWork.TabIndex = 2
        Me.btnDidntWork.Text = "This &Didn't Work"
        Me.btnDidntWork.UseVisualStyleBackColor = True
        '
        'btnWorked
        '
        Me.btnWorked.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnWorked.Location = New System.Drawing.Point(22, 194)
        Me.btnWorked.Name = "btnWorked"
        Me.btnWorked.Size = New System.Drawing.Size(111, 23)
        Me.btnWorked.TabIndex = 1
        Me.btnWorked.Text = "This &Worked"
        Me.btnWorked.UseVisualStyleBackColor = True
        '
        'txtGeneralQuestionSolution
        '
        Me.txtGeneralQuestionSolution.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtGeneralQuestionSolution.Location = New System.Drawing.Point(12, 10)
        Me.txtGeneralQuestionSolution.Name = "txtGeneralQuestionSolution"
        Me.txtGeneralQuestionSolution.ReadOnly = True
        Me.txtGeneralQuestionSolution.Size = New System.Drawing.Size(285, 178)
        Me.txtGeneralQuestionSolution.TabIndex = 0
        Me.txtGeneralQuestionSolution.Text = resources.GetString("txtGeneralQuestionSolution.Text")
        '
        'CustomerEdGeneralQuestionsSolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnWorked
        Me.ClientSize = New System.Drawing.Size(309, 257)
        Me.Controls.Add(Me.btnSimilarIncidents)
        Me.Controls.Add(Me.btnDidntWork)
        Me.Controls.Add(Me.btnWorked)
        Me.Controls.Add(Me.txtGeneralQuestionSolution)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerEdGeneralQuestionsSolution"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Questions Solution"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSimilarIncidents As Button
    Friend WithEvents btnDidntWork As Button
    Friend WithEvents btnWorked As Button
    Friend WithEvents txtGeneralQuestionSolution As RichTextBox
End Class
