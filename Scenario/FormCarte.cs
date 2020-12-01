using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTAI.Scenario {
    public partial class FormCarte : Form {
        #region Données membres

        private Point position;

        #endregion

        #region Constructeurs

        public FormCarte() {
            InitializeComponent();
            position = new Point();
        }

        #endregion

        #region Propriétés publiques

        public Point Position { get => position; }

        #endregion

        private void pictureCarte_Click(object sender, EventArgs e) {
            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null) {
                position.X = mouseEventArgs.X;
                position.Y = mouseEventArgs.Y;
            }
        }
    }
}
