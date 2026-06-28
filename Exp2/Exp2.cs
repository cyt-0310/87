using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.PowerPacks;

namespace Exp2
{
    public partial class Exp2 : Form
    {
        UdpClient UC;
        Thread TH;

        ShapeContainer SCA; //畫布A，給我們使用的
        ShapeContainer SCB; //畫布B，給網友使用的
        Point stP; //起始點
        string sPS; //筆跡的資料 x1,y1|x2,y2|...


        public Exp2()
        {
            InitializeComponent();
            UC = new UdpClient();         // 假設 UdpClient 有無參數建構式
            TH = new Thread(() => {});    // 初始化為空執行緒
            SCA = new ShapeContainer();   // 假設 ShapeContainer 有無參數建構式
            SCB = new ShapeContainer();   // 假設 ShapeContainer 有無參數建構式
            sPS = string.Empty;           // 初始化為空字串
        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            TH = new Thread(Listen);
            TH.Start();

            bt_Listen.Enabled = false;
        }

        private void Listen()
        {
            int LPort = Convert.ToInt16(tb_ListenPort.Text);

            UC = new UdpClient(LPort);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"),LPort);

            while (true)
            {
                byte[] B =  UC.Receive(ref EP);
                string MSG = System.Text.Encoding.Default.GetString(B); //x1,y1|x2,y2|...
                string[] MSGA = MSG.Split('|');

                for (int i = 0; i < MSGA.Length - 1; i++)
                {
                    string AddA = MSGA[i];
                    string[] AA = AddA.Split(',');
                    Point PA = new Point(Convert.ToInt16(AA[0]), Convert.ToInt16(AA[1]));

                    String AddB = MSGA[i + 1];
                    string[] BA = AddB.Split(',');
                    Point PB = new Point(Convert.ToInt16(BA[0]), Convert.ToInt16(BA[1]));

                    LineShape L = new LineShape();
                    L.StartPoint = PA;
                    L.EndPoint = PB;
                    L.BorderWidth = 3;
                    L.Parent = SCB; 

                }


            }
        }

        private void Exp2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.Environment.Exit(0);
                UC.Close();
            }
            catch
            {

            }
        }

        private void Exp2_Load(object sender, EventArgs e)
        {
            SCA = new ShapeContainer();
            SCB = new ShapeContainer();

            this.Controls.Add(SCA);
            this.Controls.Add(SCB);


        }

        private void Exp2_MouseDown(object sender, MouseEventArgs e)
        {
            stP = e.Location; //紀錄起始點
            sPS = $"{stP.X},{stP.Y}"; //紀錄起點筆跡資料

        }

        private void Exp2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//如果滑鼠左鍵有按著的才記第二點
            {

                LineShape L = new LineShape();
                L.StartPoint = stP;
                L.EndPoint = e.Location;
                L.Parent = SCA; //把線放到畫布A上
                L.BorderWidth = 3;

                stP = e.Location; //紀錄下一個起始點
                sPS += $"|{stP.X},{stP.Y}"; //紀錄筆跡資料

            }
        }

        private void Exp2_MouseUp(object sender, MouseEventArgs e)
        {
            //滑鼠放開時，把筆跡資料傳給對方
            string TIP = tb_TargetIP.Text;
            int TPort = Convert.ToInt16(tb_TargetPort.Text);

            UdpClient S = new UdpClient(TIP,TPort);
            byte[] B = System.Text.Encoding.Default.GetBytes(sPS);
            S.Send(B, B.Length);
            S.Close();

        }
    }
}
