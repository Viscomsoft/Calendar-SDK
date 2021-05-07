VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{A035D4AC-4104-4772-AD67-C48F484EA961}#1.0#0"; "Calendar.ocx"
Begin VB.Form Form1 
   Caption         =   "Calendar ActiveX Control Demo"
   ClientHeight    =   10950
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   13725
   LinkTopic       =   "Form1"
   ScaleHeight     =   10950
   ScaleWidth      =   13725
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkswap 
      Caption         =   "Swap Month Year"
      Height          =   255
      Left            =   2880
      TabIndex        =   76
      Top             =   8280
      Width           =   1695
   End
   Begin VB.CommandButton cmdprint 
      Caption         =   "Print Calendar"
      Height          =   375
      Left            =   240
      TabIndex        =   75
      Top             =   8160
      Width           =   1695
   End
   Begin CALENDARLib.Calendar Calendar1 
      Height          =   7815
      Left            =   240
      TabIndex        =   74
      Top             =   240
      Width           =   10095
      _Version        =   65536
      _ExtentX        =   17806
      _ExtentY        =   13785
      _StockProps     =   0
   End
   Begin VB.Frame Frame10 
      Height          =   615
      Left            =   10800
      TabIndex        =   70
      Top             =   1320
      Width           =   2775
      Begin VB.CommandButton Command8 
         Caption         =   "Set"
         Height          =   375
         Left            =   1560
         TabIndex        =   73
         Top             =   240
         Width           =   735
      End
      Begin VB.TextBox txtSetDay 
         Height          =   375
         Left            =   720
         TabIndex        =   72
         Text            =   "10"
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label24 
         Caption         =   "Day"
         Height          =   255
         Left            =   120
         TabIndex        =   71
         Top             =   240
         Width           =   615
      End
   End
   Begin VB.Frame Frame9 
      Caption         =   "Highlight specific range"
      Height          =   1335
      Left            =   5640
      TabIndex        =   57
      Top             =   9480
      Width           =   5055
      Begin VB.CommandButton cmdclearhighrange 
         Caption         =   "Clear Highlight"
         Height          =   375
         Left            =   1920
         TabIndex        =   67
         Top             =   960
         Width           =   1695
      End
      Begin VB.TextBox txtmonthrange 
         Height          =   285
         Left            =   3240
         TabIndex        =   66
         Text            =   "1"
         Top             =   240
         Width           =   975
      End
      Begin VB.CommandButton cmdhighrange 
         Caption         =   "Highlight"
         Height          =   375
         Left            =   720
         TabIndex        =   63
         Top             =   960
         Width           =   975
      End
      Begin VB.TextBox txtyearrange 
         Height          =   285
         Left            =   1440
         TabIndex        =   62
         Text            =   "txtyearrange"
         Top             =   240
         Width           =   855
      End
      Begin VB.TextBox txtselto 
         Height          =   285
         Left            =   3000
         TabIndex        =   61
         Text            =   "20"
         Top             =   600
         Width           =   855
      End
      Begin VB.TextBox txtselfrom 
         Height          =   285
         Left            =   1440
         TabIndex        =   59
         Text            =   "1"
         Top             =   600
         Width           =   735
      End
      Begin VB.Label Label22 
         Caption         =   "Month"
         Height          =   255
         Left            =   2400
         TabIndex        =   65
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label21 
         Caption         =   "Year"
         Height          =   255
         Left            =   120
         TabIndex        =   64
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label20 
         Caption         =   "To"
         Height          =   255
         Left            =   2400
         TabIndex        =   60
         Top             =   600
         Width           =   375
      End
      Begin VB.Label Label19 
         Caption         =   "Start from day"
         Height          =   255
         Left            =   120
         TabIndex        =   58
         Top             =   600
         Width           =   1215
      End
   End
   Begin VB.Frame Frame8 
      Caption         =   "Change Day Captions"
      Height          =   3375
      Left            =   10800
      TabIndex        =   48
      Top             =   7200
      Width           =   2775
      Begin VB.CommandButton cmdchangedaycap 
         Caption         =   "Change"
         Height          =   375
         Left            =   120
         TabIndex        =   56
         Top             =   2880
         Width           =   1095
      End
      Begin VB.TextBox txtdaycaption6 
         Height          =   285
         Left            =   120
         TabIndex        =   55
         Text            =   "Saturday"
         Top             =   2520
         Width           =   2415
      End
      Begin VB.TextBox txtdaycaption5 
         Height          =   285
         Left            =   120
         TabIndex        =   54
         Text            =   "Friday"
         Top             =   2160
         Width           =   2415
      End
      Begin VB.TextBox txtdaycaption4 
         Height          =   285
         Left            =   120
         TabIndex        =   53
         Text            =   "Thursday"
         Top             =   1800
         Width           =   2415
      End
      Begin VB.TextBox txtdaycaption3 
         Height          =   285
         Left            =   120
         TabIndex        =   52
         Text            =   "Wednesday"
         Top             =   1440
         Width           =   2415
      End
      Begin VB.TextBox txtdaycaption2 
         Height          =   285
         Left            =   120
         TabIndex        =   51
         Text            =   "Tuesday"
         Top             =   1080
         Width           =   2415
      End
      Begin VB.TextBox txtdaycaption1 
         Height          =   285
         Left            =   120
         TabIndex        =   50
         Text            =   "Monday"
         Top             =   720
         Width           =   2415
      End
      Begin VB.TextBox txtdaycaption0 
         Height          =   285
         Left            =   120
         TabIndex        =   49
         Text            =   "Sunday"
         Top             =   360
         Width           =   2415
      End
   End
   Begin VB.Frame Frame7 
      Caption         =   "Text"
      Height          =   1335
      Left            =   8400
      TabIndex        =   43
      Top             =   8160
      Width           =   2295
      Begin VB.ComboBox cbotextsize 
         Height          =   315
         Left            =   1080
         Style           =   2  'Dropdown List
         TabIndex        =   69
         Top             =   600
         Width           =   1095
      End
      Begin VB.CommandButton Command4 
         Caption         =   "Select"
         Height          =   255
         Left            =   1080
         TabIndex        =   47
         Top             =   1080
         Width           =   855
      End
      Begin VB.ComboBox cbodaytextfont 
         Height          =   315
         Left            =   600
         Style           =   2  'Dropdown List
         TabIndex        =   45
         Top             =   240
         Width           =   1575
      End
      Begin VB.Label Label23 
         Caption         =   "Font Size"
         Height          =   255
         Left            =   120
         TabIndex        =   68
         Top             =   600
         Width           =   735
      End
      Begin VB.Label Label18 
         Caption         =   "ForeColor"
         Height          =   255
         Left            =   120
         TabIndex        =   46
         Top             =   1080
         Width           =   735
      End
      Begin VB.Label Label17 
         Caption         =   "Font"
         Height          =   255
         Left            =   120
         TabIndex        =   44
         Top             =   240
         Width           =   495
      End
   End
   Begin VB.TextBox Text3 
      Enabled         =   0   'False
      Height          =   375
      Left            =   10800
      TabIndex        =   40
      Top             =   6600
      Width           =   2415
   End
   Begin VB.TextBox txtCurrentDay 
      Enabled         =   0   'False
      Height          =   375
      Left            =   12720
      TabIndex        =   39
      Top             =   5760
      Width           =   615
   End
   Begin VB.Frame Frame6 
      Caption         =   "Text"
      Height          =   1935
      Left            =   10800
      TabIndex        =   33
      Top             =   3720
      Width           =   2775
      Begin VB.TextBox txtdaytext 
         Height          =   285
         Left            =   840
         TabIndex        =   38
         Text            =   "enter your text"
         Top             =   840
         Width           =   1815
      End
      Begin VB.TextBox txtdayno 
         Height          =   285
         Left            =   840
         TabIndex        =   35
         Text            =   "1"
         Top             =   360
         Width           =   1215
      End
      Begin VB.CommandButton Command6 
         Caption         =   "Set"
         Height          =   375
         Left            =   840
         TabIndex        =   34
         Top             =   1200
         Width           =   615
      End
      Begin VB.Label txtText 
         Caption         =   "Text"
         Height          =   375
         Left            =   120
         TabIndex        =   37
         Top             =   840
         Width           =   615
      End
      Begin VB.Label Label14 
         Caption         =   "Day"
         Height          =   495
         Left            =   120
         TabIndex        =   36
         Top             =   360
         Width           =   495
      End
   End
   Begin VB.Frame Frame5 
      Caption         =   "Highlight"
      Height          =   1575
      Left            =   10800
      TabIndex        =   25
      Top             =   2040
      Width           =   2775
      Begin VB.TextBox txtDay 
         Height          =   285
         Left            =   840
         TabIndex        =   32
         Text            =   "1"
         Top             =   1080
         Width           =   1095
      End
      Begin VB.TextBox txtMonth 
         Height          =   285
         Left            =   840
         TabIndex        =   30
         Text            =   "1"
         Top             =   720
         Width           =   1095
      End
      Begin VB.TextBox txtYear 
         Height          =   285
         Left            =   840
         TabIndex        =   28
         Text            =   "2021"
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton Command5 
         Caption         =   "Set"
         Height          =   375
         Left            =   2040
         TabIndex        =   26
         Top             =   960
         Width           =   615
      End
      Begin VB.Label Label13 
         Caption         =   "Day"
         Height          =   255
         Left            =   120
         TabIndex        =   31
         Top             =   1080
         Width           =   615
      End
      Begin VB.Label Label12 
         Caption         =   "Month"
         Height          =   255
         Left            =   120
         TabIndex        =   29
         Top             =   720
         Width           =   495
      End
      Begin VB.Label Label11 
         Caption         =   "Year"
         Height          =   255
         Left            =   120
         TabIndex        =   27
         Top             =   360
         Width           =   615
      End
   End
   Begin VB.Frame Frame4 
      Height          =   1215
      Left            =   10800
      TabIndex        =   19
      Top             =   0
      Width           =   2775
      Begin VB.CommandButton cmdgo 
         Caption         =   "GO"
         Height          =   255
         Left            =   1680
         TabIndex        =   24
         Top             =   840
         Width           =   615
      End
      Begin VB.TextBox Text2 
         Height          =   285
         Left            =   720
         TabIndex        =   23
         Text            =   "2021"
         Top             =   840
         Width           =   735
      End
      Begin VB.TextBox Text1 
         Height          =   285
         Left            =   720
         TabIndex        =   22
         Text            =   "1"
         Top             =   360
         Width           =   735
      End
      Begin VB.Label Label10 
         Caption         =   "Year"
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   840
         Width           =   495
      End
      Begin VB.Label Label8 
         Caption         =   "Month"
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   360
         Width           =   615
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Day "
      Height          =   1335
      Left            =   5640
      TabIndex        =   14
      Top             =   8160
      Width           =   2655
      Begin VB.ComboBox cbodayfont 
         Height          =   315
         Left            =   960
         Style           =   2  'Dropdown List
         TabIndex        =   16
         Top             =   360
         Width           =   1575
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Select"
         Height          =   255
         Left            =   960
         TabIndex        =   15
         Top             =   840
         Width           =   855
      End
      Begin VB.Label Label9 
         Caption         =   "Font"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   360
         Width           =   735
      End
      Begin VB.Label Label7 
         Caption         =   "ForeColor"
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   840
         Width           =   855
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Day Caption"
      Height          =   1695
      Left            =   3000
      TabIndex        =   7
      Top             =   8640
      Width           =   2535
      Begin VB.CommandButton Command2 
         Caption         =   "Select"
         Height          =   255
         Left            =   960
         TabIndex        =   13
         Top             =   1320
         Width           =   855
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Select"
         Height          =   255
         Left            =   960
         TabIndex        =   12
         Top             =   840
         Width           =   855
      End
      Begin VB.ComboBox cbodaycaption 
         Height          =   315
         Left            =   960
         Style           =   2  'Dropdown List
         TabIndex        =   9
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label Label6 
         Caption         =   "ForeColor"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   1320
         Width           =   855
      End
      Begin VB.Label Label5 
         Caption         =   "BackColor"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   840
         Width           =   855
      End
      Begin VB.Label Label4 
         Caption         =   "Font"
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   360
         Width           =   735
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   1080
      Top             =   10320
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      Caption         =   "Month Year"
      Height          =   1695
      Left            =   120
      TabIndex        =   0
      Top             =   8640
      Width           =   2775
      Begin VB.CommandButton cmdmonthyearforecolor 
         Caption         =   "Select"
         Height          =   255
         Left            =   1080
         TabIndex        =   6
         Top             =   1320
         Width           =   855
      End
      Begin VB.CommandButton cmdmonthyearbackcolor 
         Caption         =   "Select"
         Height          =   255
         Left            =   1080
         TabIndex        =   4
         Top             =   840
         Width           =   855
      End
      Begin VB.ComboBox cbofont 
         Height          =   315
         Left            =   1080
         Style           =   2  'Dropdown List
         TabIndex        =   2
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label3 
         Caption         =   "ForeColor"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   1320
         Width           =   855
      End
      Begin VB.Label Label2 
         Caption         =   "BackColor"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   840
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Font"
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   615
      End
   End
   Begin VB.Label Label16 
      Caption         =   "Current Selected Text"
      Height          =   255
      Left            =   10800
      TabIndex        =   42
      Top             =   6360
      Width           =   1695
   End
   Begin VB.Label Label15 
      Caption         =   "Current Selected Day"
      Height          =   255
      Left            =   10800
      TabIndex        =   41
      Top             =   5760
      Width           =   1695
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Calendar1_OnDayClick(ByVal iYear As Integer, ByVal iMonth As Integer, ByVal iDay As Integer, ByVal strText As String)
txtCurrentDay = iDay
Text3 = strText
End Sub


Private Sub cbodaycaption_Click()
Me.Calendar1.DayCaptionFont = cbodaycaption.List(cbodaycaption.ListIndex)
End Sub

Private Sub cbodayfont_Click()
Me.Calendar1.DayFont = cbodayfont.List(cbodayfont.ListIndex)
End Sub


Private Sub cbodaytextfont_Click()
Me.Calendar1.DayTextFont = cbodaytextfont.List(cbodaytextfont.ListIndex)
End Sub

Private Sub cbofont_Click()
Me.Calendar1.MonthYearFont = cbofont.List(cbofont.ListIndex)

End Sub

Private Sub cbotextsize_Click()
Me.Calendar1.DayTextFontSize = cbotextsize.List(cbotextsize.ListIndex)
End Sub

Private Sub chkswap_Click()
If chkswap.Value = 1 Then
  Me.Calendar1.MonthYearSwap = True
Else
  Me.Calendar1.MonthYearSwap = False
End If


End Sub

Private Sub cmdchangedaycap_Click()
Me.Calendar1.SetDayCaptions 0, txtdaycaption0
Me.Calendar1.SetDayCaptions 1, txtdaycaption1
Me.Calendar1.SetDayCaptions 2, txtdaycaption2
Me.Calendar1.SetDayCaptions 3, txtdaycaption3
Me.Calendar1.SetDayCaptions 4, txtdaycaption4
Me.Calendar1.SetDayCaptions 5, txtdaycaption5
Me.Calendar1.SetDayCaptions 6, txtdaycaption6

End Sub

Private Sub cmdclearhighrange_Click()
Me.Calendar1.Month = txtmonthrange
Me.Calendar1.Year = txtyearrange

For i = txtselfrom To txtselto
        
        Me.Calendar1.SetText i, ""
        Me.Calendar1.DayTextColor = vbRed
        Me.Calendar1.SetHighLightDay Calendar1.Year, Calendar1.Month, i, RGB(255, 255, 255)

Next

Me.Calendar1.Redraw
End Sub

Private Sub cmdgo_Click()
Me.Calendar1.Month = Text1
Me.Calendar1.Year = Text2
End Sub

Private Sub cmdhighrange_Click()

Me.Calendar1.Month = txtmonthrange
Me.Calendar1.Year = txtyearrange

For i = txtselfrom To txtselto
        
        Me.Calendar1.SetText i, Str(i)
        Me.Calendar1.DayTextColor = vbRed
        Me.Calendar1.SetHighLightDay Calendar1.Year, Calendar1.Month, i, &HFF8080

Next

Me.Calendar1.Redraw

End Sub

Private Sub cmdmonthyearbackcolor_Click()
CommonDialog1.ShowColor

Me.Calendar1.MonthYearBackColor = CommonDialog1.Color
End Sub

Private Sub cmdmonthyearforecolor_Click()

CommonDialog1.ShowColor

Me.Calendar1.MonthYearForeColor = CommonDialog1.Color

End Sub

Private Sub cmdprint_Click()
Me.Calendar1.PrintCalendar
End Sub

Private Sub Command1_Click()
CommonDialog1.ShowColor
Me.Calendar1.DayCaptionBackColor = CommonDialog1.Color

End Sub

Private Sub Command2_Click()
CommonDialog1.ShowColor

Me.Calendar1.DayCaptionForeColor = CommonDialog1.Color


End Sub

Private Sub Command3_Click()
CommonDialog1.ShowColor
Me.Calendar1.DayColor = CommonDialog1.Color

End Sub

Private Sub Command4_Click()

CommonDialog1.ShowColor
Me.Calendar1.DayTextColor = CommonDialog1.Color

End Sub

Private Sub Command5_Click()

CommonDialog1.ShowColor

Me.Calendar1.SetHighLightDay txtYear, txtMonth, txtDay, CommonDialog1.Color
End Sub

Private Sub Command6_Click()
Me.Calendar1.SetText txtdayno, txtdaytext
End Sub



Private Sub Command8_Click()
Me.Calendar1.Day = Me.txtSetDay.Text
End Sub

Private Sub Command7_Click()


End Sub

Private Sub Form_Load()

Text2 = Me.Calendar1.Year
Text1 = Me.Calendar1.Month

txtYear = Me.Calendar1.Year
txtMonth = Me.Calendar1.Month

txtyearrange = Me.Calendar1.Year
txtmonthrange = Me.Calendar1.Month

cbofont.AddItem "Arial"
cbofont.AddItem "Arial Black"
cbofont.AddItem "Courier New"
cbofont.AddItem "MS Sans Serif"
cbofont.AddItem "Tahoma"
cbofont.AddItem "Times New Roman"
cbofont.ListIndex = 0

cbodaycaption.AddItem "Arial"
cbodaycaption.AddItem "Arial Black"
cbodaycaption.AddItem "Courier New"
cbodaycaption.AddItem "MS Sans Serif"
cbodaycaption.AddItem "Tahoma"
cbodaycaption.AddItem "Times New Roman"
cbodaycaption.ListIndex = 0

cbodayfont.AddItem "Arial"
cbodayfont.AddItem "Arial Black"
cbodayfont.AddItem "Courier New"
cbodayfont.AddItem "MS Sans Serif"
cbodayfont.AddItem "Tahoma"
cbodayfont.AddItem "Times New Roman"
cbodayfont.ListIndex = 0


cbodaytextfont.AddItem "Arial"
cbodaytextfont.AddItem "Arial Black"
cbodaytextfont.AddItem "Courier New"
cbodaytextfont.AddItem "MS Sans Serif"
cbodaytextfont.AddItem "Tahoma"
cbodaytextfont.AddItem "Times New Roman"
cbodaytextfont.ListIndex = 0

cbotextsize.AddItem "8"
cbotextsize.AddItem "10"
cbotextsize.AddItem "12"
cbotextsize.AddItem "14"
cbotextsize.AddItem "16"
cbotextsize.AddItem "18"
cbotextsize.ListIndex = 0

End Sub

