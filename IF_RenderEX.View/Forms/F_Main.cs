using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_RenderEX.View
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        /// Inicialização
        private void F_Main_Load(object sender, EventArgs e)
        {

        }


        /// MOVIMENTAÇÃO, RESPONSIVIDADE E CONTROLADORES DA JANELA
        // Movimentação
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCaptue(); // DLL para captura de movimentação
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam); // DLL para informação de message para o WindowProcedure
        private void grad_MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Acessa as funcionalidades da DLL usar32.DLL para que possibilite movimentar a janela usando o MenuBar como alça
            ReleaseCaptue();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // Responsividade
        private const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
        private const int respView = 10;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, respView); } }
        Rectangle Left { get { return new Rectangle(0, 0, respView, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - respView, this.ClientSize.Width, respView); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - respView, 0, respView, this.ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, respView, respView); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - respView, 0, respView, respView); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - respView, respView, respView); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - respView, this.ClientSize.Height - respView, respView, respView); } }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }


        // Controladores
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btn_Maximize.Visible = false;
            this.btn_Normalize.Visible = true;
        }
        private void btn_Normalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btn_Normalize.Visible = false;
            this.btn_Maximize.Visible = true;
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        ///# # # # # # # # # # # # # # # # # # # # # # # #



        /// MENU BAR




        /// MENU DETAILS
        private bool collapsed_Details;
        private Bitmap img_CollapseRigth = IF_RenderEX.View.Properties.Resources.icon_CollapseToRigth;
        private Bitmap img_CollapseLeft = IF_RenderEX.View.Properties.Resources.icon_CollapseToLeft;

        private void btn_DetailCollapse_Click(object sender, EventArgs e)
        {
            //Verifica se o Menu de Detalhes está o não colapsado
            if (collapsed_Details)
            {
                this.collapsed_Details = false;
                this.btn_DetailCollapse.Image = img_CollapseRigth;

                this.tlp_PanelMaster.ColumnStyles[2].Width = 397;
            }
            else
            {
                this.collapsed_Details = true;
                this.btn_DetailCollapse.Image = img_CollapseLeft;

                this.tlp_PanelMaster.ColumnStyles[2].Width = 95;
            }
        }

    }
}
