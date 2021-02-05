<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VegetarianSpecials
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblVegetarianSpecials = New System.Windows.Forms.Label()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.picFalafel = New System.Windows.Forms.PictureBox()
        Me.btnFalafel = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFalafel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVegetarianSpecials
        '
        Me.lblVegetarianSpecials.AutoSize = True
        Me.lblVegetarianSpecials.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVegetarianSpecials.Location = New System.Drawing.Point(60, 15)
        Me.lblVegetarianSpecials.Name = "lblVegetarianSpecials"
        Me.lblVegetarianSpecials.Size = New System.Drawing.Size(293, 34)
        Me.lblVegetarianSpecials.TabIndex = 0
        Me.lblVegetarianSpecials.Text = "Vegetarian Specials"
        '
        'picVeggie
        '
        Me.picVeggie.Image = Global.Vegetarian_Specials.My.Resources.Resources.Veggie
        Me.picVeggie.Location = New System.Drawing.Point(221, 57)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(185, 150)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        '
        'picFalafel
        '
        Me.picFalafel.Image = Global.Vegetarian_Specials.My.Resources.Resources.Falafel
        Me.picFalafel.Location = New System.Drawing.Point(6, 57)
        Me.picFalafel.Name = "picFalafel"
        Me.picFalafel.Size = New System.Drawing.Size(185, 150)
        Me.picFalafel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFalafel.TabIndex = 1
        Me.picFalafel.TabStop = False
        '
        'btnFalafel
        '
        Me.btnFalafel.Location = New System.Drawing.Point(13, 214)
        Me.btnFalafel.Name = "btnFalafel"
        Me.btnFalafel.Size = New System.Drawing.Size(107, 26)
        Me.btnFalafel.TabIndex = 3
        Me.btnFalafel.Text = "Falafel"
        Me.btnFalafel.UseVisualStyleBackColor = True
        '
        'btnVeggie
        '
        Me.btnVeggie.Location = New System.Drawing.Point(293, 214)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(107, 26)
        Me.btnVeggie.TabIndex = 4
        Me.btnVeggie.Text = "Veggie Burger"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.Location = New System.Drawing.Point(156, 214)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(107, 26)
        Me.btnSelectMeal.TabIndex = 5
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit Window"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Location = New System.Drawing.Point(29, 247)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(354, 18)
        Me.lblChoose.TabIndex = 7
        Me.lblChoose.Text = "Choose a Meal and then click the Select Meal Button."
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.Location = New System.Drawing.Point(104, 275)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(204, 18)
        Me.lblEnjoy.TabIndex = 8
        Me.lblEnjoy.Text = "Enjoy your Vegetarian Special!"
        '
        'VegetarianSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 348)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnFalafel)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picFalafel)
        Me.Controls.Add(Me.lblVegetarianSpecials)
        Me.Name = "VegetarianSpecials"
        Me.Text = "Vegetarian Specials"
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFalafel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVegetarianSpecials As Label
    Friend WithEvents picFalafel As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnFalafel As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblChoose As Label
    Friend WithEvents lblEnjoy As Label
End Class
