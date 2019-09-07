using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Индекс_массы_тела__ИМТ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        // Виды ИМТ


        // Дефицит массы тела
        private string Deficit()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "Дефицит массы тела";
            }
            else
            {
                return "Body Weight Deficit";
            }
        }

        // Нормальный вес

        private string Normal()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "Нормальный вес";
            }
            else
            {
                return "Normal Weight";
            }
        }

        // Избыточный вес

        private string Overweight()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "Избыточный вес";
            }
            else
            {
                return "Overweight";
            }

        }

        // Ожирение

        private string Obesity()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "Ожирение";
            }
            else
            {
                return "Obesity";
            }

        }

        // Сильное ожирение

        private string SevereObesity()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "Сильное ожирение";
            }
            else
            {
                return "Severe Obesity";
            }

        }

        // Возраст

        // Меньше 18

        private String To18()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ детей не поддаётся точным расчётам";
            }
            else
            {
                return "Children's BMI cannot be accurately calculated";
            }
        }

        // От 18 до 24 лет

        private String to18_24_plus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ оптимален для вашего возраста";
            }
            else
            {
                return "BMI is optimal for your age";
            }
        }

        private String to18_24_minus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ не оптимален для вашего возраста";
            }
            else
            {
                return "BMI is not optimal for your age";
            }
        }

        // От 25 до 34 лет

        private String to25_34_plus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ оптимален для вашего возраста";
            }
            else
            {
                return "BMI is optimal for your age";
            }
        }

        private String to25_34_minus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ не оптимален для вашего возраста";
            }
            else
            {
                return "BMI is not optimal for your age";
            }
        }

        // От 35 до 44 лет

        private String to35_44_plus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ оптимален для вашего возраста";
            }
            else
            {
                return "BMI is optimal for your age";
            }
        }

        private String to35_44_minus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ не оптимален для вашего возраста";
            }
            else
            {
                return "BMI is not optimal for your age";
            }
        }

        // От 45 до 54 лет

        private String to45_54_plus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ оптимален для вашего возраста";
            }
            else
            {
                return "BMI is optimal for your age";
            }
        }

        private String to45_54_minus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ не оптимален для вашего возраста";
            }
            else
            {
                return "BMI is not optimal for your age";
            }
        }

        // От 55 до 64 лет

        private String to55_64_plus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ оптимален для вашего возраста";
            }
            else
            {
                return "BMI is optimal for your age";
            }
        }

        private String to55_64_minus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ не оптимален для вашего возраста";
            }
            else
            {
                return "BMI is not optimal for your age";
            }
        }

        // Старше 65

        private String over65_plus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ оптимален для вашего возраста";
            }
            else
            {
                return "BMI is optimal for your age";
            }
        }

        private String over65_minus()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return "ИМТ не оптимален для вашего возраста";
            }
            else
            {
                return "BMI is not optimal for your age";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var height = numericUpDown1.Value / 100;
            var weight = numericUpDown2.Value;
            var imt = Convert.ToDouble(weight / (height * height));
            var age = numericUpDown3.Value;
            label3.Text = imt.ToString("F");

            // Пол
            label4.Text = checkBySex(imt);

            // Возраст
            label6.Text = checkByAge(imt, age);

        }

        private String checkBySex(double imt)
        {
            return radioButton1.Checked ? checkMale(imt) : checkFemale(imt);
        }

        private String checkMale(double imt)
        {
            if (imt < 20)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.male_light;
                return Deficit();
            }

            else if (imt >= 20 && imt <= 25)
            {
                label4.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.male_normal;
                return Normal();
            }

            else if (imt > 26 && imt <= 30)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.male_fat;
                return Overweight ();
            }

            else if (imt >= 31 && imt <= 40)
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.male_more_fat;
                return Obesity();

            }

            else
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.male_very_fat;
                return SevereObesity();
            }
        }

        private String checkFemale(double imt)
        {
            if (imt < 19)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.female_light;
                return Deficit();
            }

            else if (imt >= 19 && imt <= 24)
            {
                label4.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.female_normal;
                return Normal();
            }

            else if (imt > 25 && imt <= 30)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.female_fat;
                return Overweight();
            }

            else if (imt >= 31 && imt <= 40)
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.female_more_fat;
                return Obesity();
            }

            else
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.female_very_fat;
                return SevereObesity();
            }
        }




        private String checkByAge(double imt, decimal age)
        {
            // Меньше 18

            if (age < 18)
            {
                pictureBox1.Image = Properties.Resources.children;

                return To18();

            }
            // От 18 до 24 лет

            else if (age >= 18 && age <= 24)
            {

                if (imt >= 18 && imt <= 24)
                {
                    return to18_24_plus();

                }

                else
                {
                    return to18_24_minus();
                }
            }

            // От 25 до 34 лет

            else if (age >= 25 && age <= 34)
            {
                if (imt >= 20 && imt <= 25)
                {
                    return to25_34_plus();
                }

                else
                {
                    return to25_34_minus();
                }
            }

            // От 35 до 44 лет

            else if (age >= 35 && age <= 44)
            {
                if (imt >= 21 && imt <= 26)
                {
                    return to35_44_plus();
                }

                else
                {
                    return to35_44_minus();
                }
            }

            // От 45 до 54 лет

            else if (age >= 45 && age <= 54)
            {
                if (imt >= 22 && imt <= 27)
                {
                    return to45_54_plus();
                }

                else
                {
                    return to45_54_minus();
                }
            }


            // От 55 до 64 лет

            else if (age >= 55 && age <= 64)
            {
                if (imt >= 23 && imt <= 28)
                {
                    return to55_64_plus();
                }

                else
                {
                    return to55_64_minus();
                }
            }

            // Старше 65

            else
            {
                if (imt >= 24 && imt <= 29)
                {
                    return over65_plus();
                }

                else
                {
                    return over65_minus();
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label7.Text = "Рассчитайте свой ИМТ прямо здесь! *";
                groupBox4.Text = "Ваш пол";
                radioButton1.Text = "Мужской";
                radioButton2.Text = "Женский";
                groupBox5.Text = "Возраст";
                label5.Text = "лет";
                groupBox1.Text = "рост";
                label1.Text = "см";
                groupBox2.Text = "Вес";
                label2.Text = "кг";
                button1.Text = "Рассчитать";
                label10.Text = "Язык / Language";
                label9.Text = "* ИМТ детей не поддаётся точному расчёту";
                groupBox3.Text = "Ваш ИМТ";
                label8.Text = "Автор: Сергей Назаров";
            }
            else
            {
                label7.Text = "Calculate your BMI right now! *";
                groupBox4.Text = "Your sex";
                radioButton1.Text = "Male";
                radioButton2.Text = "Female";
                groupBox5.Text = "Age";
                label5.Text = "y.o.";
                groupBox1.Text = "Height";
                label1.Text = "cm";
                groupBox2.Text = "Weight";
                label2.Text = "kg";
                button1.Text = "Calculate";
                label10.Text = "Язык / Language";
                label9.Text = "* Children's BMI cannot be accurately calculated";
                groupBox3.Text = "Your BMI";
                label8.Text = "Author: Sergey Nazarov";
            }
        }
    }
}