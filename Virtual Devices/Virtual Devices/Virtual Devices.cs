using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using MQTTnet;
using System.Threading;
using System.Runtime.InteropServices;

namespace Virtual_Devices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("适配器个数：" + adapters.Length);
            int index = 0;
            foreach (NetworkInterface adapter in adapters)
            {
                index++;
                //显示网络适配器描述信息、名称、类型、速度、MAC 地址
                Console.WriteLine("---------------------第" + index + "个适配器信息---------------------");
                Console.WriteLine("描述信息：" + adapter.Name);
                Console.WriteLine("类型：" + adapter.NetworkInterfaceType);
                Console.WriteLine("速度：" + adapter.Speed / 1000 / 1000 + "MB");
                Console.WriteLine("MAC 地址：" + adapter.GetPhysicalAddress());
                IPInterfaceProperties IPInterfaceProperties = adapter.GetIPProperties();
                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString())
                    {
                        //Console.WriteLine("IP地址：" + UnicastIPAddressInformation.Address.ToString() + "\n");
                        comboBoxlocaliplist.Items.Add(UnicastIPAddressInformation.Address.ToString());
                    }
                }
                comboBoxlocaliplist.SelectedIndex = 0;
            }
        }
        private void VirtualDevices(object obj)
        {
            string str = "Virtual Devices " + obj.ToString() + " 开机启动\r\n" ;
            
            if (richTextBoxLog.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.richTextBoxLog.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                this.richTextBoxLog.Invoke(actionDelegate, str);
            }
            else
            {
                this.richTextBoxLog.Text += str;
            }
            
        }
        public Thread[] thStep;
        Int32 VirtualDevicesCnt = 0;
        private void ButtonPowerOn_Click(object sender, EventArgs e)
        {
            if (buttonPowerOn.Text == "所有设备通电开机")
            {
                VirtualDevicesCnt = Convert.ToInt32(textBoxDeviceCnt.Text);
                thStep = new Thread[VirtualDevicesCnt];

                textBoxDeviceCnt.Enabled = false;
                for (int i = 0; i < VirtualDevicesCnt; i++)
                {
                    thStep[i] = new Thread(new ParameterizedThreadStart(VirtualDevices));
                    thStep[i].Start(i);
                }
                buttonPowerOn.Text = "所有设备断电关机";
            }
            else
            {
                textBoxDeviceCnt.Enabled = true;
                for (int i = 0; i < VirtualDevicesCnt; i++)
                {
                    thStep[i].Abort(i);
                    string str = "Virtual Devices " + i.ToString() + " 断电关机\r\n";
                    richTextBoxLog.Text += str;
                }
                buttonPowerOn.Text = "所有设备通电开机";
            }
        }
    }
}
