﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_TextoRTF
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TextoRTF))
        Me.RichT_texto = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichT_texto
        '
        Me.RichT_texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichT_texto.Location = New System.Drawing.Point(0, 0)
        Me.RichT_texto.Name = "RichT_texto"
        Me.RichT_texto.Size = New System.Drawing.Size(465, 305)
        Me.RichT_texto.TabIndex = 0
        Me.RichT_texto.Text = ""
        '
        'Form_TextoRTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 305)
        Me.Controls.Add(Me.RichT_texto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_TextoRTF"
        Me.Text = "TextoRTF"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichT_texto As RichTextBox
End Class
