using PR06;
using System;
using System.IO;
using System.Windows.Forms;

namespace PR07
{
    public partial class Form1 : Form
    {
        string pathToEncrypt { get; set; }
        string pathToDecrypt { get; set; }
        string[] filesToEncrypt { get; set; }
        string[] filesToDecrypt { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void fileChoiceBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            fileForEncryptionPathTextBox.Text = dialog.SelectedPath;
            filesToEncrypt = Directory.GetFiles(dialog.SelectedPath);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (firstPartOfKey.Enabled == false || secondPartOfKey.Enabled == false)
            {
                RSA.GetPartOfKeys(3, 100);

                // Высчитываем открытый ключ e
                RSA.Calculate_e();
                // Высчитываем закрытый ключ d
                RSA.Calculate_d();
            }
            else
            {
                // Получаем простые числа в диапозоне от 2 до 100 (Получаем произведение и функцию Эйлера для чисел)
                ulong p = Convert.ToUInt64(firstPartOfKey.Value);
                ulong q = Convert.ToUInt32(secondPartOfKey.Value);

                RSA.SetPartOfKeys(p, q); // Пример открытых ключей: 17 11

                // Высчитываем открытый ключ e
                RSA.Calculate_e();
                // Высчитываем закрытый ключ d
                RSA.Calculate_d();
            }

            foreach (string item in filesToEncrypt)
            {
                if (firstPartOfKey.Enabled == false || secondPartOfKey.Enabled == false)
                {
                    if (!File.Exists(item))
                    {
                        MessageBox.Show("Некорретко указан файл для шифрования!" + "\n(Выбранный файл не существует)",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }

                    // Получаем байты файла с размером блока в 64
                    byte[] bytesOfFile = RSA.CovertBytesToRSA(File.ReadAllBytes(item));

                    // Производим шифрование файла
                    RSA.EncryptMessage(bytesOfFile, item);

                    if (RSA.n != 0)
                    {
                        string str = "Шифрование успешно завершено!\nКлючи:\t" + RSA.p + "\t" + RSA.q;
                        MessageBox.Show(str,
                                    "Внимание!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (!File.Exists(item))
                    {
                        MessageBox.Show("Некорретко указан файл для шифрования!" + "\n(Выбранный файл не существует)",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }

                    // Получаем байты файла с размером блока в 64
                    byte[] bytesOfFile = RSA.CovertBytesToRSA(File.ReadAllBytes(item));

                    // Производим шифрование файла
                    RSA.EncryptMessage(bytesOfFile, item);

                    if (RSA.n != 0)
                    {
                        string str = "Шифрование успешно завершено!\nКлючи" + RSA.p + RSA.q;
                        MessageBox.Show(str,
                                    "Внимание!",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            firstPartOfKey.Enabled = !firstPartOfKey.Enabled;
            secondPartOfKey.Enabled = !secondPartOfKey.Enabled;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in filesToDecrypt)
            {
                if (firstPartOfKey.Enabled == false && secondPartOfKey.Enabled == false)
                {
                    // Проверка на корректность выбранного файла
                    if (!File.Exists(item))
                    {
                        MessageBox.Show("Некорретко указан файл для расшифрования!\n(Выбранный файл не существует)",
                                         "Ошибка",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        return;
                    }

                    // Расшифровываем файл и сохраняем результат
                    RSA.DecryptMessage(File.ReadAllBytes(item), item);

                    MessageBox.Show("Дефрование успешно завершено!");
                }
                else
                {
                    ulong p = Convert.ToUInt64(firstPartOfKey.Value);
                    ulong q = Convert.ToUInt32(secondPartOfKey.Value);
                    RSA.SetPartOfKeys(p, q); // Пример открытых ключей: 17 11

                    // Высчитываем открытый ключ e
                    RSA.Calculate_e();
                    // Высчитываем закрытый ключ d
                    RSA.Calculate_d();

                    // Проверка на корректность выбранного файла
                    if (!File.Exists(item))
                    {
                        MessageBox.Show("Некорретко указан файл для расшифрования!\n(Выбранный файл не существует)",
                                         "Ошибка",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        return;
                    }

                    // Расшифровываем файл и сохраняем результат
                    RSA.DecryptMessage(File.ReadAllBytes(item), item);

                    MessageBox.Show("Дефрование успешно завершено!");
                }
            }
        }

        private void openFileToDecrypt(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            fileForDecryptionPathTextBox.Text = dialog.SelectedPath;
            filesToDecrypt = Directory.GetFiles(dialog.SelectedPath);
        }
    }
}

