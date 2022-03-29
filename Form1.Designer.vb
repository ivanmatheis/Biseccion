<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biseccion
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lf = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.lc = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lr = New System.Windows.Forms.Label()
        Me.LImpiar = New System.Windows.Forms.Button()
        Me.tr = New System.Windows.Forms.TextBox()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Graficar = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(77, 27)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 0
        Me.lf.Text = "Dame funcion"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(77, 53)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(44, 13)
        Me.la.TabIndex = 1
        Me.la.Text = "Dame a"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(77, 82)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(44, 13)
        Me.lb.TabIndex = 2
        Me.lb.Text = "Dame b"
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Location = New System.Drawing.Point(77, 111)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(63, 13)
        Me.lc.TabIndex = 3
        Me.lc.Text = "Dame cifras"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(218, 108)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 4
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(218, 82)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(100, 20)
        Me.tb.TabIndex = 5
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(218, 53)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 6
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(218, 27)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 7
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(366, 15)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(366, 106)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Salida.Location = New System.Drawing.Point(12, 403)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(841, 163)
        Me.Salida.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "a"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "xi"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "b"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "f(a)"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "f(xi)"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "f(b)"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "error"
        Me.Column8.Name = "Column8"
        '
        'lr
        '
        Me.lr.AutoSize = True
        Me.lr.Location = New System.Drawing.Point(18, 358)
        Me.lr.Name = "lr"
        Me.lr.Size = New System.Drawing.Size(109, 13)
        Me.lr.TabIndex = 11
        Me.lr.Text = "La raiz aproximada es"
        '
        'LImpiar
        '
        Me.LImpiar.Location = New System.Drawing.Point(366, 77)
        Me.LImpiar.Name = "LImpiar"
        Me.LImpiar.Size = New System.Drawing.Size(75, 23)
        Me.LImpiar.TabIndex = 12
        Me.LImpiar.Text = "&Limpiar"
        Me.LImpiar.UseVisualStyleBackColor = True
        '
        'tr
        '
        Me.tr.Location = New System.Drawing.Point(146, 355)
        Me.tr.Name = "tr"
        Me.tr.Size = New System.Drawing.Size(100, 20)
        Me.tr.TabIndex = 13
        '
        'Graf
        '
        ChartArea1.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Graf.Legends.Add(Legend1)
        Me.Graf.Location = New System.Drawing.Point(477, 108)
        Me.Graf.Name = "Graf"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Graf.Series.Add(Series1)
        Me.Graf.Series.Add(Series2)
        Me.Graf.Size = New System.Drawing.Size(953, 276)
        Me.Graf.TabIndex = 14
        Me.Graf.Text = "Chart1"
        '
        'Graficar
        '
        Me.Graficar.Location = New System.Drawing.Point(366, 48)
        Me.Graficar.Name = "Graficar"
        Me.Graficar.Size = New System.Drawing.Size(75, 23)
        Me.Graficar.TabIndex = 15
        Me.Graficar.Text = "Graficar"
        Me.Graficar.UseVisualStyleBackColor = True
        '
        'Biseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1442, 640)
        Me.Controls.Add(Me.Graficar)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.tr)
        Me.Controls.Add(Me.LImpiar)
        Me.Controls.Add(Me.lr)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lf)
        Me.Name = "Biseccion"
        Me.Text = "Form1"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lf As Label
    Friend WithEvents la As Label
    Friend WithEvents lb As Label
    Friend WithEvents lc As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lr As Label
    Friend WithEvents LImpiar As Button
    Friend WithEvents tr As TextBox
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents Graficar As Button
End Class
