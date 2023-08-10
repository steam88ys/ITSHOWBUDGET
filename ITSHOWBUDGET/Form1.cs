using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSHOWBUDGET
{
    public partial class Form1 : Form
    {

        static private List<UserInfo> userList = new List<UserInfo>()
        {
            new UserInfo(){hakbun=3101, name="가솦과", department="소프트웨어과", contest="계묘년을 지켜라!", budget=5000},
            new UserInfo(){hakbun=3102, name="나솦과", department="소프트웨어과", contest="달나라 방범대", budget=15000},
            new UserInfo(){hakbun=3103, name="다솦과", department="소프트웨어과", contest="망원경", budget=100},
            new UserInfo(){hakbun=3104, name="라솦과", department="소프트웨어과", contest="계묘년을 지켜라!", budget=5000},
            new UserInfo(){hakbun=3105, name="마솦과", department="소프트웨어과", contest="세일러문", budget=5000},
            new UserInfo(){hakbun=3201, name="감솦과", department="소프트웨어과", contest="망원경", budget=7000},
            new UserInfo(){hakbun=3202, name="남솦과", department="소프트웨어과", contest="계묘년을 지켜라!", budget=70000},
            new UserInfo(){hakbun=3203, name="담솦과", department="소프트웨어과", contest="세일러문", budget=10000},
            new UserInfo(){hakbun=3301, name="각웹솔", department="웹솔루션과", contest="계묘년을 지켜라!", budget=25000},
            new UserInfo(){hakbun=3302, name="낙웹솔", department="웹솔루션과", contest="토끼운동", budget=3000},
            new UserInfo(){hakbun=3401, name="갇웹솔", department="웹솔루션과", contest="세일러문", budget=5000},
            new UserInfo(){hakbun=3402, name="낟웹솔", department="웹솔루션과", contest="달나라 방범대", budget=50000},
            new UserInfo(){hakbun=3403, name="닫웹솔", department="웹솔루션과", contest="계묘년을 지켜라!", budget=5000},
            new UserInfo(){hakbun=3501, name="기디과", department="디자인과", contest="토끼운동", budget=500},
            new UserInfo(){hakbun=3502, name="니디과", department="디자인과", contest="계묘년을 지켜라!", budget=5000},
            new UserInfo(){hakbun=3601, name="고디과", department="디자인과", contest="토끼운동", budget=5000},
            new UserInfo(){hakbun=3602, name="노디과", department="디자인과", contest="망원경", budget=8000},
            new UserInfo(){hakbun=3603, name="도디과", department="디자인과", contest="망원경", budget=1000},
            new UserInfo(){hakbun=3604, name="로디과", department="디자인과", contest="달나라 방범대", budget=5000},
            new UserInfo(){hakbun=3605, name="모디과", department="디자인과", contest="계묘년을 지켜라!", budget=9000}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
