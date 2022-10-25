using Library.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmHome : Form
    {
        bool SidebarExpand= true;
        private Form activeForm; //aktif formu değiştirebilmek için oluşturduk

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmHome()
        {
            InitializeComponent();
            this.btnLogOut.Location = new System.Drawing.Point(3, 530); //butonu aşşğı sabitlemeye çalıştım
            timerDateClock.Start();  
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        //sidebar animation için
        #region
        private void SideBartimer_Tick(object sender, EventArgs e)
        {
            if(SidebarExpand==true)
            {
                flowMenu.Width -= 10;
                if(flowMenu.Width==flowMenu.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SideBartimer.Stop();
                }
                else
                {
                    flowMenu.Width += 10;
                    if(flowMenu.Width==flowMenu.MaximumSize.Width)
                    {
                        SidebarExpand = false;
                        SideBartimer.Stop();
                    }
                }
            }

        }  //Sidebar ın açılıp kapanmasının animasyonunu yapıyor
        private void btnMenu_Click(object sender, EventArgs e) //menu picture box ını buton diye isimlendirdik ve ona basılınca side barın genişlipi değişsin istiyoruz
        {
            SideBartimer.Start();
        }
        #endregion

        private void OpenChildForm(Form childForm,object btnSender)  //Tek bir formda book personel gibi formları açmak için kendimiz bir method oluşturuyoruz
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
           // ActivateButton(btnSender); //buton aktifleşince renktir büyüklüktür falan bir şeyleri değiştirmek istersen ActivateButon methodu yazabilirsin ama ben yazmadım
            activeForm = childForm; //açılması istenen child formu aktif forma eşitliyoruz
            childForm.TopLevel = false;  //bu olmadığında   this.pnlChild.Controls.Add(childForm);   da patlıyor
            childForm.FormBorderStyle = FormBorderStyle.None;  //kenarları olmasın formun diyoruz
            childForm.Dock=DockStyle.Fill;  //açılan formun fill olmasını istiyor
            this.pnlChild.Controls.Add(childForm);  //açılacak formu 
            this.pnlChild.Tag = childForm;
            childForm.BringToFront();  //öne getiriyor
            childForm.Show();
            lblTitle.Text = childForm.Text; //child formun title text ini lbltitle da göstercez
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void btnPersonelPage_Click_1(object sender, EventArgs e)  //user butonuna basınca personel formu açılması için
        {
            OpenChildForm(new Forms.frmPersonel(),sender);
         //   frmPersonel _personel = new Forms.frmPersonel();
         //  _personel.ShowDialog();
        }

        private void btnBookPage_Click(object sender, EventArgs e)   //book butonuna basınca book formu açılması için
        {
            OpenChildForm(new Forms.frmBook(), sender);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)  //aslında burda saklıyoruz frmHome u ama kapatmamız lazım bunu düzeltt
        {
         
            this.Hide();     //login formunu açıp diğerini kapatmak için önce frmHome u saklayıp frmLogin i set edip 
            frmLogin frm = new frmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)  
        {
            // OpenChildForm(new Forms.frmHome(), sender);
            this.Hide();
            frmHome frm = new frmHome();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void timerDateClock_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
