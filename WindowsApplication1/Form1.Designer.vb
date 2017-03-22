<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dlgFile = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.lbPlaylist = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAddCommercial = New System.Windows.Forms.Button()
        Me.lbCommercial = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.slTime = New System.Windows.Forms.TrackBar()
        Me.trkVolume = New System.Windows.Forms.TrackBar()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.slTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgFile
        '
        Me.dlgFile.FileName = "OpenFileDialog1"
        Me.dlgFile.Multiselect = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btnAddFile)
        Me.TabPage1.Controls.Add(Me.lbPlaylist)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(536, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Плейліст"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Вилучити файл"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(6, 330)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(134, 23)
        Me.btnAddFile.TabIndex = 3
        Me.btnAddFile.Text = "Додати файл"
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'lbPlaylist
        '
        Me.lbPlaylist.FormattingEnabled = True
        Me.lbPlaylist.Location = New System.Drawing.Point(6, 6)
        Me.lbPlaylist.Name = "lbPlaylist"
        Me.lbPlaylist.Size = New System.Drawing.Size(523, 316)
        Me.lbPlaylist.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 112)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 385)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.btnAddCommercial)
        Me.TabPage2.Controls.Add(Me.lbCommercial)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(536, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Реклама"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(153, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Вилучити файл"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnAddCommercial
        '
        Me.btnAddCommercial.Location = New System.Drawing.Point(13, 328)
        Me.btnAddCommercial.Name = "btnAddCommercial"
        Me.btnAddCommercial.Size = New System.Drawing.Size(134, 23)
        Me.btnAddCommercial.TabIndex = 6
        Me.btnAddCommercial.Text = "Додати файл"
        Me.btnAddCommercial.UseVisualStyleBackColor = True
        '
        'lbCommercial
        '
        Me.lbCommercial.FormattingEnabled = True
        Me.lbCommercial.Location = New System.Drawing.Point(13, 31)
        Me.lbCommercial.Name = "lbCommercial"
        Me.lbCommercial.Size = New System.Drawing.Size(508, 290)
        Me.lbCommercial.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox1.Location = New System.Drawing.Point(167, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(54, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Програвати рекламу кожний"
        '
        'slTime
        '
        Me.slTime.Location = New System.Drawing.Point(5, 27)
        Me.slTime.Name = "slTime"
        Me.slTime.Size = New System.Drawing.Size(531, 45)
        Me.slTime.TabIndex = 0
        Me.slTime.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'trkVolume
        '
        Me.trkVolume.Location = New System.Drawing.Point(399, 49)
        Me.trkVolume.Maximum = 100
        Me.trkVolume.Name = "trkVolume"
        Me.trkVolume.Size = New System.Drawing.Size(135, 45)
        Me.trkVolume.TabIndex = 1
        Me.trkVolume.TickFrequency = 10
        Me.trkVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trkVolume.Value = 100
        '
        'btnPlay
        '
        Me.btnPlay.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.player_play_5746
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Location = New System.Drawing.Point(11, 49)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(32, 32)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = " "
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.player_stop_9016
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(87, 49)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(32, 32)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = " "
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTime.Location = New System.Drawing.Point(69, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(58, 16)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "00:00:00"
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPos.Location = New System.Drawing.Point(9, 0)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(58, 16)
        Me.lblPos.TabIndex = 5
        Me.lblPos.Text = "00:00:00"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 19)
        Me.ProgressBar1.MarqueeAnimationSpeed = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(515, 10)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.player_pause_8310
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(49, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = " "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.lblPos)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnPlay)
        Me.Panel1.Controls.Add(Me.trkVolume)
        Me.Panel1.Controls.Add(Me.slTime)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Програвач"
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.slTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlgFile As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAddFile As Button
    Friend WithEvents lbPlaylist As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents slTime As TrackBar
    Friend WithEvents trkVolume As TrackBar
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblPos As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAddCommercial As Button
    Friend WithEvents lbCommercial As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
