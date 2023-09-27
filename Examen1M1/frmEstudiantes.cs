using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1M1
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEstudianteRegular FrmEstudianteRegular = new frmEstudianteRegular();
            FrmEstudianteRegular.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEstudiantePregrado FrmEstudiantePregrado = new frmEstudiantePregrado();
            FrmEstudiantePregrado.ShowDialog();
        }
    }
}
