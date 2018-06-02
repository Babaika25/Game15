using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game15
{
    public partial class FormGame15 : Form
    {
        Game game;
        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_game();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16 (((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.check_numbers())
            {
                MessageBox.Show("Вы победили!", "Поздравление");
                start_game();
            }

            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private Button button (int posicion)
        {
            switch (posicion)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }

        private void Menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game()
        {  
            game.start();
            for (int j = 0; j < 100; j++)
                game.shift_random();
            refresh();
        }

        private void refresh ()
        {
            for (int posicion = 0; posicion < 16; posicion++)
            {
                int nr = game.get_number(posicion);
                button(posicion).Text = nr.ToString();
                button(posicion).Visible = (nr > 0);
            }
        }

        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра в 15, пятнашки, такен — популярная головоломка, придуманная в 1878 году Ноем Чепмэном. Представляет собой набор одинаковых квадратных костяшек с нанесёнными числами, заключённых в квадратную коробку. Длина стороны коробки в четыре раза больше длины стороны костяшек для набора из 15 элементов, соответственно в коробке остаётся незаполненным одно квадратное поле. Цель игры — перемещая костяшки по коробке, добиться упорядочивания их по номерам, желательно сделав как можно меньше перемещений.", "Об игре");
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа написана специально для выставки проектов студентов, аспирантов и молодых учёных. \n\nМИИГАиК 2018 год", "Линьков Валерий Владимирович ИБ I-1б");
        }
    }
}
