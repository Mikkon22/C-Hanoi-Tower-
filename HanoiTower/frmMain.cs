using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiTower
{

    enum Post
    {
        None = 0,
        Start = 1,
        Auxiliary = 2,
        Destination = 3
    }
    public partial class frmMain : Form
    {
        int _counter = 0;
        int[] CoordinatesX = { 200, 660, 1106 };
        int[] CoordinatesY = { 380, 350, 320, 290, 260, 230, 200 };


        Post _to = Post.None;
        Post _from = Post.None;
        public List<Panel> Post1 = new List<Panel>();
        public List<Panel> Post2 = new List<Panel>();
        public List<Panel> Post3 = new List<Panel>();
        private Panel _bufor = null;
        private bool MoveRing()
        {
           
            List<Panel> From = new List<Panel>();
            List<Panel> To = new List<Panel>();
            switch(_to)
            {
                case Post.Start:
                    To = Post1;
                    break;
                case Post.Auxiliary:
                    To = Post2;

                    break;
                case Post.Destination:
                    To = Post3;

                    break;
            }
            switch (_from)
            {
                case Post.Start:
                    From = Post1;
                    break;
                case Post.Auxiliary:
                    From = Post2;

                    break;
                case Post.Destination:
                    From = Post3;

                    break;
            }
            if (To.Count == 0 || (To.Count > 0 && To.Last().Width > From.Last().Width))
            {
                To.Add(From.Last());
                From.RemoveAt(From.Count - 1);
                SetRingCoordinates(To.Last());
                _counter++;
                lblCounter.Text = _counter.ToString();
                return true;
            }
            return false;
        }
        private void SetRingCoordinates(Panel ring)
        {
            switch (_to)
            {
                case Post.Start:
                    ring.Left = CoordinatesX[(int)_to - 1] - ring.Width / 2+10;
                    ring.Top = CoordinatesY[Post1.Count-1];
                    break;
                case Post.Auxiliary:
                    ring.Left = CoordinatesX[(int)_to - 1] - ring.Width / 2+10;
                    ring.Top = CoordinatesY[Post2.Count-1];
                    break;
                case Post.Destination:
                    ring.Left = CoordinatesX[(int)_to - 1] - ring.Width / 2+10;
                    ring.Top = CoordinatesY[Post3.Count-1];
                    break;
            }
            _from = Post.None;
            _to = Post.None;
            btnStart.BackColor = Color.White;
            btnAuxiliary.BackColor = Color.White;
            btnDestination.BackColor = Color.White;
            _bufor = null;
            if (Post3.Count == 7)
            {
                MessageBox.Show($"Gratulacje! Ukończono grę po {_counter.ToString()} ruchach");
                this.Close();
            }
        }
        public frmMain()
        {
            InitializeComponent();
            Post1.Add(ring1);
            Post1.Add(ring2);
            Post1.Add(ring3);
            Post1.Add(ring4);
            Post1.Add(ring5);
            Post1.Add(ring6);
            Post1.Add(ring7);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Post1.Count == 0 && _bufor==null) return;
            if (_bufor == null)
            {
                _from = Post.Start;
                btnStart.BackColor = Color.Red;
                _bufor = Post1.Last<Panel>();
            }
            else
            {
                if (_from == Post.Start)
                {
                    lblMessage.Visible = false;
                    btnStart.BackColor = Color.White;
                    _bufor = null;
                }
                else
                {
                    _to = Post.Start;
                    if (!MoveRing()) lblMessage.Visible = true;
                    else lblMessage.Visible = false;
                }
            }
        }
        private void btnAuxiliary_Click(object sender, EventArgs e)
        {
            if (Post2.Count == 0 && _bufor == null) return;
            if (_bufor == null)
            {
                _from = Post.Auxiliary;
                btnAuxiliary.BackColor = Color.Red;
                _bufor = Post1.Last<Panel>();
            }
            else
            {
                if(_from== Post.Auxiliary)
                {
                    lblMessage.Visible = false;
                    btnAuxiliary.BackColor = Color.White;
                    _bufor = null;
                }
                else
                {
                    _to = Post.Auxiliary;
                    if (!MoveRing()) lblMessage.Visible = true;
                    else lblMessage.Visible = false;
                }
            }

        }
        private void btnDestination_Click(object sender, EventArgs e)
        {
            if (Post3.Count == 0 && _bufor == null) return;
            if (_bufor == null)
            {
                _from = Post.Destination;
                btnDestination.BackColor = Color.Red;
                _bufor = Post1.Last<Panel>();
            }
            else
            {
                if (_from == Post.Destination)
                {
                    lblMessage.Visible = false;
                    btnDestination.BackColor = Color.White;
                    _bufor = null;
                }
                else
                {
                    _to = Post.Destination;
                    if (!MoveRing()) lblMessage.Visible = true;
                    else lblMessage.Visible = false;
                }
            }

        }
    }
}
