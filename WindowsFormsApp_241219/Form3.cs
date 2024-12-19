using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_241219
{
    public partial class Form3 : Form
    {
        enum DayOfWeekEnum
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string inputText = textBox_input.Text.Trim();
                string resultMessage = GetDayMessage(inputText);

                textBox_result.Text = resultMessage;

                e.SuppressKeyPress = true;
            }
        }

        private string GetDayMessage(string day)
        {
            DayOfWeekEnum dayEnum;

            if (Enum.TryParse(day, true, out dayEnum))
            {
                switch (dayEnum)
                {
                    case DayOfWeekEnum.monday:
                        return "월요일입니다.";
                    case DayOfWeekEnum.tuesday:
                        return "화요일입니다.";
                    case DayOfWeekEnum.wednesday:
                        return "수요일입니다.";
                    case DayOfWeekEnum.thursday:
                        return "목요일입니다.";
                    case DayOfWeekEnum.friday:
                        return "금요일입니다.";
                    case DayOfWeekEnum.saturday:
                        return "토요일입니다.";
                    case DayOfWeekEnum.sunday:
                        return "일요일입니다.";
                    default:
                        return "잘못된 입력입니다. 요일을 입력하세요.";
                }
            }
            else
            {
                return "잘못된 입력입니다. 요일을 입력하세요.";
            }
        }
    }
}
