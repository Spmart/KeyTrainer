using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibForKeyTrainer; //Наша либа

namespace KeyTrainer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateGlossary(glossary); //Создаем словарь из файла
        }

        //Метод читает файл в массив строк
        private void CreateGlossary(string[] glossary)
        {
            try
            {
                StreamReader reader = new StreamReader("dictionary.txt", Encoding.GetEncoding("windows-1251"));
                for (int i = 0; i < 127; i++)
                {
                    glossary[i] = reader.ReadLine();
                }
                reader.Close();
            }
            catch (FileNotFoundException) //Если файл не найден
            {
                MessageBox.Show("Файл библиотеки dictionary.txt не найден!", "Ошибка!");
                Environment.Exit(0);
            }
        }

        //Метод возвращает новую строку из словаря
        private string ShowNewText(string[] glossary)
        {
            Random random = new Random();
            int numberOfLine = random.Next(0, 127);
            return glossary[numberOfLine];
        }

        //--Действия, которые должны совершиться в любом случае--//
        Stats stats = new Stats();
        private string[] glossary = new string[127];

        //--Обработчики событий--//

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Анна Мещерякова, ПО-41", "О программе");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Набирайте текст из верхнего поля в поле для в ввода. Если вы ошибаетесь, то неверно набранная буква не появляется в поле. По окончании ввода вы получите небольшой отчет.", "Справка");
        }

        private void btnShowNewText_Click(object sender, EventArgs e) //Кнопка выводит новый текст в верхний textbox
        {
            txtExample.Enabled = true;
            txtInput.Enabled = true;
            txtExample.Text = ShowNewText(glossary);
            txtInput.Clear(); //Очищаем поле для ввода
            stats.ClearStats(); //Очищаем счет
        }

        private void txtInput_TextChanged(object sender, EventArgs e) //Если текст в textbox'е ввода изменился
        {
            try
            {
                if (txtInput.Text == txtExample.Text & txtInput.TextLength != 0) //Если все правильно - чо сиськи мять? Поехали отсюда
                {
                    stats.IncTotal();
                    stats.IncCorrect();
                    MessageBox.Show("Всего введено: " + stats.GetTotal() + "\nВведено верно: " + stats.GetCorrect() + "\nОшибки: " + stats.GetMissed() + "\nАккуратность: " + stats.GetAccuracy() + "%", "Готово!");
                }
                //Таким образом я обращаюсь к одним и тем же по позиции эль-там обеих строк. По номеру последнего из строки ввода
                //Первое условие обязательно требует укороченного оператора. Иначе получите исключение при каждом нажатии на "Новый текст"
                else if (txtInput.TextLength != 0 && txtInput.Text[txtInput.TextLength - 1] != txtExample.Text[txtInput.TextLength - 1]) //Если юзверь ошибается со вводом
                {
                    txtInput.Text = txtInput.Text.Remove(txtInput.TextLength - 1); //Убираем введенный им символ
                    txtInput.SelectionStart = txtInput.Text.Length; //Устанавливаем курсор в конец textbox'a
                    stats.IncTotal();
                    stats.IncMissed();
                }
                else //Ну и если не ошибается, но не все готово
                {
                    stats.IncTotal();
                    stats.IncCorrect();
                }
            }
            catch (System.IndexOutOfRangeException) //Хер знает, почему вываливается. Обработаем и превратим в фичу.
            {
                MessageBox.Show("Ай-ай-ай! Ошибаетесь в самом начале", "Ошибка!");
            }
        }
    }
}
