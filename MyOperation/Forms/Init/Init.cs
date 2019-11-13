using System;
using System.Drawing;
using System.Windows.Forms;


namespace MyOperation.Forms.Init
{
    public partial class Init : Form
    {
        private Init_Event init_Event;

        #region 窗体绘制
        public Init() { InitializeComponent(); }
        public Init(Init_Event init_Event)
        {
            InitializeComponent();

            if (init_Event != null)
            {
                this.init_Event = init_Event;
            }
        }
        /// <summary>
        /// Init窗体在绘制过程中加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Init_Load(object sender, EventArgs e)
        {
            if (init_Event != null)
            {
                this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.init_Event.Background_MouseDown);
                //调用Init_Event_Load方法执行Init_Load操作
                this.init_Event.Init_Event_Load();
            }
        }
        #endregion
    }
}
