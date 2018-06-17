using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hook;

namespace GlobalHookKeys
{
    public partial class Form1 : Form
    {
        // Иницализация
        globalKeyboardHook key = new globalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
            // Добавление кнопок для хука
            key.HookedKeys.Add(Keys.A);

            // Создание событий нажатия
            key.KeyDown += new KeyEventHandler(key_KeyDown);
            key.KeyUp += new KeyEventHandler(key_KeyUp);
        }

        void key_KeyDown(object sender, KeyEventArgs e)
        {
            // Логика здесь
            string a = "KeyDown " + e.KeyCode.ToString() + '\n';
            textBox1.AppendText(a);
        }

        void key_KeyUp(object sender, KeyEventArgs e)
        {
            // Логика здесь
            string a = "KeyUp " + e.KeyCode.ToString() + '\n';
            textBox1.AppendText(a);
        }
    }
}
