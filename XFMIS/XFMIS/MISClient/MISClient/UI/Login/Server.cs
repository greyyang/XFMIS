using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MISClient.UI.Login
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string localhost = this.textEdit1.Text;
            string port = this.textEdit2.Text;
            if (updatexml(localhost, port))
            {
                DialogResult r1 = MessageBox.Show("修改成功！", "提示");
                if ((int)r1 == 1)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("请重新输入");
            }
        }

        private static bool updatexml(string text1,string text2)
        {
            bool flag = true;
            //string appPath = @"..\..\app.config";
            string intext = null;
            string appPath = string.Format("{0}\\MISClient.exe.config", System.Windows.Forms.Application.StartupPath);
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(appPath);//加载xml文件，文件
                XmlNodeList nodes = xmlDoc.GetElementsByTagName("setting");//找出名称为“setting”的所有元素  
                foreach (XmlNode xnd in nodes)
                {
                    XmlNodeList xnl = xnd.ChildNodes;//取出所有的子节点
                    foreach (XmlNode xne in xnl)
                    {
                        XmlElement xe = (XmlElement)xne;//转换类型
                        if (xe.Name == "value")//判断是否是要查找的元素
                        {
                            intext = xe.InnerText;
                            int i = intext.LastIndexOf("/");
                            string nintext = intext.Substring(intext.LastIndexOf("/",intext.LastIndexOf("/")-1));
                            xe.InnerText = string.Format("http://{0}:{1}/Service{2}", text1, text2, nintext);
                        }
                    }
                }
                //XmlNode xns = xmlDoc.SelectSingleNode("configuration");//查找要修改的节点
                //XmlNodeList xnl0 = xns.ChildNodes;//取出所有的子节点
                //foreach (XmlNode xnt in xnl0)
                //{
                //    XmlNodeList xnl = xnt.ChildNodes;//取出所有的子节点
                //    foreach (XmlNode xnt1 in xnl)
                //    {
                //        XmlNodeList xnl1 = xnt1.ChildNodes;//取出所有的子节点
                //        foreach (XmlNode xn in xnl1)
                //        {
                //            XmlElement xe = (XmlElement)xn;//将节点转换一下类型

                //            XmlNodeList xnl2 = xe.ChildNodes;//取出该子节点下面的所有元素
                //            foreach (XmlNode xn2 in xnl2)
                //            {
                //                XmlElement xe2 = (XmlElement)xn2;//转换类型
                //                if (xe2.Name == "value")//判断是否是要查找的元素
                //                {
                //                    intext = xe2.InnerText;
                //                    xe2.InnerText = string.Format("http://{0}:{1}/Service/NewProject/Service_NewProject.asmx", text1, text2);
                //                }
                //            }
                //            //break;
                //        }
                //    }
                //}
                xmlDoc.Save(appPath);//再一次强调 ，一定要记得保存的该XML文件
            }
            catch
            {
                flag = false;

            }
            return flag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
