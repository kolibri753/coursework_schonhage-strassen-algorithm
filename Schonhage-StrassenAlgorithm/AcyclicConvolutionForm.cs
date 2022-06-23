using System.Numerics;
using System.Windows.Forms;

namespace Schonhage_StrassenAlgorithm
{
    public partial class AcyclicConvolutionForm : Form
    {
        // Конструктор з параметором - acyclicConvolution
        public AcyclicConvolutionForm(BigInteger[] acyclicConvolution)
        {
            InitializeComponent();

            // Виведення ациклічної згортки на екран
            foreach (var num in acyclicConvolution)
            {
                rtbAcyclicConvolution.Text += num + "  ";
            }
        }
    }
}
