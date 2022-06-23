/* Підключення бібліотек */
using System; //Кореневий простір імен для основних типів у .NET
using System.Diagnostics; //Для підрахунку часу
using System.Numerics; //Для типу даних BigInteger
using System.Windows.Forms; //Для створення інтерфейсу

namespace Schonhage_StrassenAlgorithm
{
    public partial class MainForm : Form
    {
        // Зміна для виведення ациклічної згортки в окремому вікні
        private BigInteger[] acyclicConvolutionSave;

        public MainForm()
        {
            InitializeComponent();

            // При запуску сховати параметр часу
            labelTime.Visible = false;
        }

        /* Подія при натисканні на кнопку "Порахувати" */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Змінні для вхідних даних, та перевірка на їх коректність
            if (!BigInteger.TryParse(tbFirstNum.Text, out BigInteger a))
            {
                MessageBox.Show("Введіть у верхнє поле число!", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!BigInteger.TryParse(tbSecondNum.Text, out BigInteger b))
            {
                MessageBox.Show("Введіть у нижнє поле число!", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Змінна для годинника
            var sw = new Stopwatch();

            // Обчислення добутку та часу, що на це пішло
            sw.Start();
            BigInteger rezult = schonhageStrassenMultiplication(a, b);
            sw.Stop();

            // Виведення добутку на екран
            rtbMultiplicationResult.Text = rezult.ToString();

            /* Додаткові функції */

            // Виведення ациклічної згортки у окреме вікно
            if (cbAcyclicConvolution.Checked)
            {
                AcyclicConvolutionForm form = new AcyclicConvolutionForm(acyclicConvolutionSave);
                form.Show();
            }

            // Виведення часу виконання алгоритму
            if (cbTime.Checked)
            {
                labelTime.Visible = true;
                long time = sw.ElapsedMilliseconds;
                labelTime.Text = time.ToString();
            }
            else
            {
                labelTime.Visible = false;
            }
        }


        // Підрахунок кількості цифр у числі
        private long countDigits(BigInteger num)
        {
            long count = (num == 0) ? 1 : 0;
            while (num != 0)
            {
                count++;
                num /= 10;
            }
            
            return count;
        }

        // Алгоритм Шенхаге-Штрасена
        private BigInteger schonhageStrassenMultiplication(BigInteger a, BigInteger b)
        {
            // Знаходження ациклічної згортки
            BigInteger[] acyclicConvolution = findAcyclicConvolution(a, b);
            // Перенесення
            BigInteger carry = performCarry(acyclicConvolution);

            return carry;
        }

        // Знаходження ациклічної згортки
        private BigInteger[] findAcyclicConvolution(BigInteger a, BigInteger b)
        {
            // Кількість цифр в контейнері a
            long aDigits = countDigits(a);
            // Кількість цифр в контейнері b
            long bDigits = countDigits(b);
            // Тимчасова зміна для збереження a
            BigInteger temp = a;

            // Довжина ациклічної згортки
            long length = aDigits + bDigits;
            BigInteger[] acyclicConvolution = new BigInteger[length];

            for (long i = 0; i < bDigits; i++, b /= 10)
            {
                a = temp;
                for (long j = 0; j < aDigits; j++, a /= 10)
                {
                    /* Множення поточної цифри контейнера a на 
                     * поточну цифру контейнера b та зберігання 
                     * результату в acyclicConvolution  
                     */
                    acyclicConvolution[i + j] += (b % 10) * (a % 10);
                }
            }

            // Зберігання ациклічної згортки в окрему зміну
            long s = 0;
            acyclicConvolutionSave = new BigInteger[length];
            for (long i = (long)(length - 1); i >= 0; i--)
            {
                acyclicConvolutionSave[s] = acyclicConvolution[i];
                s++;
            }
           
            return acyclicConvolution;
        }

        // Перенесення
        private BigInteger performCarry(BigInteger[] acyclicConvolution)
        {
            /* Оголошення та ініціалізція змінних */
            BigInteger product = 0;
            BigInteger carry = 0;
            BigInteger baseN = 1;

            /* Для кожного значення в ациклічній згортці 
             * виконуємо множення на відповідний ступінь 10,
             * та виконуємо перенесення
             */
            for (long i = 0; i < acyclicConvolution.Length; i++)
            {
                acyclicConvolution[i] += carry;
                product += (baseN * (acyclicConvolution[i] % 10));
                carry = acyclicConvolution[i] / 10;
                baseN *= 10;
            }

            return product;
        }

        #region Підрахунок символів у полях
        private void tbFirstNum_TextChanged(object sender, EventArgs e)
        {
            labelFirstNum.Text = ((TextBox)sender).Text.Length.ToString();
        }

        private void tbSecondNum_TextChanged(object sender, EventArgs e)
        {
            labelSecondNum.Text = ((TextBox)sender).Text.Length.ToString();
        }

        private void rtbMultiplicationResult_TextChanged(object sender, EventArgs e)
        {
            labelResult.Text = ((RichTextBox)sender).Text.Length.ToString();
        }
        #endregion
    }
}
