using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LopezBasicThreading
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;

        

        private void button1_Click(object sender, EventArgs e)    
        {
            MyThreadClass mtc = new MyThreadClass();
            ThreadStart delObjThread = new ThreadStart(mtc.Thread1);

            Console.WriteLine("-Before starting thread-");
            

            ThreadA = new Thread(delObjThread);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(delObjThread);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of thread-");

            label1.Text = "-End of thread-";
        }

        public FrmBasicThread()
        {
            InitializeComponent();
        }

    }
}
