﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241219
{
    public partial class Form1 : Form
    {
        bool input;
        
        public Form1()
        {
            InitializeComponent();

            bool userInput = true;
        }

        public bool PlayGame(bool userInput)
        {
            Random random = new Random();
            int coinTossResult = random.Next(2);
            bool randomBool = (coinTossResult == 1);
            return userInput == randomBool;

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            // 입력 텍스트를 가져옴
            string input = textBox_input.Text.Trim();
            bool userInput;

            // textBox_input 값을 우선적으로 처리
            if (!string.IsNullOrEmpty(input))
            {
                if (bool.TryParse(input, out userInput))  // 입력값이 true/false인지 확인
                {
                    ProcessInput(userInput);
                }
                else
                {
                    textBox_result.Text = "true 또는 false를 입력해주세요.";
                }
            }
            else
            {
                textBox_result.Text = "입력값 또는 true/false를 선택해주세요.";
            }
        }

        private void radioButton_true_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "true";
            ProcessInput(true);
        }

        private void radioButton_false_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "false";
            ProcessInput(false);
        }

        private void ProcessInput(bool userInput)
        {
            if (PlayGame(userInput))
            {
                textBox_result.Text = "승리";
            }
            else
            {
                textBox_result.Text = "패배";
            }
        }
    }
}
