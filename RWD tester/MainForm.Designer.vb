'
' Created by SharpDevelop.
' User: Sergey
' Date: 26.01.2020
' Time: 16:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.label18 = New System.Windows.Forms.Label()
		Me.label17 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.button12 = New System.Windows.Forms.Button()
		Me.label9 = New System.Windows.Forms.Label()
		Me.button13 = New System.Windows.Forms.Button()
		Me.button14 = New System.Windows.Forms.Button()
		Me.label10 = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.vScrollBar3 = New System.Windows.Forms.VScrollBar()
		Me.button11 = New System.Windows.Forms.Button()
		Me.label8 = New System.Windows.Forms.Label()
		Me.textBox9 = New System.Windows.Forms.TextBox()
		Me.vScrollBar2 = New System.Windows.Forms.VScrollBar()
		Me.button10 = New System.Windows.Forms.Button()
		Me.textBox8 = New System.Windows.Forms.TextBox()
		Me.vScrollBar1 = New System.Windows.Forms.VScrollBar()
		Me.button9 = New System.Windows.Forms.Button()
		Me.label7 = New System.Windows.Forms.Label()
		Me.textBox7 = New System.Windows.Forms.TextBox()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.groupBox6 = New System.Windows.Forms.GroupBox()
		Me.button21 = New System.Windows.Forms.Button()
		Me.button19 = New System.Windows.Forms.Button()
		Me.button20 = New System.Windows.Forms.Button()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me.button22 = New System.Windows.Forms.Button()
		Me.button17 = New System.Windows.Forms.Button()
		Me.button18 = New System.Windows.Forms.Button()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.button16 = New System.Windows.Forms.Button()
		Me.button15 = New System.Windows.Forms.Button()
		Me.label19 = New System.Windows.Forms.Label()
		Me.tabPage3 = New System.Windows.Forms.TabPage()
		Me.groupBox8 = New System.Windows.Forms.GroupBox()
		Me.label24 = New System.Windows.Forms.Label()
		Me.button25 = New System.Windows.Forms.Button()
		Me.button24 = New System.Windows.Forms.Button()
		Me.comboBox3 = New System.Windows.Forms.ComboBox()
		Me.button23 = New System.Windows.Forms.Button()
		Me.comboBox4 = New System.Windows.Forms.ComboBox()
		Me.label23 = New System.Windows.Forms.Label()
		Me.label22 = New System.Windows.Forms.Label()
		Me.label21 = New System.Windows.Forms.Label()
		Me.comboBox2 = New System.Windows.Forms.ComboBox()
		Me.groupBox7 = New System.Windows.Forms.GroupBox()
		Me.label20 = New System.Windows.Forms.Label()
		Me.tabPage4 = New System.Windows.Forms.TabPage()
		Me.groupBox9 = New System.Windows.Forms.GroupBox()
		Me.button33 = New System.Windows.Forms.Button()
		Me.button32 = New System.Windows.Forms.Button()
		Me.button31 = New System.Windows.Forms.Button()
		Me.button30 = New System.Windows.Forms.Button()
		Me.button29 = New System.Windows.Forms.Button()
		Me.button28 = New System.Windows.Forms.Button()
		Me.button27 = New System.Windows.Forms.Button()
		Me.button26 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.checkBox1 = New System.Windows.Forms.CheckBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.button2 = New System.Windows.Forms.Button()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.checkBox2 = New System.Windows.Forms.CheckBox()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.button5 = New System.Windows.Forms.Button()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.button6 = New System.Windows.Forms.Button()
		Me.listBox1 = New System.Windows.Forms.ListBox()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.checkBox3 = New System.Windows.Forms.CheckBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.checkBox4 = New System.Windows.Forms.CheckBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.listBox2 = New System.Windows.Forms.ListBox()
		Me.listBox3 = New System.Windows.Forms.ListBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.button7 = New System.Windows.Forms.Button()
		Me.label6 = New System.Windows.Forms.Label()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.checkBox5 = New System.Windows.Forms.CheckBox()
		Me.button8 = New System.Windows.Forms.Button()
		Me.button34 = New System.Windows.Forms.Button()
		Me.button35 = New System.Windows.Forms.Button()
		Me.button36 = New System.Windows.Forms.Button()
		Me.button37 = New System.Windows.Forms.Button()
		Me.button38 = New System.Windows.Forms.Button()
		Me.button39 = New System.Windows.Forms.Button()
		Me.button40 = New System.Windows.Forms.Button()
		Me.button41 = New System.Windows.Forms.Button()
		Me.serialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.button42 = New System.Windows.Forms.Button()
		Me.tabControl1.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox1.SuspendLayout
		Me.tabPage2.SuspendLayout
		Me.groupBox6.SuspendLayout
		Me.groupBox5.SuspendLayout
		Me.groupBox4.SuspendLayout
		Me.tabPage3.SuspendLayout
		Me.groupBox8.SuspendLayout
		Me.groupBox7.SuspendLayout
		Me.tabPage4.SuspendLayout
		Me.groupBox9.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'tabControl1
		'
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage2)
		Me.tabControl1.Controls.Add(Me.tabPage3)
		Me.tabControl1.Controls.Add(Me.tabPage4)
		Me.tabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.tabControl1.Location = New System.Drawing.Point(272, 39)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.Padding = New System.Drawing.Point(3, 3)
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(682, 325)
		Me.tabControl1.TabIndex = 0
		'
		'tabPage1
		'
		Me.tabPage1.BackColor = System.Drawing.Color.Transparent
		Me.tabPage1.Controls.Add(Me.groupBox3)
		Me.tabPage1.Controls.Add(Me.groupBox2)
		Me.tabPage1.Controls.Add(Me.groupBox1)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(674, 299)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Стрелка"
		'
		'groupBox3
		'
		Me.groupBox3.BackColor = System.Drawing.Color.Transparent
		Me.groupBox3.Controls.Add(Me.label18)
		Me.groupBox3.Controls.Add(Me.label17)
		Me.groupBox3.Controls.Add(Me.label15)
		Me.groupBox3.Controls.Add(Me.label16)
		Me.groupBox3.Controls.Add(Me.label14)
		Me.groupBox3.Controls.Add(Me.label13)
		Me.groupBox3.Controls.Add(Me.label11)
		Me.groupBox3.Controls.Add(Me.label12)
		Me.groupBox3.Location = New System.Drawing.Point(330, 6)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(336, 287)
		Me.groupBox3.TabIndex = 53
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "СОСТОЯНИЕ"
		'
		'label18
		'
		Me.label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label18.Location = New System.Drawing.Point(20, 39)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(142, 19)
		Me.label18.TabIndex = 50
		Me.label18.Text = "Направление"
		'
		'label17
		'
		Me.label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label17.Location = New System.Drawing.Point(20, 117)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(142, 19)
		Me.label17.TabIndex = 49
		Me.label17.Text = "Датчик положения"
		'
		'label15
		'
		Me.label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label15.ForeColor = System.Drawing.Color.White
		Me.label15.Location = New System.Drawing.Point(174, 178)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(155, 19)
		Me.label15.TabIndex = 48
		Me.label15.Text = "ОБРЫВ по МИНУСУ"
		'
		'label16
		'
		Me.label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label16.ForeColor = System.Drawing.Color.White
		Me.label16.Location = New System.Drawing.Point(20, 178)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(131, 19)
		Me.label16.TabIndex = 47
		Me.label16.Text = "КЗ по МИНУСУ"
		'
		'label14
		'
		Me.label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label14.ForeColor = System.Drawing.Color.White
		Me.label14.Location = New System.Drawing.Point(174, 61)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(131, 19)
		Me.label14.TabIndex = 46
		Me.label14.Text = "По МИНУСУ"
		'
		'label13
		'
		Me.label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label13.ForeColor = System.Drawing.Color.White
		Me.label13.Location = New System.Drawing.Point(174, 139)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(155, 19)
		Me.label13.TabIndex = 45
		Me.label13.Text = "ОБРЫВ по ПЛЮСУ"
		'
		'label11
		'
		Me.label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label11.ForeColor = System.Drawing.Color.White
		Me.label11.Location = New System.Drawing.Point(20, 139)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(131, 19)
		Me.label11.TabIndex = 44
		Me.label11.Text = "КЗ по ПЛЮСУ"
		'
		'label12
		'
		Me.label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label12.ForeColor = System.Drawing.Color.Red
		Me.label12.Location = New System.Drawing.Point(20, 61)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(131, 19)
		Me.label12.TabIndex = 43
		Me.label12.Text = "По ПЛЮСУ"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.button12)
		Me.groupBox2.Controls.Add(Me.label9)
		Me.groupBox2.Controls.Add(Me.button13)
		Me.groupBox2.Controls.Add(Me.button14)
		Me.groupBox2.Controls.Add(Me.label10)
		Me.groupBox2.Location = New System.Drawing.Point(208, 6)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(115, 287)
		Me.groupBox2.TabIndex = 45
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "УПРАВЛЕНИЕ"
		'
		'button12
		'
		Me.button12.Location = New System.Drawing.Point(15, 59)
		Me.button12.Name = "button12"
		Me.button12.Size = New System.Drawing.Size(87, 23)
		Me.button12.TabIndex = 51
		Me.button12.Text = "Запрос"
		Me.button12.UseVisualStyleBackColor = true
		'
		'label9
		'
		Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label9.Location = New System.Drawing.Point(15, 39)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(94, 19)
		Me.label9.TabIndex = 49
		Me.label9.Text = "Состояние"
		'
		'button13
		'
		Me.button13.Location = New System.Drawing.Point(14, 176)
		Me.button13.Name = "button13"
		Me.button13.Size = New System.Drawing.Size(87, 23)
		Me.button13.TabIndex = 47
		Me.button13.Text = "По минусу"
		Me.button13.UseVisualStyleBackColor = true
		'
		'button14
		'
		Me.button14.Location = New System.Drawing.Point(14, 137)
		Me.button14.Name = "button14"
		Me.button14.Size = New System.Drawing.Size(87, 23)
		Me.button14.TabIndex = 43
		Me.button14.Text = "По плюсу"
		Me.button14.UseVisualStyleBackColor = true
		'
		'label10
		'
		Me.label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label10.Location = New System.Drawing.Point(14, 117)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(94, 19)
		Me.label10.TabIndex = 43
		Me.label10.Text = "Перевести"
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.vScrollBar3)
		Me.groupBox1.Controls.Add(Me.button11)
		Me.groupBox1.Controls.Add(Me.label8)
		Me.groupBox1.Controls.Add(Me.textBox9)
		Me.groupBox1.Controls.Add(Me.vScrollBar2)
		Me.groupBox1.Controls.Add(Me.button10)
		Me.groupBox1.Controls.Add(Me.textBox8)
		Me.groupBox1.Controls.Add(Me.vScrollBar1)
		Me.groupBox1.Controls.Add(Me.button9)
		Me.groupBox1.Controls.Add(Me.label7)
		Me.groupBox1.Controls.Add(Me.textBox7)
		Me.groupBox1.Location = New System.Drawing.Point(7, 6)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(194, 287)
		Me.groupBox1.TabIndex = 44
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "НАСТРОЙКА"
		'
		'vScrollBar3
		'
		Me.vScrollBar3.Location = New System.Drawing.Point(66, 58)
		Me.vScrollBar3.Name = "vScrollBar3"
		Me.vScrollBar3.Size = New System.Drawing.Size(20, 24)
		Me.vScrollBar3.TabIndex = 52
		'
		'button11
		'
		Me.button11.Location = New System.Drawing.Point(93, 59)
		Me.button11.Name = "button11"
		Me.button11.Size = New System.Drawing.Size(87, 23)
		Me.button11.TabIndex = 51
		Me.button11.Text = "Установить"
		Me.button11.UseVisualStyleBackColor = true
		'
		'label8
		'
		Me.label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label8.Location = New System.Drawing.Point(16, 39)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(161, 19)
		Me.label8.TabIndex = 49
		Me.label8.Text = "Скорость перевода"
		'
		'textBox9
		'
		Me.textBox9.Location = New System.Drawing.Point(16, 61)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(46, 21)
		Me.textBox9.TabIndex = 50
		Me.textBox9.Text = "200"
		Me.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'vScrollBar2
		'
		Me.vScrollBar2.Location = New System.Drawing.Point(66, 175)
		Me.vScrollBar2.Name = "vScrollBar2"
		Me.vScrollBar2.Size = New System.Drawing.Size(20, 24)
		Me.vScrollBar2.TabIndex = 48
		'
		'button10
		'
		Me.button10.Location = New System.Drawing.Point(93, 176)
		Me.button10.Name = "button10"
		Me.button10.Size = New System.Drawing.Size(87, 23)
		Me.button10.TabIndex = 47
		Me.button10.Text = "По минусу"
		Me.button10.UseVisualStyleBackColor = true
		'
		'textBox8
		'
		Me.textBox8.Location = New System.Drawing.Point(16, 178)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.Size = New System.Drawing.Size(46, 21)
		Me.textBox8.TabIndex = 46
		Me.textBox8.Text = "200"
		Me.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'vScrollBar1
		'
		Me.vScrollBar1.Location = New System.Drawing.Point(66, 136)
		Me.vScrollBar1.Name = "vScrollBar1"
		Me.vScrollBar1.Size = New System.Drawing.Size(20, 24)
		Me.vScrollBar1.TabIndex = 45
		'
		'button9
		'
		Me.button9.Location = New System.Drawing.Point(93, 137)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(87, 23)
		Me.button9.TabIndex = 43
		Me.button9.Text = "По плюсу"
		Me.button9.UseVisualStyleBackColor = true
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label7.Location = New System.Drawing.Point(16, 117)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(161, 19)
		Me.label7.TabIndex = 43
		Me.label7.Text = "Глубина отклонения"
		'
		'textBox7
		'
		Me.textBox7.Location = New System.Drawing.Point(16, 139)
		Me.textBox7.Name = "textBox7"
		Me.textBox7.Size = New System.Drawing.Size(46, 21)
		Me.textBox7.TabIndex = 43
		Me.textBox7.Text = "180"
		Me.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tabPage2
		'
		Me.tabPage2.BackColor = System.Drawing.Color.Transparent
		Me.tabPage2.Controls.Add(Me.groupBox6)
		Me.tabPage2.Controls.Add(Me.groupBox5)
		Me.tabPage2.Controls.Add(Me.groupBox4)
		Me.tabPage2.Controls.Add(Me.label19)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(674, 299)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Светофор РЕЖИМ"
		'
		'groupBox6
		'
		Me.groupBox6.Controls.Add(Me.button21)
		Me.groupBox6.Controls.Add(Me.button19)
		Me.groupBox6.Controls.Add(Me.button20)
		Me.groupBox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.groupBox6.Location = New System.Drawing.Point(453, 48)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(213, 245)
		Me.groupBox6.TabIndex = 55
		Me.groupBox6.TabStop = false
		Me.groupBox6.Text = "ПРОВЕРКА"
		'
		'button21
		'
		Me.button21.Location = New System.Drawing.Point(9, 185)
		Me.button21.Name = "button21"
		Me.button21.Size = New System.Drawing.Size(187, 23)
		Me.button21.TabIndex = 54
		Me.button21.Text = "ЗАПРОС СОСТОЯНИЯ"
		Me.button21.UseVisualStyleBackColor = true
		'
		'button19
		'
		Me.button19.Location = New System.Drawing.Point(9, 111)
		Me.button19.Name = "button19"
		Me.button19.Size = New System.Drawing.Size(187, 23)
		Me.button19.TabIndex = 53
		Me.button19.Text = "ВСЕ СИГНАЛЫ"
		Me.button19.UseVisualStyleBackColor = true
		'
		'button20
		'
		Me.button20.Location = New System.Drawing.Point(7, 39)
		Me.button20.Name = "button20"
		Me.button20.Size = New System.Drawing.Size(187, 23)
		Me.button20.TabIndex = 52
		Me.button20.Text = "ВЫХОД = ВХОДУ"
		Me.button20.UseVisualStyleBackColor = true
		'
		'groupBox5
		'
		Me.groupBox5.Controls.Add(Me.button22)
		Me.groupBox5.Controls.Add(Me.button17)
		Me.groupBox5.Controls.Add(Me.button18)
		Me.groupBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.groupBox5.Location = New System.Drawing.Point(229, 48)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(213, 245)
		Me.groupBox5.TabIndex = 54
		Me.groupBox5.TabStop = false
		Me.groupBox5.Text = "СВЕТОФОРОМ"
		'
		'button22
		'
		Me.button22.Location = New System.Drawing.Point(7, 185)
		Me.button22.Name = "button22"
		Me.button22.Size = New System.Drawing.Size(187, 23)
		Me.button22.TabIndex = 54
		Me.button22.Text = "ДВА СВЕТОФОРА"
		Me.button22.UseVisualStyleBackColor = true
		'
		'button17
		'
		Me.button17.Location = New System.Drawing.Point(9, 111)
		Me.button17.Name = "button17"
		Me.button17.Size = New System.Drawing.Size(187, 23)
		Me.button17.TabIndex = 53
		Me.button17.Text = "СВЕТОФОР по ПЛЮСУ"
		Me.button17.UseVisualStyleBackColor = true
		'
		'button18
		'
		Me.button18.Location = New System.Drawing.Point(7, 39)
		Me.button18.Name = "button18"
		Me.button18.Size = New System.Drawing.Size(187, 23)
		Me.button18.TabIndex = 52
		Me.button18.Text = "СВЕТОФОР по МИНУСУ"
		Me.button18.UseVisualStyleBackColor = true
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.button16)
		Me.groupBox4.Controls.Add(Me.button15)
		Me.groupBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.groupBox4.Location = New System.Drawing.Point(7, 48)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(213, 245)
		Me.groupBox4.TabIndex = 3
		Me.groupBox4.TabStop = false
		Me.groupBox4.Text = "СТРЕЛКОЙ"
		'
		'button16
		'
		Me.button16.Location = New System.Drawing.Point(13, 111)
		Me.button16.Name = "button16"
		Me.button16.Size = New System.Drawing.Size(187, 23)
		Me.button16.TabIndex = 53
		Me.button16.Text = "ЗЕЛЕНЫЙ по ПЛЮСУ"
		Me.button16.UseVisualStyleBackColor = true
		'
		'button15
		'
		Me.button15.Location = New System.Drawing.Point(7, 39)
		Me.button15.Name = "button15"
		Me.button15.Size = New System.Drawing.Size(187, 23)
		Me.button15.TabIndex = 52
		Me.button15.Text = "КРАСНЫЙ по ПЛЮСУ"
		Me.button15.UseVisualStyleBackColor = true
		'
		'label19
		'
		Me.label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label19.Location = New System.Drawing.Point(7, 16)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(178, 19)
		Me.label19.TabIndex = 2
		Me.label19.Text = "Светофор управляется:"
		'
		'tabPage3
		'
		Me.tabPage3.BackColor = System.Drawing.Color.Transparent
		Me.tabPage3.Controls.Add(Me.groupBox8)
		Me.tabPage3.Controls.Add(Me.groupBox7)
		Me.tabPage3.Location = New System.Drawing.Point(4, 22)
		Me.tabPage3.Name = "tabPage3"
		Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage3.Size = New System.Drawing.Size(674, 299)
		Me.tabPage3.TabIndex = 2
		Me.tabPage3.Text = "Светофор ПРОГРАММИРОВАНИЕ"
		'
		'groupBox8
		'
		Me.groupBox8.Controls.Add(Me.label24)
		Me.groupBox8.Controls.Add(Me.button25)
		Me.groupBox8.Controls.Add(Me.button24)
		Me.groupBox8.Controls.Add(Me.comboBox3)
		Me.groupBox8.Controls.Add(Me.button23)
		Me.groupBox8.Controls.Add(Me.comboBox4)
		Me.groupBox8.Controls.Add(Me.label23)
		Me.groupBox8.Controls.Add(Me.label22)
		Me.groupBox8.Controls.Add(Me.label21)
		Me.groupBox8.Controls.Add(Me.comboBox2)
		Me.groupBox8.Location = New System.Drawing.Point(355, 17)
		Me.groupBox8.Name = "groupBox8"
		Me.groupBox8.Size = New System.Drawing.Size(278, 264)
		Me.groupBox8.TabIndex = 4
		Me.groupBox8.TabStop = false
		Me.groupBox8.Text = "НОМЕР КОМБИНАЦИИ"
		'
		'label24
		'
		Me.label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label24.Location = New System.Drawing.Point(49, 161)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(121, 19)
		Me.label24.TabIndex = 50
		Me.label24.Text = "Показать"
		'
		'button25
		'
		Me.button25.Location = New System.Drawing.Point(49, 212)
		Me.button25.Name = "button25"
		Me.button25.Size = New System.Drawing.Size(177, 23)
		Me.button25.TabIndex = 49
		Me.button25.Text = "Регистры светофоров"
		Me.button25.UseVisualStyleBackColor = true
		'
		'button24
		'
		Me.button24.Location = New System.Drawing.Point(49, 183)
		Me.button24.Name = "button24"
		Me.button24.Size = New System.Drawing.Size(177, 23)
		Me.button24.TabIndex = 48
		Me.button24.Text = "Таблица сигналов"
		Me.button24.UseVisualStyleBackColor = true
		'
		'comboBox3
		'
		Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox3.FormattingEnabled = true
		Me.comboBox3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
		Me.comboBox3.Location = New System.Drawing.Point(49, 69)
		Me.comboBox3.Name = "comboBox3"
		Me.comboBox3.Size = New System.Drawing.Size(80, 21)
		Me.comboBox3.TabIndex = 47
		'
		'button23
		'
		Me.button23.Location = New System.Drawing.Point(49, 109)
		Me.button23.Name = "button23"
		Me.button23.Size = New System.Drawing.Size(177, 23)
		Me.button23.TabIndex = 46
		Me.button23.Text = "Сохранить"
		Me.button23.UseVisualStyleBackColor = true
		'
		'comboBox4
		'
		Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox4.FormattingEnabled = true
		Me.comboBox4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
		Me.comboBox4.Location = New System.Drawing.Point(146, 69)
		Me.comboBox4.Name = "comboBox4"
		Me.comboBox4.Size = New System.Drawing.Size(80, 21)
		Me.comboBox4.TabIndex = 45
		'
		'label23
		'
		Me.label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label23.Location = New System.Drawing.Point(146, 93)
		Me.label23.Name = "label23"
		Me.label23.Size = New System.Drawing.Size(93, 19)
		Me.label23.TabIndex = 43
		Me.label23.Text = "на ВЫХОДЕ"
		'
		'label22
		'
		Me.label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label22.Location = New System.Drawing.Point(47, 93)
		Me.label22.Name = "label22"
		Me.label22.Size = New System.Drawing.Size(92, 19)
		Me.label22.TabIndex = 42
		Me.label22.Text = "на ВХОДЕ"
		'
		'label21
		'
		Me.label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label21.Location = New System.Drawing.Point(49, 23)
		Me.label21.Name = "label21"
		Me.label21.Size = New System.Drawing.Size(121, 19)
		Me.label21.TabIndex = 39
		Me.label21.Text = "Направление"
		'
		'comboBox2
		'
		Me.comboBox2.FormattingEnabled = true
		Me.comboBox2.Location = New System.Drawing.Point(49, 45)
		Me.comboBox2.Name = "comboBox2"
		Me.comboBox2.Size = New System.Drawing.Size(177, 21)
		Me.comboBox2.TabIndex = 38
		Me.comboBox2.Text = "по ПЛЮСУ"
		'
		'groupBox7
		'
		Me.groupBox7.Controls.Add(Me.label20)
		Me.groupBox7.Location = New System.Drawing.Point(40, 17)
		Me.groupBox7.Name = "groupBox7"
		Me.groupBox7.Size = New System.Drawing.Size(278, 264)
		Me.groupBox7.TabIndex = 3
		Me.groupBox7.TabStop = false
		Me.groupBox7.Text = "НОМЕР КОМБИНАЦИИ"
		'
		'label20
		'
		Me.label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label20.Location = New System.Drawing.Point(28, 31)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(212, 218)
		Me.label20.TabIndex = 3
		Me.label20.Text = resources.GetString("label20.Text")
		'
		'tabPage4
		'
		Me.tabPage4.BackColor = System.Drawing.Color.Transparent
		Me.tabPage4.Controls.Add(Me.groupBox9)
		Me.tabPage4.Location = New System.Drawing.Point(4, 22)
		Me.tabPage4.Name = "tabPage4"
		Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage4.Size = New System.Drawing.Size(674, 299)
		Me.tabPage4.TabIndex = 3
		Me.tabPage4.Text = "Светофор УПРАВЛЕНИЕ"
		'
		'groupBox9
		'
		Me.groupBox9.Controls.Add(Me.button34)
		Me.groupBox9.Controls.Add(Me.button35)
		Me.groupBox9.Controls.Add(Me.button36)
		Me.groupBox9.Controls.Add(Me.button37)
		Me.groupBox9.Controls.Add(Me.button38)
		Me.groupBox9.Controls.Add(Me.button39)
		Me.groupBox9.Controls.Add(Me.button40)
		Me.groupBox9.Controls.Add(Me.button41)
		Me.groupBox9.Controls.Add(Me.button33)
		Me.groupBox9.Controls.Add(Me.button32)
		Me.groupBox9.Controls.Add(Me.button31)
		Me.groupBox9.Controls.Add(Me.button30)
		Me.groupBox9.Controls.Add(Me.button29)
		Me.groupBox9.Controls.Add(Me.button28)
		Me.groupBox9.Controls.Add(Me.button27)
		Me.groupBox9.Controls.Add(Me.button26)
		Me.groupBox9.Location = New System.Drawing.Point(19, 17)
		Me.groupBox9.Name = "groupBox9"
		Me.groupBox9.Size = New System.Drawing.Size(629, 264)
		Me.groupBox9.TabIndex = 4
		Me.groupBox9.TabStop = false
		Me.groupBox9.Text = "ВКЛЮЧИТЬ СИГНАЛ"
		'
		'button33
		'
		Me.button33.Location = New System.Drawing.Point(61, 222)
		Me.button33.Name = "button33"
		Me.button33.Size = New System.Drawing.Size(233, 23)
		Me.button33.TabIndex = 10
		Me.button33.Text = "в.желтый + зеленый *"
		Me.button33.UseVisualStyleBackColor = true
		'
		'button32
		'
		Me.button32.Location = New System.Drawing.Point(61, 193)
		Me.button32.Name = "button32"
		Me.button32.Size = New System.Drawing.Size(233, 23)
		Me.button32.TabIndex = 9
		Me.button32.Text = "зеленый *"
		Me.button32.UseVisualStyleBackColor = true
		'
		'button31
		'
		Me.button31.Location = New System.Drawing.Point(61, 164)
		Me.button31.Name = "button31"
		Me.button31.Size = New System.Drawing.Size(233, 23)
		Me.button31.TabIndex = 8
		Me.button31.Text = "в.желтый *"
		Me.button31.UseVisualStyleBackColor = true
		'
		'button30
		'
		Me.button30.Location = New System.Drawing.Point(61, 135)
		Me.button30.Name = "button30"
		Me.button30.Size = New System.Drawing.Size(233, 23)
		Me.button30.TabIndex = 7
		Me.button30.Text = "красный"
		Me.button30.UseVisualStyleBackColor = true
		'
		'button29
		'
		Me.button29.Location = New System.Drawing.Point(61, 106)
		Me.button29.Name = "button29"
		Me.button29.Size = New System.Drawing.Size(233, 23)
		Me.button29.TabIndex = 6
		Me.button29.Text = "в.желтый + зеленый"
		Me.button29.UseVisualStyleBackColor = true
		'
		'button28
		'
		Me.button28.Location = New System.Drawing.Point(61, 77)
		Me.button28.Name = "button28"
		Me.button28.Size = New System.Drawing.Size(233, 23)
		Me.button28.TabIndex = 5
		Me.button28.Text = "зеленый"
		Me.button28.UseVisualStyleBackColor = true
		'
		'button27
		'
		Me.button27.Location = New System.Drawing.Point(61, 48)
		Me.button27.Name = "button27"
		Me.button27.Size = New System.Drawing.Size(233, 23)
		Me.button27.TabIndex = 4
		Me.button27.Text = "в.желтый"
		Me.button27.UseVisualStyleBackColor = true
		'
		'button26
		'
		Me.button26.Location = New System.Drawing.Point(61, 19)
		Me.button26.Name = "button26"
		Me.button26.Size = New System.Drawing.Size(233, 23)
		Me.button26.TabIndex = 3
		Me.button26.Text = "все включены"
		Me.button26.UseVisualStyleBackColor = true
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label1.Location = New System.Drawing.Point(133, 379)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(121, 19)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Адрес драйвера"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(167, 401)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(87, 23)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Установить"
		Me.button1.UseVisualStyleBackColor = true
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(113, 402)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(46, 21)
		Me.textBox1.TabIndex = 3
		Me.textBox1.Text = "100"
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'checkBox1
		'
		Me.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.checkBox1.Location = New System.Drawing.Point(10, 400)
		Me.checkBox1.Name = "checkBox1"
		Me.checkBox1.Size = New System.Drawing.Size(96, 24)
		Me.checkBox1.TabIndex = 4
		Me.checkBox1.Text = "HEX / DEC"
		Me.checkBox1.UseVisualStyleBackColor = true
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(113, 425)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(46, 21)
		Me.textBox2.TabIndex = 6
		Me.textBox2.Text = "FB"
		Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(167, 423)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(87, 23)
		Me.button2.TabIndex = 5
		Me.button2.Text = "Заменить"
		Me.button2.UseVisualStyleBackColor = true
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(90, 453)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(69, 21)
		Me.textBox3.TabIndex = 8
		Me.textBox3.Text = "Ч2"
		Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'checkBox2
		'
		Me.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.checkBox2.Checked = true
		Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBox2.Location = New System.Drawing.Point(10, 423)
		Me.checkBox2.Name = "checkBox2"
		Me.checkBox2.Size = New System.Drawing.Size(96, 24)
		Me.checkBox2.TabIndex = 9
		Me.checkBox2.Text = "HEX / DEC"
		Me.checkBox2.UseVisualStyleBackColor = true
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(167, 452)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(87, 23)
		Me.button3.TabIndex = 10
		Me.button3.Text = "Имя"
		Me.button3.UseVisualStyleBackColor = true
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(167, 474)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(87, 23)
		Me.button4.TabIndex = 12
		Me.button4.Text = "Версия"
		Me.button4.UseVisualStyleBackColor = true
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(90, 476)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(69, 21)
		Me.textBox4.TabIndex = 11
		Me.textBox4.Text = "001.02A"
		Me.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(167, 503)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(87, 23)
		Me.button5.TabIndex = 14
		Me.button5.Text = "ID"
		Me.button5.UseVisualStyleBackColor = true
		'
		'textBox5
		'
		Me.textBox5.Location = New System.Drawing.Point(90, 505)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(69, 21)
		Me.textBox5.TabIndex = 13
		Me.textBox5.Text = "001.02A"
		Me.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'button6
		'
		Me.button6.Location = New System.Drawing.Point(167, 526)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(87, 23)
		Me.button6.TabIndex = 15
		Me.button6.Text = "Занятость"
		Me.button6.UseVisualStyleBackColor = true
		'
		'listBox1
		'
		Me.listBox1.FormattingEnabled = true
		Me.listBox1.Location = New System.Drawing.Point(9, 59)
		Me.listBox1.Name = "listBox1"
		Me.listBox1.Size = New System.Drawing.Size(244, 303)
		Me.listBox1.TabIndex = 16
		'
		'pictureBox1
		'
		Me.pictureBox1.Location = New System.Drawing.Point(90, 526)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(70, 23)
		Me.pictureBox1.TabIndex = 17
		Me.pictureBox1.TabStop = false
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label2.Location = New System.Drawing.Point(383, 380)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(178, 19)
		Me.label2.TabIndex = 19
		Me.label2.Text = "Отправленные команды"
		'
		'checkBox3
		'
		Me.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.checkBox3.Location = New System.Drawing.Point(280, 375)
		Me.checkBox3.Name = "checkBox3"
		Me.checkBox3.Size = New System.Drawing.Size(96, 24)
		Me.checkBox3.TabIndex = 20
		Me.checkBox3.Text = "HEX / DEC"
		Me.checkBox3.UseVisualStyleBackColor = true
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label3.Location = New System.Drawing.Point(733, 380)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(178, 19)
		Me.label3.TabIndex = 22
		Me.label3.Text = "Принятые ответы"
		'
		'checkBox4
		'
		Me.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.checkBox4.Location = New System.Drawing.Point(630, 375)
		Me.checkBox4.Name = "checkBox4"
		Me.checkBox4.Size = New System.Drawing.Size(96, 24)
		Me.checkBox4.TabIndex = 23
		Me.checkBox4.Text = "HEX / DEC"
		Me.checkBox4.UseVisualStyleBackColor = true
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label5.Location = New System.Drawing.Point(9, 43)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(151, 13)
		Me.label5.TabIndex = 31
		Me.label5.Text = "Список драйверов"
		'
		'listBox2
		'
		Me.listBox2.FormattingEnabled = true
		Me.listBox2.Location = New System.Drawing.Point(272, 400)
		Me.listBox2.Name = "listBox2"
		Me.listBox2.Size = New System.Drawing.Size(327, 147)
		Me.listBox2.TabIndex = 34
		'
		'listBox3
		'
		Me.listBox3.FormattingEnabled = true
		Me.listBox3.Location = New System.Drawing.Point(626, 400)
		Me.listBox3.Name = "listBox3"
		Me.listBox3.Size = New System.Drawing.Size(327, 147)
		Me.listBox3.TabIndex = 35
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label4.Location = New System.Drawing.Point(9, 9)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(43, 19)
		Me.label4.TabIndex = 36
		Me.label4.Text = "Порт"
		'
		'comboBox1
		'
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20", "COM21", "COM22", "COM23", "COM24", "COM25", "COM26", "COM27", "COM28", "COM29", "COM30", "COM31", "COM32"})
		Me.comboBox1.Location = New System.Drawing.Point(45, 6)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(76, 21)
		Me.comboBox1.TabIndex = 37
		Me.comboBox1.Tag = ""
		Me.comboBox1.Text = "COM?"
		'
		'button7
		'
		Me.button7.Location = New System.Drawing.Point(129, 6)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(125, 23)
		Me.button7.TabIndex = 38
		Me.button7.Text = "Подключить"
		Me.button7.UseVisualStyleBackColor = true
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label6.Location = New System.Drawing.Point(272, 11)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(205, 19)
		Me.label6.TabIndex = 39
		Me.label6.Text = "Диагностика / Тестирование"
		'
		'textBox6
		'
		Me.textBox6.Location = New System.Drawing.Point(475, 8)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(282, 21)
		Me.textBox6.TabIndex = 40
		Me.textBox6.Text = "$2F$3A$24$01"
		'
		'checkBox5
		'
		Me.checkBox5.Location = New System.Drawing.Point(764, 6)
		Me.checkBox5.Name = "checkBox5"
		Me.checkBox5.Size = New System.Drawing.Size(78, 24)
		Me.checkBox5.TabIndex = 41
		Me.checkBox5.Text = "+ 3xFFh"
		Me.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.checkBox5.UseVisualStyleBackColor = true
		'
		'button8
		'
		Me.button8.Location = New System.Drawing.Point(867, 6)
		Me.button8.Name = "button8"
		Me.button8.Size = New System.Drawing.Size(87, 23)
		Me.button8.TabIndex = 42
		Me.button8.Text = "Отправить"
		Me.button8.UseVisualStyleBackColor = true
		'
		'button34
		'
		Me.button34.Location = New System.Drawing.Point(342, 222)
		Me.button34.Name = "button34"
		Me.button34.Size = New System.Drawing.Size(233, 23)
		Me.button34.TabIndex = 18
		Me.button34.Text = "все включены и лунный *"
		Me.button34.UseVisualStyleBackColor = true
		'
		'button35
		'
		Me.button35.Location = New System.Drawing.Point(342, 193)
		Me.button35.Name = "button35"
		Me.button35.Size = New System.Drawing.Size(233, 23)
		Me.button35.TabIndex = 17
		Me.button35.Text = "красный + лунный *"
		Me.button35.UseVisualStyleBackColor = true
		'
		'button36
		'
		Me.button36.Location = New System.Drawing.Point(342, 164)
		Me.button36.Name = "button36"
		Me.button36.Size = New System.Drawing.Size(233, 23)
		Me.button36.TabIndex = 16
		Me.button36.Text = "в.желтый * + лунный"
		Me.button36.UseVisualStyleBackColor = true
		'
		'button37
		'
		Me.button37.Location = New System.Drawing.Point(342, 135)
		Me.button37.Name = "button37"
		Me.button37.Size = New System.Drawing.Size(233, 23)
		Me.button37.TabIndex = 15
		Me.button37.Text = "в.желтый + лунный"
		Me.button37.UseVisualStyleBackColor = true
		'
		'button38
		'
		Me.button38.Location = New System.Drawing.Point(342, 106)
		Me.button38.Name = "button38"
		Me.button38.Size = New System.Drawing.Size(233, 23)
		Me.button38.TabIndex = 14
		Me.button38.Text = "в.желтый * + н.желтый"
		Me.button38.UseVisualStyleBackColor = true
		'
		'button39
		'
		Me.button39.Location = New System.Drawing.Point(342, 77)
		Me.button39.Name = "button39"
		Me.button39.Size = New System.Drawing.Size(233, 23)
		Me.button39.TabIndex = 13
		Me.button39.Text = "зеленый +  лунный"
		Me.button39.UseVisualStyleBackColor = true
		'
		'button40
		'
		Me.button40.Location = New System.Drawing.Point(342, 48)
		Me.button40.Name = "button40"
		Me.button40.Size = New System.Drawing.Size(233, 23)
		Me.button40.TabIndex = 12
		Me.button40.Text = "в.желтый + н.желтый"
		Me.button40.UseVisualStyleBackColor = true
		'
		'button41
		'
		Me.button41.Location = New System.Drawing.Point(342, 19)
		Me.button41.Name = "button41"
		Me.button41.Size = New System.Drawing.Size(233, 23)
		Me.button41.TabIndex = 11
		Me.button41.Text = "лунный"
		Me.button41.UseVisualStyleBackColor = true
		'
		'serialPort1
		'
		Me.serialPort1.BaudRate = 19200
		'
		'button42
		'
		Me.button42.Location = New System.Drawing.Point(129, 39)
		Me.button42.Margin = New System.Windows.Forms.Padding(0)
		Me.button42.Name = "button42"
		Me.button42.Size = New System.Drawing.Size(124, 20)
		Me.button42.TabIndex = 43
		Me.button42.Text = "Скан"
		Me.button42.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(966, 561)
		Me.Controls.Add(Me.button42)
		Me.Controls.Add(Me.button8)
		Me.Controls.Add(Me.checkBox5)
		Me.Controls.Add(Me.textBox6)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.button7)
		Me.Controls.Add(Me.comboBox1)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.listBox3)
		Me.Controls.Add(Me.listBox2)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.checkBox4)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.checkBox3)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.listBox1)
		Me.Controls.Add(Me.button6)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.textBox5)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.textBox4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.checkBox2)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.checkBox1)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.tabControl1)
		Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.Name = "MainForm"
		Me.Text = "RWD tester"
		Me.tabControl1.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.tabPage2.ResumeLayout(false)
		Me.groupBox6.ResumeLayout(false)
		Me.groupBox5.ResumeLayout(false)
		Me.groupBox4.ResumeLayout(false)
		Me.tabPage3.ResumeLayout(false)
		Me.groupBox8.ResumeLayout(false)
		Me.groupBox7.ResumeLayout(false)
		Me.tabPage4.ResumeLayout(false)
		Me.groupBox9.ResumeLayout(false)
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button42 As System.Windows.Forms.Button
	Private serialPort1 As System.IO.Ports.SerialPort
	Private button41 As System.Windows.Forms.Button
	Private button40 As System.Windows.Forms.Button
	Private button39 As System.Windows.Forms.Button
	Private button38 As System.Windows.Forms.Button
	Private button37 As System.Windows.Forms.Button
	Private button36 As System.Windows.Forms.Button
	Private button35 As System.Windows.Forms.Button
	Private button34 As System.Windows.Forms.Button
	Private button26 As System.Windows.Forms.Button
	Private button27 As System.Windows.Forms.Button
	Private button28 As System.Windows.Forms.Button
	Private button29 As System.Windows.Forms.Button
	Private button30 As System.Windows.Forms.Button
	Private button31 As System.Windows.Forms.Button
	Private button32 As System.Windows.Forms.Button
	Private button33 As System.Windows.Forms.Button
	Private groupBox9 As System.Windows.Forms.GroupBox
	Private button24 As System.Windows.Forms.Button
	Private button25 As System.Windows.Forms.Button
	Private label24 As System.Windows.Forms.Label
	Private label20 As System.Windows.Forms.Label
	Private groupBox7 As System.Windows.Forms.GroupBox
	Private comboBox2 As System.Windows.Forms.ComboBox
	Private label21 As System.Windows.Forms.Label
	Private label22 As System.Windows.Forms.Label
	Private label23 As System.Windows.Forms.Label
	Private comboBox3 As System.Windows.Forms.ComboBox
	Private comboBox4 As System.Windows.Forms.ComboBox
	Private button23 As System.Windows.Forms.Button
	Private groupBox8 As System.Windows.Forms.GroupBox
	Private button16 As System.Windows.Forms.Button
	Private button18 As System.Windows.Forms.Button
	Private button17 As System.Windows.Forms.Button
	Private button22 As System.Windows.Forms.Button
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private button20 As System.Windows.Forms.Button
	Private button19 As System.Windows.Forms.Button
	Private button21 As System.Windows.Forms.Button
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private label19 As System.Windows.Forms.Label
	Private button15 As System.Windows.Forms.Button
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private textBox8 As System.Windows.Forms.TextBox
	Private button10 As System.Windows.Forms.Button
	Private vScrollBar2 As System.Windows.Forms.VScrollBar
	Private textBox9 As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Private button11 As System.Windows.Forms.Button
	Private vScrollBar3 As System.Windows.Forms.VScrollBar
	Private label10 As System.Windows.Forms.Label
	Private button14 As System.Windows.Forms.Button
	Private button13 As System.Windows.Forms.Button
	Private label9 As System.Windows.Forms.Label
	Private button12 As System.Windows.Forms.Button
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private label18 As System.Windows.Forms.Label
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private tabPage1 As System.Windows.Forms.TabPage
	Private textBox7 As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private button9 As System.Windows.Forms.Button
	Private vScrollBar1 As System.Windows.Forms.VScrollBar
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private button8 As System.Windows.Forms.Button
	Private checkBox5 As System.Windows.Forms.CheckBox
	Private textBox6 As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private button7 As System.Windows.Forms.Button
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private listBox3 As System.Windows.Forms.ListBox
	Private listBox2 As System.Windows.Forms.ListBox
	Private label5 As System.Windows.Forms.Label
	Private checkBox4 As System.Windows.Forms.CheckBox
	Private label3 As System.Windows.Forms.Label
	Private checkBox3 As System.Windows.Forms.CheckBox
	Private label2 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private listBox1 As System.Windows.Forms.ListBox
	Private button6 As System.Windows.Forms.Button
	Private textBox5 As System.Windows.Forms.TextBox
	Private button5 As System.Windows.Forms.Button
	Private textBox4 As System.Windows.Forms.TextBox
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private checkBox2 As System.Windows.Forms.CheckBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private button2 As System.Windows.Forms.Button
	Private textBox2 As System.Windows.Forms.TextBox
	Private checkBox1 As System.Windows.Forms.CheckBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private tabPage4 As System.Windows.Forms.TabPage
	Private tabPage3 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
	
End Class
