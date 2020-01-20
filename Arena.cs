 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Arena : Form
    {
        Random random = new Random();

        List<string> Icons = new List<string>()
        {
            "!", "!", "U", "U", "C", "C", "A", "A",
            "b", "b", "k", "k", "M", "M", "1", "1"
        };

        public Arena()
        {
            InitializeComponent();
        }

    }
}
