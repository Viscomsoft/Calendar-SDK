Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxCalendar1.Month = 1
        AxCalendar2.Month = 2
        AxCalendar3.Month = 3
        AxCalendar4.Month = 4
        AxCalendar5.Month = 5
        AxCalendar6.Month = 6




    End Sub

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Object
        Dim clrColor As Color

        clrColor = Color.FromArgb(128, 255, 255)
        Me.AxCalendar1.Month = Me.AxCalendar1.Month
        Me.AxCalendar1.Year = Me.AxCalendar1.Year

        Me.AxCalendar1.SetText(1, "New Year")

        For i = 1 To 10

            Me.AxCalendar1.DayTextColor = System.Drawing.Color.Red
            Me.AxCalendar1.SetHighLightDay(AxCalendar1.Year, AxCalendar1.Month, i, Color2Uint32(clrColor))

        Next

        Me.AxCalendar1.Redraw()

        'calendar 2
        clrColor = Color.FromArgb(255, 128, 100)

        Me.AxCalendar2.Month = Me.AxCalendar2.Month
        Me.AxCalendar2.Year = Me.AxCalendar2.Year

        For i = 10 To 15
            Me.AxCalendar2.SetHighLightDay(AxCalendar2.Year, AxCalendar2.Month, i, Color2Uint32(clrColor))
        Next

        Me.AxCalendar2.Redraw()

        'calendar 3
        clrColor = Color.FromArgb(200, 50, 100)

        Me.AxCalendar3.Month = Me.AxCalendar3.Month
        Me.AxCalendar3.Year = Me.AxCalendar3.Year

        For i = 20 To 28
            Me.AxCalendar3.SetHighLightDay(AxCalendar3.Year, AxCalendar3.Month, i, Color2Uint32(clrColor))
        Next

        Me.AxCalendar3.Redraw()

        'calendar 4
        clrColor = Color.FromArgb(100, 255, 100)

        Me.AxCalendar4.Month = Me.AxCalendar4.Month
        Me.AxCalendar4.Year = Me.AxCalendar4.Year

        Me.AxCalendar4.DayTextFontSize = 8
        Me.AxCalendar4.SetText(1, "Anniversary")
        For i = 1 To 5
            Me.AxCalendar4.SetHighLightDay(AxCalendar4.Year, AxCalendar4.Month, i, Color2Uint32(clrColor))
        Next

        Me.AxCalendar4.Redraw()

        'calendar 5
        clrColor = Color.FromArgb(100, 155, 255)

        Me.AxCalendar5.Month = Me.AxCalendar5.Month
        Me.AxCalendar5.Year = Me.AxCalendar5.Year


        For i = 1 To 10 Step 2
            Me.AxCalendar5.SetHighLightDay(AxCalendar5.Year, AxCalendar5.Month, i, Color2Uint32(clrColor))
        Next

        Me.AxCalendar5.Redraw()

        'calendar 6
        clrColor = Color.FromArgb(200, 100, 255)

        Me.AxCalendar6.Month = Me.AxCalendar6.Month
        Me.AxCalendar6.Year = Me.AxCalendar6.Year


        For i = 1 To 30 Step 5
            Me.AxCalendar6.SetHighLightDay(AxCalendar6.Year, AxCalendar6.Month, i, Color2Uint32(clrColor))
        Next

        Me.AxCalendar6.Redraw()
    End Sub
End Class
