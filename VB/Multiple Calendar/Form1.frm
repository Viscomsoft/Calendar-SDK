VERSION 5.00
Object = "{A035D4AC-4104-4772-AD67-C48F484EA961}#1.0#0"; "Calendar.ocx"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   9705
   ClientLeft      =   225
   ClientTop       =   555
   ClientWidth     =   18390
   LinkTopic       =   "Form1"
   ScaleHeight     =   9705
   ScaleWidth      =   18390
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Highlight important days"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   120
      Width           =   2415
   End
   Begin CALENDARLib.Calendar Calendar1 
      Height          =   4335
      Left            =   120
      TabIndex        =   0
      Top             =   600
      Width           =   5775
      _Version        =   65536
      _ExtentX        =   10186
      _ExtentY        =   7646
      _StockProps     =   0
   End
   Begin CALENDARLib.Calendar Calendar2 
      Height          =   4335
      Left            =   6000
      TabIndex        =   1
      Top             =   600
      Width           =   5775
      _Version        =   65536
      _ExtentX        =   10186
      _ExtentY        =   7646
      _StockProps     =   0
   End
   Begin CALENDARLib.Calendar Calendar3 
      Height          =   4335
      Left            =   12000
      TabIndex        =   2
      Top             =   600
      Width           =   5775
      _Version        =   65536
      _ExtentX        =   10186
      _ExtentY        =   7646
      _StockProps     =   0
   End
   Begin CALENDARLib.Calendar Calendar4 
      Height          =   4335
      Left            =   120
      TabIndex        =   3
      Top             =   5040
      Width           =   5775
      _Version        =   65536
      _ExtentX        =   10186
      _ExtentY        =   7646
      _StockProps     =   0
   End
   Begin CALENDARLib.Calendar Calendar5 
      Height          =   4335
      Left            =   6000
      TabIndex        =   4
      Top             =   5040
      Width           =   5775
      _Version        =   65536
      _ExtentX        =   10186
      _ExtentY        =   7646
      _StockProps     =   0
   End
   Begin CALENDARLib.Calendar Calendar6 
      Height          =   4335
      Left            =   12000
      TabIndex        =   5
      Top             =   5040
      Width           =   5775
      _Version        =   65536
      _ExtentX        =   10186
      _ExtentY        =   7646
      _StockProps     =   0
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
 Dim i As Integer
        Dim clrColor

        clrColor = RGB(128, 255, 255)
        Me.Calendar1.Month = Me.Calendar1.Month
        Me.Calendar1.Year = Me.Calendar1.Year

        Me.Calendar1.SetText 1, "New Year"

        For i = 1 To 10

            Me.Calendar1.DayTextColor = RGB(255, 0, 0)
            Me.Calendar1.SetHighLightDay Calendar1.Year, Calendar1.Month, i, clrColor

        Next

        Me.Calendar1.Redraw
        
        
        'calendar 2
        clrColor = RGB(255, 128, 100)

        Me.Calendar2.Month = Me.Calendar2.Month
        Me.Calendar2.Year = Me.Calendar2.Year

        For i = 10 To 15
            Me.Calendar2.SetHighLightDay Calendar2.Year, Calendar2.Month, i, clrColor
        Next

        Me.Calendar2.Redraw
        
         'calendar 3
        clrColor = RGB(200, 50, 100)

        Me.Calendar3.Month = Me.Calendar3.Month
        Me.Calendar3.Year = Me.Calendar3.Year

        For i = 20 To 28
            Me.Calendar3.SetHighLightDay Calendar3.Year, Calendar3.Month, i, clrColor
        Next

        Me.Calendar3.Redraw
        
        
        'calendar 4
        clrColor = RGB(100, 255, 100)

        Me.Calendar4.Month = Me.Calendar4.Month
        Me.Calendar4.Year = Me.Calendar4.Year

        Me.Calendar4.DayTextFontSize = 8
        Me.Calendar4.SetText 1, "Anniversary"
        For i = 1 To 5
            Me.Calendar4.SetHighLightDay Calendar4.Year, Calendar4.Month, i, clrColor
        Next

        Me.Calendar4.Redraw


        'calendar 5
        clrColor = RGB(100, 155, 255)

        Me.Calendar5.Month = Me.Calendar5.Month
        Me.Calendar5.Year = Me.Calendar5.Year


        For i = 1 To 10 Step 2
            Me.Calendar5.SetHighLightDay Calendar5.Year, Calendar5.Month, i, clrColor
        Next

        Me.Calendar5.Redraw
        
         'calendar 6
        clrColor = RGB(200, 100, 255)

        Me.Calendar6.Month = Me.Calendar6.Month
        Me.Calendar6.Year = Me.Calendar6.Year


        For i = 1 To 30 Step 5
            Me.Calendar6.SetHighLightDay Calendar6.Year, Calendar6.Month, i, clrColor
        Next

        Me.Calendar6.Redraw

End Sub

Private Sub Form_Load()
 Calendar1.Month = 1
Calendar1.DayCaptionBackColor = RGB(0, 0, 0)
Calendar1.MonthYearForeColor = RGB(0, 0, 0)
Calendar1.DayTextColor = RGB(0, 0, 0)
 
 Calendar2.Month = 2
 Calendar2.DayCaptionBackColor = RGB(0, 0, 0)
Calendar2.MonthYearForeColor = RGB(0, 0, 0)
Calendar2.DayTextColor = RGB(0, 0, 0)

 Calendar3.Month = 3
 Calendar3.DayCaptionBackColor = RGB(0, 0, 0)
Calendar3.MonthYearForeColor = RGB(0, 0, 0)
Calendar3.DayTextColor = RGB(0, 0, 0)

 Calendar4.Month = 4
 Calendar4.DayCaptionBackColor = RGB(0, 0, 0)
Calendar4.MonthYearForeColor = RGB(0, 0, 0)
Calendar4.DayTextColor = RGB(0, 0, 0)

 Calendar5.Month = 5
 Calendar5.DayCaptionBackColor = RGB(0, 0, 0)
Calendar5.MonthYearForeColor = RGB(0, 0, 0)
Calendar5.DayTextColor = RGB(0, 0, 0)
 
 Calendar6.Month = 6
 Calendar6.DayCaptionBackColor = RGB(0, 0, 0)
Calendar6.MonthYearForeColor = RGB(0, 0, 0)
Calendar6.DayTextColor = RGB(0, 0, 0)
 
 
End Sub
