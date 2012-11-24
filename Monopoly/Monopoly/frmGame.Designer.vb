<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.picBoard = New System.Windows.Forms.PictureBox()
        Me.lblScorePanel = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblMoneyAmount1 = New System.Windows.Forms.Label()
        Me.lblMoney1 = New System.Windows.Forms.Label()
        Me.picPlayer1Color = New System.Windows.Forms.PictureBox()
        Me.lblProps1 = New System.Windows.Forms.Label()
        Me.cmbProperties1 = New System.Windows.Forms.ComboBox()
        Me.cmbProperties2 = New System.Windows.Forms.ComboBox()
        Me.lblProps2 = New System.Windows.Forms.Label()
        Me.picPlayer2Color = New System.Windows.Forms.PictureBox()
        Me.lblMoney2 = New System.Windows.Forms.Label()
        Me.lblMoneyAmount2 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.btnSell1 = New System.Windows.Forms.Button()
        Me.btnTrade1 = New System.Windows.Forms.Button()
        Me.btnTrade2 = New System.Windows.Forms.Button()
        Me.btnSell2 = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoard
        '
        Me.picBoard.Image = Global.Monopoly.My.Resources.Resources.Board
        Me.picBoard.Location = New System.Drawing.Point(1, 0)
        Me.picBoard.Name = "picBoard"
        Me.picBoard.Size = New System.Drawing.Size(855, 857)
        Me.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard.TabIndex = 0
        Me.picBoard.TabStop = False
        '
        'lblScorePanel
        '
        Me.lblScorePanel.AutoSize = True
        Me.lblScorePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScorePanel.Location = New System.Drawing.Point(886, 9)
        Me.lblScorePanel.Name = "lblScorePanel"
        Me.lblScorePanel.Size = New System.Drawing.Size(169, 31)
        Me.lblScorePanel.TabIndex = 1
        Me.lblScorePanel.Text = "Score Panel:"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(892, 104)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(78, 24)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblMoneyAmount1
        '
        Me.lblMoneyAmount1.BackColor = System.Drawing.Color.White
        Me.lblMoneyAmount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoneyAmount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneyAmount1.Location = New System.Drawing.Point(959, 161)
        Me.lblMoneyAmount1.Name = "lblMoneyAmount1"
        Me.lblMoneyAmount1.Size = New System.Drawing.Size(53, 20)
        Me.lblMoneyAmount1.TabIndex = 3
        '
        'lblMoney1
        '
        Me.lblMoney1.AutoSize = True
        Me.lblMoney1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney1.Location = New System.Drawing.Point(892, 161)
        Me.lblMoney1.Name = "lblMoney1"
        Me.lblMoney1.Size = New System.Drawing.Size(60, 20)
        Me.lblMoney1.TabIndex = 4
        Me.lblMoney1.Text = "Money:"
        '
        'picPlayer1Color
        '
        Me.picPlayer1Color.BackColor = System.Drawing.Color.White
        Me.picPlayer1Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1Color.Location = New System.Drawing.Point(1095, 104)
        Me.picPlayer1Color.Name = "picPlayer1Color"
        Me.picPlayer1Color.Size = New System.Drawing.Size(49, 24)
        Me.picPlayer1Color.TabIndex = 8
        Me.picPlayer1Color.TabStop = False
        '
        'lblProps1
        '
        Me.lblProps1.AutoSize = True
        Me.lblProps1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProps1.Location = New System.Drawing.Point(892, 232)
        Me.lblProps1.Name = "lblProps1"
        Me.lblProps1.Size = New System.Drawing.Size(139, 20)
        Me.lblProps1.TabIndex = 9
        Me.lblProps1.Text = "Properties Owned:"
        '
        'cmbProperties1
        '
        Me.cmbProperties1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProperties1.FormattingEnabled = True
        Me.cmbProperties1.Location = New System.Drawing.Point(896, 255)
        Me.cmbProperties1.Name = "cmbProperties1"
        Me.cmbProperties1.Size = New System.Drawing.Size(137, 21)
        Me.cmbProperties1.TabIndex = 10
        '
        'cmbProperties2
        '
        Me.cmbProperties2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProperties2.FormattingEnabled = True
        Me.cmbProperties2.Location = New System.Drawing.Point(892, 544)
        Me.cmbProperties2.Name = "cmbProperties2"
        Me.cmbProperties2.Size = New System.Drawing.Size(137, 21)
        Me.cmbProperties2.TabIndex = 16
        '
        'lblProps2
        '
        Me.lblProps2.AutoSize = True
        Me.lblProps2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProps2.Location = New System.Drawing.Point(888, 521)
        Me.lblProps2.Name = "lblProps2"
        Me.lblProps2.Size = New System.Drawing.Size(139, 20)
        Me.lblProps2.TabIndex = 15
        Me.lblProps2.Text = "Properties Owned:"
        '
        'picPlayer2Color
        '
        Me.picPlayer2Color.BackColor = System.Drawing.Color.White
        Me.picPlayer2Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2Color.Location = New System.Drawing.Point(1095, 400)
        Me.picPlayer2Color.Name = "picPlayer2Color"
        Me.picPlayer2Color.Size = New System.Drawing.Size(49, 24)
        Me.picPlayer2Color.TabIndex = 14
        Me.picPlayer2Color.TabStop = False
        '
        'lblMoney2
        '
        Me.lblMoney2.AutoSize = True
        Me.lblMoney2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney2.Location = New System.Drawing.Point(888, 457)
        Me.lblMoney2.Name = "lblMoney2"
        Me.lblMoney2.Size = New System.Drawing.Size(60, 20)
        Me.lblMoney2.TabIndex = 13
        Me.lblMoney2.Text = "Money:"
        '
        'lblMoneyAmount2
        '
        Me.lblMoneyAmount2.BackColor = System.Drawing.Color.White
        Me.lblMoneyAmount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoneyAmount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneyAmount2.Location = New System.Drawing.Point(959, 457)
        Me.lblMoneyAmount2.Name = "lblMoneyAmount2"
        Me.lblMoneyAmount2.Size = New System.Drawing.Size(53, 20)
        Me.lblMoneyAmount2.TabIndex = 12
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(888, 400)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(77, 24)
        Me.lblPlayer2.TabIndex = 11
        Me.lblPlayer2.Text = "Player 2"
        '
        'btnSell1
        '
        Me.btnSell1.Location = New System.Drawing.Point(896, 297)
        Me.btnSell1.Name = "btnSell1"
        Me.btnSell1.Size = New System.Drawing.Size(52, 23)
        Me.btnSell1.TabIndex = 17
        Me.btnSell1.Text = "Sell"
        Me.btnSell1.UseVisualStyleBackColor = True
        '
        'btnTrade1
        '
        Me.btnTrade1.Location = New System.Drawing.Point(977, 297)
        Me.btnTrade1.Name = "btnTrade1"
        Me.btnTrade1.Size = New System.Drawing.Size(56, 23)
        Me.btnTrade1.TabIndex = 18
        Me.btnTrade1.Text = "Trade"
        Me.btnTrade1.UseVisualStyleBackColor = True
        '
        'btnTrade2
        '
        Me.btnTrade2.Location = New System.Drawing.Point(973, 585)
        Me.btnTrade2.Name = "btnTrade2"
        Me.btnTrade2.Size = New System.Drawing.Size(56, 23)
        Me.btnTrade2.TabIndex = 20
        Me.btnTrade2.Text = "Trade"
        Me.btnTrade2.UseVisualStyleBackColor = True
        '
        'btnSell2
        '
        Me.btnSell2.Location = New System.Drawing.Point(892, 585)
        Me.btnSell2.Name = "btnSell2"
        Me.btnSell2.Size = New System.Drawing.Size(56, 23)
        Me.btnSell2.TabIndex = 19
        Me.btnSell2.Text = "Sell"
        Me.btnSell2.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(892, 808)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(108, 37)
        Me.btnBuy.TabIndex = 21
        Me.btnBuy.Text = "Buy this Property"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1156, 822)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 857)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnTrade2)
        Me.Controls.Add(Me.btnSell2)
        Me.Controls.Add(Me.btnTrade1)
        Me.Controls.Add(Me.btnSell1)
        Me.Controls.Add(Me.cmbProperties2)
        Me.Controls.Add(Me.lblProps2)
        Me.Controls.Add(Me.picPlayer2Color)
        Me.Controls.Add(Me.lblMoney2)
        Me.Controls.Add(Me.lblMoneyAmount2)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.cmbProperties1)
        Me.Controls.Add(Me.lblProps1)
        Me.Controls.Add(Me.picPlayer1Color)
        Me.Controls.Add(Me.lblMoney1)
        Me.Controls.Add(Me.lblMoneyAmount1)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lblScorePanel)
        Me.Controls.Add(Me.picBoard)
        Me.MinimumSize = New System.Drawing.Size(1115, 710)
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONOPOLY"
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBoard As System.Windows.Forms.PictureBox
    Friend WithEvents lblScorePanel As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblMoneyAmount1 As System.Windows.Forms.Label
    Friend WithEvents lblMoney1 As System.Windows.Forms.Label
    Friend WithEvents picPlayer1Color As System.Windows.Forms.PictureBox
    Friend WithEvents lblProps1 As System.Windows.Forms.Label
    Friend WithEvents cmbProperties1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProperties2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblProps2 As System.Windows.Forms.Label
    Friend WithEvents picPlayer2Color As System.Windows.Forms.PictureBox
    Friend WithEvents lblMoney2 As System.Windows.Forms.Label
    Friend WithEvents lblMoneyAmount2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents btnSell1 As System.Windows.Forms.Button
    Friend WithEvents btnTrade1 As System.Windows.Forms.Button
    Friend WithEvents btnTrade2 As System.Windows.Forms.Button
    Friend WithEvents btnSell2 As System.Windows.Forms.Button
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
