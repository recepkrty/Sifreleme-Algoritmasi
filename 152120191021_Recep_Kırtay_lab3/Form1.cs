using System.Windows.Forms;
using testScript;

namespace _152120191021_Recep_Kırtay_lab3
{
    public partial class Form1 : Form
    {
        testClass test3 = new testClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_studentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_metin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar) != ' ')
            {
                e.Handled = true;
            }
        }

        private void button_şifrele_Click(object sender, EventArgs e)
        {
            int score = 0;
            string algorithm, enDec;
            label_score.Text = "SKOR : ";
            if (textBox_studentID.Text.Length != 8)
            {
                MessageBox.Show("Öğrenci Numarası 8 Karakter Olmalıdır !");
                return;
            }
            if (textBox_metin.Text.Length == 0)
            {
                MessageBox.Show("Metin Kutusu Boş Olamaz !");
                return;
            }
            if (radioButton_Caesar.Checked)
            {
                algorithm = "Caesar";
                if (radioButton_şifreleme.Checked)
                {
                    enDec = "encrypt";
                    label_output.Text = CaesarEncipher(textBox_metin.Text, 7);
                }
                else
                {
                    enDec = "decrypt";
                    label_output.Text = CaesarDecipher(textBox_metin.Text, 7);
                }
            }
            else
            {
                algorithm = "Vigenere";
                if (radioButton_şifreleme.Checked)
                {
                    enDec = "encrypt";
                    label_output.Text = VigenereEncipher(textBox_metin.Text, "esoguce");
                }
                else
                {
                    enDec = "decrypt";
                    label_output.Text = VigenereDecipher(textBox_metin.Text, "esoguce");
                }
            }
            FileStream dosya = new FileStream(textBox_studentID.Text + ".csv", FileMode.Create, FileAccess.Write);
            StreamWriter yazici = new StreamWriter(dosya);
            yazici.WriteLine(label_output.Text);
            yazici.Close();
            dosya.Close();

            //test.dll
            score += test3.testFuncApp3(textBox_studentID.Text, textBox_metin.Text, algorithm, enDec, label_output.Text, CaesarEncipher(textBox_metin.Text, 7),
                VigenereEncipher(textBox_metin.Text, "esoguce"), CaesarDecipher(textBox_metin.Text, 7), VigenereDecipher(textBox_metin.Text, "esoguce"));

            label_score.Text += score.ToString();
            label_score.BackColor = Color.DarkTurquoise;
            label_score.ForeColor = Color.Navy;
        }

        private static char CaesarCipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);
        }

        public static string CaesarEncipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += CaesarCipher(ch, key);

            return output;
        }

        public static string CaesarDecipher(string input, int key)
        {
            return CaesarEncipher(input, 26 - key);
        }


        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private static string VigenereCipher(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null;

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        public static string VigenereEncipher(string input, string key)
        {
            return VigenereCipher(input, key, true);
        }

        public static string VigenereDecipher(string input, string key)
        {
            return VigenereCipher(input, key, false);
        }
    }
}