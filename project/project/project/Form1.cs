using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace project
{
    public partial class Form1 : Form { 
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
        //public List<string> list1 = new List<string>();
        //public List<string> list2 = new List<string>();
        //public List<string> list3 = new List<string>();
        
        private void Form1_Load(object sender, EventArgs e)
        {

          toolTip1.ShowAlways = true;
        }

        
        private void btn_korean_Click(object sender, EventArgs e)
        {   
            int price = 5000;
            List<string> list1 = new List<string>();
            if (this.numericUpDown1.Value > 0)    //텍스트 박스가 빈칸이 아닐경우
            {
                list1.Add("");
                list1.Add("한식");
                list1.Add(this.numericUpDown1.Value.ToString());
                list1.Add((price*(this.numericUpDown1.Value)).ToString());

                ListViewItem lvi1 = new ListViewItem(list1.ToArray());
                listView1.Items.Add(lvi1);
                this.numericUpDown1.Value = 0; // 작성한 텍스트를 빈칸으로 만들어줌
                //sum = this.listView1.Items[0].SubItems[2].Text;
                //MessageBox.Show(sum + " 원 결제되었습니다", "결제완료");

            }
            else { 
                MessageBox.Show("1개 이상을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error); // 텍스트 입력박스가 빈칸일 경우 알림 코드
            }




        }
        private void btn_western_Click(object sender, EventArgs e)
        {
            int price = 6000;
            List<string> list2 = new List<string>();
            if (this.numericUpDown2.Value > 0)
            {
                list2.Add("");
                list2.Add("양식");
            list2.Add(this.numericUpDown2.Value.ToString());
            list2.Add((price * (this.numericUpDown2.Value)).ToString());

            ListViewItem lvi2 = new ListViewItem(list2.ToArray());
            listView1.Items.Add(lvi2);
            this.numericUpDown2.Value = 0;
            }
            else
            {
                MessageBox.Show("1개 이상을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_chinese_Click(object sender, EventArgs e)
        {
            int price = 7000;
            List<string> list3 = new List<string>();
            if (this.numericUpDown3.Value > 0)
                {
                list3.Add("");
                list3.Add("중식");
                    list3.Add(this.numericUpDown3.Value.ToString());
                    list3.Add((price * (this.numericUpDown3.Value)).ToString());

                    ListViewItem lvi3 = new ListViewItem(list3.ToArray());
                    listView1.Items.Add(lvi3);

                    this.numericUpDown3.Value = 0;
                }
                else
                {
                    MessageBox.Show("1개 이상을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }


        private void btn_cancle_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                MessageBox.Show("주문이 취소되었습니다.", "주문취소");
                this.listView1.Items.Clear();
            }
            else { MessageBox.Show("음식을 추가하세요."); }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            
            
            int sum = 0;
            int count = listView1.Items.Count;


            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    sum += int.Parse(this.listView1.Items[i].SubItems[3].Text);
                }
                MessageBox.Show(sum + " 원 결제되었습니다", "결제완료");
                this.listView1.Items.Clear();
            }
            else { MessageBox.Show("음식을 추가하세요."); }
            

        }

        

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;       
            toolTip.SetToolTip(this.numericUpDown1, "1.갯수를 지정해주세요");
            toolTip.SetToolTip(this.btn_korean, "2.사진을 눌러주세요");
            toolTip.SetToolTip(this.btn_order, "3.사진을 눌러주세요");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (this.listView1.Items[i].Checked)    //체크가 되어있으면
                {
                    listView1.Items.RemoveAt(i);
                }
            }
        }

        private void button1_Mouseover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "ToolTip";
            this.toolTip1.IsBalloon = true;
            //this.toolTip1.ShowAlways = true;
            this.toolTip1.SetToolTip(this.button1, "Button");
        }
    }


    }