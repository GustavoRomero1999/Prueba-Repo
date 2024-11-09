<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.Location = New System.Drawing.Point(44, 119)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(98, 54)
        Me.BTNACEPTAR.TabIndex = 0
        Me.BTNACEPTAR.Text = "ACEPTAR"
        Me.BTNACEPTAR.UseVisualStyleBackColor = True
        '
        'FRMPRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 395)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Name = "FRMPRINCIPAL"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button

End Class
