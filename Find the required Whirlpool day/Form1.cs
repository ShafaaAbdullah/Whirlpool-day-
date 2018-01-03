using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Find_the_required_Whirlpool_day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day, requiredday, jump;
            day = int.Parse(textBox1.Text);
            requiredday = int.Parse(textBox3.Text);
            jump = int.Parse(textBox2.Text);

            String[] weekDays = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            String[] WeekDays = { "0", "1", "2", "3", "4", "5", "6" };
            int days = 0;
            int Buffer = 0;
            int requirday = 0;
            string daystr = null;

            int a = day;
            Buffer = requiredday - 1;
            days = (requiredday) * jump;

            ///اذا كان الخفارة الطلوبة اقل من الخفارة الخامسة //
            if (requiredday < 5)
            {
                //بعدد الايام من اول يوم خفارة الى يوم الخفارة المطلوب(daynamic)هذه الفقرة نكون مصفوفة //
                for (int j = 0; j < days; j++)
                {
                    daystr += WeekDays[a];
                    a++;
                    if (a > 6)
                        a = 0;
                }
                //اذا ادخل المستخدم يوم الخفارة الاول مباشرة ياخذ اول موقع في المصفوفة//
                if (requiredday == 1)
                {
                    requirday = daystr[0];

                    label1.Text = Convert.ToString(Convert.ToChar(requirday));

                }
                //اذا كان يوم رقم الخفارة اقل من الخفارة الخامسة//
                else
                    if (requiredday > 1)
                    {
                        //جلب موقع يوم الخفارة المطلوب تحديدآ//
                        requirday = daystr[(Buffer * jump) + Buffer];
                        label1.Text = Convert.ToString(Convert.ToChar(requirday));

                    }
                textBox4.Text = daystr;
            }
            //اذا كان الخفارة الطلوبة اكبر من الخفارة الخامسة //
            int temp = 0;
            if (requiredday >= 5)
            {
                //عمل هذ الفور هو يزيد ايام اضافية للمصفوفة حتى نستطيع الوصول الى اليوم المطلوب ضمن حدود المصفوفة//
                for (int w = 1; w <= days; w++)
                    temp = days + w;
                //بعدد الايام من اول يوم خفارة الى يوم الخفارة المطلوب(daynamic)هذه الفقرة نكون مصفوفة //
                for (int j = 0; j < temp; j++)
                {
                    daystr += WeekDays[a];
                    a++;
                    if (a > 6)
                        a = 0;
                }

                if (requiredday > 1 && Buffer > 1)
                {
                    requirday = daystr[(Buffer * jump) + Buffer];
                    label1.Text = Convert.ToString(Convert.ToChar(requirday));
                }
                textBox4.Text = daystr;
            }
        }
    }
}
