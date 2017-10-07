using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 3 Представьте, что у вас на форме есть прямоугольник, 
//границы которого на 10 пикселей отстоят от границ рабочей области формы.
//Необходимо создать следующие обработчики:

//■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, 
//где находится текущая точка: вну- три прямоугольника, снаружи, на границе прямоугольника.
//Домашнее задание №1 Домашнее задание № Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl),
//то приложение должно закрываться; 

//■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию
// о размере клиентской(рабочей) области окна в виде: Ширина = x, Высота = y,
// где x и y – соответствующие параметры вашего окна; 

//■ Обработчик перемещения указателя мыши в пределах рабочей области,
//который должен выводить в заголовок окна текущие координаты мыши x и y

namespace Task
{
    public partial class Task : Form
    {
        private int otstup = 20;
        private int borderX = 17;
        private int borderY = 40;
        public Task()
        {
            InitializeComponent();
        }

        private void Task_MouseClick(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                Close();
            }

            if ( e.Location.X < otstup || e.Location.X > this.Size.Width - otstup - borderX ||
                 e.Location.Y < otstup || e.Location.Y > this.Size.Height - otstup - borderY )
            {
                infoLabel.Text = "Снаружи прямоугольника";
            }
            else if(e.Location.X == otstup || e.Location.X == this.Size.Width - otstup - borderX ||
                    e.Location.Y == otstup || e.Location.Y == this.Size.Height - otstup - borderY)
            {
                infoLabel.Text = "На границе прямоугольника";
            }
            else
            {
                infoLabel.Text = "Внутри прямоугольника";
            }
        }

        private void Task1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
            widthLabel.Text = "Ширина = " + this.Size.Width.ToString();
            HeghtLabel.Text = "Высота = " + this.Size.Height.ToString();
        }
    }
}
