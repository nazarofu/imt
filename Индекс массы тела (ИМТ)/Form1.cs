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
                return "Дефицит массы тела";
            }

            else if (imt >= 20 && imt <= 25)
            {
                label4.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.male_normal;
                return "Нормальный вес";
            }

            else if (imt > 26 && imt <= 30)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.male_fat;
                return "Избыточный вес";
            }

            else if (imt >= 31 && imt <= 40)
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.male_more_fat;
                return "Ожирение";
            }

            else
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.male_very_fat;
                return "Сильное ожирение";
            }
        }

        private String checkFemale(double imt)
        {
            if (imt < 19)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.female_light;
                return "Дефицит массы тела";
            }

            else if (imt >= 19 && imt <= 24)
            {
                label4.ForeColor = Color.Green;
                pictureBox1.Image = Properties.Resources.female_normal;
                return "Нормальный вес";
            }

            else if (imt > 25 && imt <= 30)
            {
                label4.ForeColor = Color.DarkGoldenrod;
                pictureBox1.Image = Properties.Resources.female_fat;
                return "Избыточный вес";
            }

            else if (imt >= 31 && imt <= 40)
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.female_more_fat;
                return "Ожирение";
            }

            else
            {
                label4.ForeColor = Color.Red;
                pictureBox1.Image = Properties.Resources.female_very_fat;
                return "Сильное ожирение";
            }
        }

        private String checkByAge(double imt, decimal age)
        {
            // Меньше 18

            if (age < 18)
            {
                pictureBox1.Image = Properties.Resources.children;
                return "ИМТ детей не поддаётся точным рассчётам";
            }
            // От 18 до 24 лет
            else if (age >= 18 && age <= 24)
            {

                if (imt >= 18 && imt <= 24)
                {
                    return "ИМТ оптимален для вашего возраста";
                }

                else
                {
                    return "ИМТ не оптимален для вашего возраста";
                }
            }

            // От 25 до 34 лет

            else if (age >= 25 && age <= 34)
            {
                if (imt >= 20 && imt <= 25)
                {
                    return "ИМТ оптимален для вашего возраста";
                }

                else
                {
                    return "ИМТ не оптимален для вашего возраста";
                }
            }

            // От 35 до 44 лет

            else if (age >= 35 && age <= 44)
            {
                if (imt >= 21 && imt <= 26)
                {
                    return "ИМТ оптимален для вашего возраста";
                }

                else
                {
                    return "ИМТ не оптимален для вашего возраста";
                }
            }

            // От 45 до 54 лет

            else if (age >= 45 && age <= 54)
            {
                if (imt >= 22 && imt <= 27)
                {
                    return "ИМТ оптимален для вашего возраста";
                }

                else
                {
                    return "ИМТ не оптимален для вашего возраста";
                }
            }


            // От 55 до 64 лет

            else if (age >= 55 && age <= 64)
            {
                if (imt >= 23 && imt <= 28)
                {
                    return "ИМТ оптимален для вашего возраста";
                }

                else
                {
                    return "ИМТ не оптимален для вашего возраста";
                }
            }

            // Старше 65

            else
            {
                if (imt >= 24 && imt <= 29)
                {
                    return "ИМТ оптимален для вашего возраста";
                }

                else
                {
                    return "ИМТ не оптимален для вашего возраста";
                }
            }
        }
    }
}