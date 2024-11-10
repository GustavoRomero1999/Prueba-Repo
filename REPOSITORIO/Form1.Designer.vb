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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTNBOTRRAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.Location = New System.Drawing.Point(204, 161)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(98, 54)
        Me.BTNACEPTAR.TabIndex = 0
        Me.BTNACEPTAR.Text = "ACEPTAR"
        Me.BTNACEPTAR.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 1
        '
        'BTNBOTRRAR
        '
        Me.BTNBOTRRAR.Location = New System.Drawing.Point(204, 251)
        Me.BTNBOTRRAR.Name = "BTNBOTRRAR"
        Me.BTNBOTRRAR.Size = New System.Drawing.Size(98, 54)
        Me.BTNBOTRRAR.TabIndex = 2
        Me.BTNBOTRRAR.Text = "BORRAR"
        Me.BTNBOTRRAR.UseVisualStyleBackColor = True
        '
        'FRMPRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 395)
        Me.Controls.Add(Me.BTNBOTRRAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Name = "FRMPRINCIPAL"
        Me.Text = "PRINCIPAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BTNBOTRRAR As System.Windows.Forms.Button

End Class
