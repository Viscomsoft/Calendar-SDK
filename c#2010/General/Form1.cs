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

        private void Form1_Load(object sender, EventArgs e)
        {
             cboUnicodeLang.Items.Add("English");
        cboUnicodeLang.Items.Add("German");
        cboUnicodeLang.Items.Add("Chinese");
        cboUnicodeLang.SelectedIndex = 0;

        txtgoyear.Text = axCalendar1.Year.ToString();
        txtgomonth.Text =axCalendar1.Month.ToString();

        txtYear.Text = axCalendar1.Year.ToString();
        txtMonth.Text = axCalendar1.Month.ToString();

        txtyearrange.Text =axCalendar1.Year.ToString();
        txtmonthrange.Text = axCalendar1.Month.ToString();

        cbofont.Items.Add("Arial");
        cbofont.Items.Add("Arial Black");
        cbofont.Items.Add("Courier New");
        cbofont.Items.Add("MS Sans Serif");
        cbofont.Items.Add("Tahoma");
        cbofont.Items.Add("Times New Roman");
        cbofont.SelectedIndex = 0;

        cbodaycaption.Items.Add("Arial");
        cbodaycaption.Items.Add("Arial Black");
        cbodaycaption.Items.Add("Courier New");
        cbodaycaption.Items.Add("MS Sans Serif");
        cbodaycaption.Items.Add("Tahoma");
        cbodaycaption.Items.Add("Times New Roman");
        cbodaycaption.SelectedIndex = 0;

        cbodayfont.Items.Add("Arial");
        cbodayfont.Items.Add("Arial Black");
        cbodayfont.Items.Add("Courier New");
        cbodayfont.Items.Add("MS Sans Serif");
        cbodayfont.Items.Add("Tahoma");
        cbodayfont.Items.Add("Times New Roman");
        cbodayfont.SelectedIndex = 0;


        cbodaytextfont.Items.Add("Arial");
        cbodaytextfont.Items.Add("Arial Black");
        cbodaytextfont.Items.Add("Courier New");
        cbodaytextfont.Items.Add("MS Sans Serif");
        cbodaytextfont.Items.Add("Tahoma");
        cbodaytextfont.Items.Add("Times New Roman");
        cbodaytextfont.SelectedIndex = 0;

        cbotextsize.Items.Add("8");
        cbotextsize.Items.Add("10");
        cbotextsize.Items.Add("12");
        cbotextsize.Items.Add("14");
        cbotextsize.Items.Add("16");
        cbotextsize.Items.Add("18");
        cbotextsize.SelectedIndex = 0;
        }

        private void cmdgo_Click(object sender, EventArgs e)
        {
              axCalendar1.Month = Int16.Parse(txtgomonth.Text);
              axCalendar1.Year = Int16.Parse(txtgoyear.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            axCalendar1.Day = Int16.Parse(txtsetday.Text);
        }

        public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);

            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

        private void Command5_Click(object sender, EventArgs e)
        {
                ColorDialog1.ShowDialog();

                axCalendar1.SetHighLightDay(Int16.Parse(txtYear.Text), Int16.Parse(txtMonth.Text), Int16.Parse(txtDay.Text), Color2Uint32(ColorDialog1.Color));
  
        }

        private void Command6_Click(object sender, EventArgs e)
        {
            if (cboUnicodeLang.SelectedIndex == 0)
                axCalendar1.SetText(Int16.Parse(txtdayno.Text), txtdaytext.Text);
            else
            {
                string strText = txtdaytext.Text;
                axCalendar1.SetUnicodeText(Int16.Parse(txtdayno.Text), ref strText);
            }

        }

        private void axCalendar1_OnDayClick(object sender, AxCALENDARLib._DCalendarEvents_OnDayClickEvent e)
        {
              txtCurrentDay.Text =e.iDay.ToString();
              Text3.Text = e.strText;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            axCalendar1.PrintCalendar();

        }

        private void chkswapmonthyear_CheckedChanged(object sender, EventArgs e)
        {
            if(chkswapmonthyear.Checked)
                axCalendar1.MonthYearSwap = true;
            else
                axCalendar1.MonthYearSwap = false;

        
        }

        private void cbofont_SelectedIndexChanged(object sender, EventArgs e)
        {
            axCalendar1.MonthYearFont = cbofont.Text;
        }

        private void cmdmonthyearbackcolor_Click(object sender, EventArgs e)
        {
               ColorDialog1.ShowDialog();
               axCalendar1.MonthYearBackColor = ColorDialog1.Color;

        }

        private void cmdmonthyearforecolor_Click(object sender, EventArgs e)
        {
             ColorDialog1.ShowDialog();

             axCalendar1.MonthYearForeColor = ColorDialog1.Color;
        }

        private void cboUnicodeLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strMonth1;
            string strMonth2;
            string strMonth3;
            string strMonth4;
            string strMonth5;
            string strMonth6;
            string strMonth7;
            string strMonth8;
            string strMonth9;
            string strMonth10;
            string strMonth11;
            string strMonth12;

            string strDay1;
            string strDay2;
            string strDay3;
            string strDay4;
            string strDay5;
            string strDay6;
            string strDay7;




            if(cboUnicodeLang.SelectedIndex == 0)
            {
            axCalendar1.SetMonthCaptions(0, "January");
            axCalendar1.SetMonthCaptions(1, "February");
            axCalendar1.SetMonthCaptions(2, "March");
            axCalendar1.SetMonthCaptions(3, "April");
            axCalendar1.SetMonthCaptions(4, "May");
            axCalendar1.SetMonthCaptions(5, "June");
            axCalendar1.SetMonthCaptions(6, "July");
            axCalendar1.SetMonthCaptions(7, "August");
            axCalendar1.SetMonthCaptions(8, "September");
            axCalendar1.SetMonthCaptions(9, "October");
            axCalendar1.SetMonthCaptions(10, "November");
            axCalendar1.SetMonthCaptions(11, "December");

            axCalendar1.SetDayCaptions(0, "Sunday");
            axCalendar1.SetDayCaptions(1, "Monday");
            axCalendar1.SetDayCaptions(2, "Tuesday");
            axCalendar1.SetDayCaptions(3, "Wednesday");
            axCalendar1.SetDayCaptions(4, "Thursday");
            axCalendar1.SetDayCaptions(5, "Friday");
            axCalendar1.SetDayCaptions(6, "Saturday");
            }
            else if(cboUnicodeLang.SelectedIndex ==1)
            {
                strMonth1 = "Januar";
                strMonth2 = "Februar";
                strMonth3 = "März";
                strMonth4 = "April";
                strMonth5 = "Mai";
                strMonth6 = "Juni";
                strMonth7 = "Juli";
                strMonth8 = "August";
                strMonth9 = "September";
                strMonth10 = "Oktober";
                strMonth11 = "November";
                strMonth12 = "Dezember";


            axCalendar1.SetUnicodeMonthCaptions(0, ref strMonth1);
            axCalendar1.SetUnicodeMonthCaptions(1, ref strMonth2);
            axCalendar1.SetUnicodeMonthCaptions(2, ref strMonth3);
            axCalendar1.SetUnicodeMonthCaptions(3, ref strMonth4);
            axCalendar1.SetUnicodeMonthCaptions(4, ref strMonth5);
            axCalendar1.SetUnicodeMonthCaptions(5, ref strMonth6);
            axCalendar1.SetUnicodeMonthCaptions(6, ref strMonth7);
            axCalendar1.SetUnicodeMonthCaptions(7, ref strMonth8);
            axCalendar1.SetUnicodeMonthCaptions(8, ref strMonth9);
            axCalendar1.SetUnicodeMonthCaptions(9, ref strMonth10);
            axCalendar1.SetUnicodeMonthCaptions(10, ref strMonth11);
            axCalendar1.SetUnicodeMonthCaptions(11, ref strMonth12);

            strDay1 = "Sonntag";
            strDay2 = "Montag";
            strDay3 = "Dienstag";
            strDay4 = "Mittwoch";
            strDay5 = "Donnerstag";
            strDay6 = "Freitag";
            strDay7 = "Samstag";


            axCalendar1.SetUnicodeDayCaptions(0, ref strDay1);
            axCalendar1.SetUnicodeDayCaptions(1, ref strDay2);
            axCalendar1.SetUnicodeDayCaptions(2, ref strDay3);
            axCalendar1.SetUnicodeDayCaptions(3, ref strDay4);
            axCalendar1.SetUnicodeDayCaptions(4, ref strDay5);
            axCalendar1.SetUnicodeDayCaptions(5, ref strDay6);
            axCalendar1.SetUnicodeDayCaptions(6, ref strDay7);
            }
        else if (cboUnicodeLang.SelectedIndex == 2)
            {
                strMonth1 = "一月";
                strMonth2 = "二月";
                strMonth3 = "三月";
                strMonth4 = "四月";
                strMonth5 = "五月";
                strMonth6 = "六月";
                strMonth7 = "七月";
                strMonth8 = "八月";
                strMonth9 = "九月";
                strMonth10 = "十月";
                strMonth11 = "十一月";
                strMonth12 = "十二月";

                axCalendar1.SetUnicodeMonthCaptions(0, ref strMonth1);
                axCalendar1.SetUnicodeMonthCaptions(1, ref strMonth2);
                axCalendar1.SetUnicodeMonthCaptions(2, ref strMonth3);
                axCalendar1.SetUnicodeMonthCaptions(3, ref strMonth4);
                axCalendar1.SetUnicodeMonthCaptions(4, ref strMonth5);
                axCalendar1.SetUnicodeMonthCaptions(5, ref strMonth6);
                axCalendar1.SetUnicodeMonthCaptions(6, ref strMonth7);
                axCalendar1.SetUnicodeMonthCaptions(7, ref strMonth8);
                axCalendar1.SetUnicodeMonthCaptions(8, ref strMonth9);
                axCalendar1.SetUnicodeMonthCaptions(9, ref strMonth10);
                axCalendar1.SetUnicodeMonthCaptions(10, ref strMonth11);
                axCalendar1.SetUnicodeMonthCaptions(11, ref strMonth12);

                strDay1 = "星期日";
                strDay2 = "星期一";
                strDay3 = "星期二";
                strDay4 = "星期三";
                strDay5 = "星期四";
                strDay6 = "星期五";
                strDay7 = "星期六";

                axCalendar1.SetUnicodeDayCaptions(0, ref strDay1);
                axCalendar1.SetUnicodeDayCaptions(1, ref strDay2);
                axCalendar1.SetUnicodeDayCaptions(2, ref strDay3);
                axCalendar1.SetUnicodeDayCaptions(3, ref strDay4);
                axCalendar1.SetUnicodeDayCaptions(4, ref strDay5);
                axCalendar1.SetUnicodeDayCaptions(5, ref strDay6);
                axCalendar1.SetUnicodeDayCaptions(6, ref strDay7);
        }

        }

        private void cmdchangedaycap_Click(object sender, EventArgs e)
        {
                axCalendar1.SetDayCaptions(0, txtdaycaption0.Text);
                axCalendar1.SetDayCaptions(1, txtdaycaption1.Text);
                axCalendar1.SetDayCaptions(2, txtdaycaption2.Text);
                axCalendar1.SetDayCaptions(3, txtdaycaption3.Text);
                axCalendar1.SetDayCaptions(4, txtdaycaption4.Text);
                axCalendar1.SetDayCaptions(5, txtdaycaption5.Text);
                axCalendar1.SetDayCaptions(6, txtdaycaption6.Text);


        }

        private void cbodaytextfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            axCalendar1.DayTextFont = cbodaytextfont.Text;
        }

        private void cbotextsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            axCalendar1.DayTextFontSize = Int16.Parse(cbotextsize.Text);

        }

        private void Command4_Click(object sender, EventArgs e)
        {
            ColorDialog1.ShowDialog();

            axCalendar1.DayTextColor = ColorDialog1.Color;
        }

        private void cbodayfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            axCalendar1.DayFont = cbodayfont.Text;
        }

        private void Command3_Click(object sender, EventArgs e)
        {
              ColorDialog1.ShowDialog();

              axCalendar1.DayColor = ColorDialog1.Color;
        }

        private void cmdhighrange_Click(object sender, EventArgs e)
        {
            int i;
             Color clrColor;
        clrColor = Color.FromArgb(128, 128, 128);
        axCalendar1.Month = Int16.Parse( txtmonthrange.Text);
        axCalendar1.Year = Int16.Parse(txtyearrange.Text);

        for(i = Int16.Parse(txtselfrom.Text) ; i< Int16.Parse(txtselto.Text);i++)
        {
            axCalendar1.SetText((short)i, i.ToString());
            axCalendar1.DayTextColor = System.Drawing.Color.Red;
            axCalendar1.SetHighLightDay((short)axCalendar1.Year, (short)axCalendar1.Month, (short)i, Color2Uint32(clrColor));
        }


            axCalendar1.Redraw();
        }

        private void cmdclearhighrange_Click(object sender, EventArgs e)
        {
            int i;
            Color clrColor;
            clrColor = Color.FromArgb(255, 255, 255);
            axCalendar1.Month = Int16.Parse(txtmonthrange.Text);
            axCalendar1.Year = Int16.Parse(txtyearrange.Text);

            for (i = Int16.Parse(txtselfrom.Text); i < Int16.Parse(txtselto.Text); i++)
            {
                axCalendar1.SetText((short)i,"");
                axCalendar1.DayTextColor = System.Drawing.Color.Red;
                axCalendar1.SetHighLightDay((short)axCalendar1.Year, (short)axCalendar1.Month, (short)i, Color2Uint32(clrColor));
            }


            axCalendar1.Redraw();
        }

        private void cbodaycaption_SelectedIndexChanged(object sender, EventArgs e)
        {
            axCalendar1.DayCaptionFont = cbodaycaption.Text;

        }

        private void Command1_Click(object sender, EventArgs e)
        {
              ColorDialog1.ShowDialog();
              axCalendar1.DayCaptionBackColor = ColorDialog1.Color;
        }

        private void Command2_Click(object sender, EventArgs e)
        {
              ColorDialog1.ShowDialog();

              axCalendar1.DayCaptionForeColor = ColorDialog1.Color;
        }
    }
}
