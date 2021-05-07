using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);

            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  i;
            Color clrColor;

        clrColor = Color.FromArgb(128, 255, 255);
        axCalendar1.Month = axCalendar1.Month;
        axCalendar1.Year = axCalendar1.Year;

        axCalendar1.SetText(1, "New Year");

        for ( i = 1; i<=10;i++)
         {
            axCalendar1.DayTextColor = System.Drawing.Color.Red;
      
           axCalendar1.SetHighLightDay(axCalendar1.Year, axCalendar1.Month, (short)i, Color2Uint32(clrColor));
            }
       axCalendar1.Redraw();


        //calendar 2
        clrColor = Color.FromArgb(255, 128, 100);
          
       axCalendar2.Month = axCalendar2.Month;
       axCalendar2.Year =axCalendar2.Year;

        for(i= 10; i<=15;i++)
            axCalendar2.SetHighLightDay(axCalendar2.Year, axCalendar2.Month, (short)i, Color2Uint32(clrColor));
      

       axCalendar2.Redraw();

        //calendar 3
        clrColor = Color.FromArgb(200, 50, 100);

        axCalendar3.Month = axCalendar3.Month;
        axCalendar3.Year = axCalendar3.Year;

       for( i = 20; i<=28 ;i++)
            axCalendar3.SetHighLightDay(axCalendar3.Year, axCalendar3.Month, (short)i, Color2Uint32(clrColor));
       

       axCalendar3.Redraw();

        //calendar 4
        clrColor = Color.FromArgb(100, 255, 100);

        axCalendar4.Month = axCalendar4.Month;
        axCalendar4.Year = axCalendar4.Year;


        axCalendar4.DayTextFontSize = 8;
        axCalendar4.SetText(1, "Anniversary");
        for(i = 1; i<=5; i++) 
            axCalendar4.SetHighLightDay(axCalendar4.Year, axCalendar4.Month, (short)i, Color2Uint32(clrColor));

        axCalendar4.Redraw();

        //calendar 5
        clrColor = Color.FromArgb(100, 155, 255);

        axCalendar5.Month = axCalendar5.Month;
        axCalendar5.Year = axCalendar5.Year;


        for(i = 1; i<=10; i=i+2)
            axCalendar5.SetHighLightDay(axCalendar5.Year, axCalendar5.Month, (short)i, Color2Uint32(clrColor));
        

        axCalendar5.Redraw();

        //calendar 6
        clrColor = Color.FromArgb(200, 100, 255);

        axCalendar6.Month =axCalendar6.Month;
        axCalendar6.Year = axCalendar6.Year;


        for(i = 1; i<=30; i=i+5)
           axCalendar6.SetHighLightDay(axCalendar6.Year, axCalendar6.Month, (short)i, Color2Uint32(clrColor));
        
            axCalendar6.Redraw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              axCalendar1.Month = 1;
              axCalendar2.Month = 2;
              axCalendar3.Month = 3;
              axCalendar4.Month = 4;
              axCalendar5.Month = 5;
              axCalendar6.Month = 6;

        }
    }
}
