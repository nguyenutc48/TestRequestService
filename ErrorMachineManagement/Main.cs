using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC_MITSU_CONFIG;
using NEasyTcp.Client;
using System.Threading;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using AutoUpdaterDotNET;
using HELPER;
using System.Linq;
using Microsoft.Win32;

namespace ErrorMachineManagement
{
    public partial class Main : Form
    {
        string appName = "ErrorUpdateApp";
        int clientConnected = 0;
        int counter = 0;
        object obj = new object();
        Stopwatch stopwatch1 = new Stopwatch();
        string[,] _data = new string[500,500];
        List<string> listIp = new List<string>();
        List<MachineImportModel> machineImportModels = new List<MachineImportModel>();
        List<DeviceErrorImportModel> deviceErrorImportModels = new List<DeviceErrorImportModel>();
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Main()
        {
            InitializeComponent();
            if (rkApp.GetValue(appName) == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                chkStartup.Checked = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                chkStartup.Checked = true;
            }
            numTimeOutReq.Value = Properties.Settings.Default.timeOut;
            txtIpService.Text = Properties.Settings.Default.ip;
            txtPortService.Text = Properties.Settings.Default.port;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tmUpdate.Start();
            if(Properties.Settings.Default.useAuth == true)
            {
                BasicAuthentication basicAuthentication = new BasicAuthentication(Properties.Settings.Default.user, Properties.Settings.Default.pass);
                AutoUpdater.BasicAuthXML = AutoUpdater.BasicAuthDownload = AutoUpdater.BasicAuthChangeLog = basicAuthentication;
            }
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            cmbCPUPlc.DataSource = new BindingSource(PLC_LIST.PLC_CPU_TYPE_LST, null);
            cmbCPUPlc.DisplayMember = "Key";
            cmbCPUPlc.ValueMember = "Value";
            cmbCPUPlc.SelectedIndex = 22;

            cmbUnitPlc.DataSource = new BindingSource(PLC_LIST.PLC_UNIT_TYPE_LST, null);
            cmbUnitPlc.DisplayMember = "Key";
            cmbUnitPlc.ValueMember = "Value";
            cmbUnitPlc.SelectedIndex = 13;

            //EXCEL_HELPER.Read(Application.StartupPath+ @"\ip.xls", out _data);
            //for (int i = 1; i < _data.GetLength(0); i++)
            //{
            //    MachineImportModel machineImportModel = new MachineImportModel();
            //    machineImportModel.mc_ip = _data[i, 0];
            //    machineImportModel.mc_name = _data[i, 1];
            //    machineImportModels.Add(machineImportModel);
            //}
            //lblPLCs.Text = machineImportModels.Count.ToString();
        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {

                try
                {
                    if (AutoUpdater.DownloadUpdate(args))
                    {
                        Application.ExitThread();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                //}
            }


        }
        public void CSVLog(string ip, string loai, string time)
        {
            string dateNow = DateTime.Now.ToString("hh:mm:ss tt,dd/MM/yyyy").ToUpper();
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\TestSpeedLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".csv";
            if (!File.Exists(filepath))
            {
                try
                {
                    // Create a file to write to.   
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        sw.WriteLine(ip + "," + loai + "," + time);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CSV write error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(ip + "," + loai + "," + time);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CSV write error: " + ex.Message);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                clientConnected = 0;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int numberOfMachine = 0;
                foreach (var ip in listIp)
                {
                    EasyTcpClient client = new EasyTcpClient();
                    string _ip = txtIpService.Text.Trim();
                    ushort _port = (ushort)Convert.ToInt32(txtPortService.Text);
                    var result = client.Connect(_ip, _port, TimeSpan.FromSeconds(30));
                    if (result)
                        clientConnected++;

                    lblPLCConnected.Invoke((MethodInvoker)(() => lblPLCConnected.Text = clientConnected.ToString()));

                    plc_request plcRequest = new plc_request();
                    plcRequest.command = PLC_COMMAND.READ;
                    plcRequest.ip = ip;
                    plcRequest.cpu_unit = PLC_UNIT_TYPE.UNIT_QNETHER;
                    plcRequest.cpu_type = PLC_CPU_TYPE.CPU_Q04UDVCPU;
                    plcRequest.port = PLC_PORT.CPU_Q_TCP;

                    var deviceList = txtListAddr.Text.Trim().Split(',');

                    List<plc_address> plcAddress = new List<plc_address>();
                    foreach (string item in deviceList)
                    {
                        plc_address plc_Address = new plc_address();
                        plc_Address.device = item.Trim();
                        plc_Address.value = "";
                        plcAddress.Add(plc_Address);
                    }

                    plcRequest.devices = plcAddress;

                    string reqString = JsonConvert.SerializeObject(plcRequest);
                    NEasyTcp.Message message;
                    if(numTimeOutReq.Value>0)
                        message = client.SendAndGetReply(reqString, TimeSpan.FromSeconds((double)numTimeOutReq.Value));
                    else
                        message = client.SendAndGetReply(reqString, TimeSpan.FromSeconds(1));
                    if (message != null)
                    {
                        numberOfMachine++;
                        string b = message.GetString;
                        lblMCRespon.Invoke((MethodInvoker)(() => lblMCRespon.Text = numberOfMachine.ToString()));
                        printLogs(b);
                    }
                    else
                        printLogs("Bị Null rồi!");
                    client.Disconnect();
                }
                lblTotalTime.Invoke((MethodInvoker)(() => lblTotalTime.Text = (stopwatch.ElapsedMilliseconds / 1000).ToString()));
                stopwatch.Stop();
                stopwatch.Reset();
            });
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lock (obj)
            {
                if (counter >= listIp.Count)
                {
                    lblTotalTime.Text = (stopwatch1.ElapsedMilliseconds / 1000).ToString();
                    stopwatch1.Stop();
                    stopwatch1.Reset();
                    timer1.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EasyTcpClient client = new EasyTcpClient();
            string _ip = txtIpService.Text.Trim();
            ushort _port = (ushort)Convert.ToInt32(txtPortService.Text);
            client.Connect(_ip, _port, TimeSpan.FromSeconds(30));
            Stopwatch stopwatch_test = new Stopwatch();
            stopwatch_test.Start();

            plc_request plcRequest = new plc_request();
            plcRequest.command = PLC_COMMAND.READ;
            plcRequest.ip = txtPLCIp.Text.Trim();
            plcRequest.cpu_unit = (int)cmbUnitPlc.SelectedValue; ;
            plcRequest.cpu_type = (int)cmbCPUPlc.SelectedValue; ;
            plcRequest.port = PLC_PORT.CPU_Q_TCP;
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
                return;
            var deviceList = txtAddress.Text.Trim().Split(',');
            
            List<plc_address> plcAddress = new List<plc_address>();
            foreach (string item in deviceList)
            {
                plc_address plc_Address = new plc_address();
                plc_Address.device = item.Trim();
                plc_Address.value = "";
                plcAddress.Add(plc_Address);
            }

            plcRequest.devices = plcAddress;

            // Bien doi sang dang string
            string reqString = JsonConvert.SerializeObject(plcRequest);

            // Gui di va doi gia tri tra ve
            var a = client.SendAndGetReply(reqString, TimeSpan.FromSeconds(1));

            if (a != null)
            {
                string b = a.GetString;
                printLogs("Return Value: " + b);
                //txtLogs.AppendText("Return Value: "+b+Environment.NewLine);
                txtThoiGianThucHien.Text = stopwatch_test.ElapsedMilliseconds.ToString();
            }
            else
            {
                printLogs("Không có giá trị");
                //txtLogs.AppendText("Không có giá trị trả về");
            }
            client.Disconnect();
        }

        private void RunProg(string ip)
        {

            EasyTcpClient client = new EasyTcpClient();
            string _ip = txtIpService.Text.Trim();
            ushort _port = (ushort)Convert.ToInt32(txtPortService.Text);
            var result = client.Connect(_ip, _port, TimeSpan.FromSeconds(30));
            if (result)
                clientConnected++;
            lblPLCConnected.Invoke((MethodInvoker)(()=> lblPLCConnected.Text = clientConnected.ToString()));

            plc_request plcRequest = new plc_request();
            plcRequest.command = PLC_COMMAND.READ;
            plcRequest.ip = ip;
            plcRequest.cpu_unit = PLC_UNIT_TYPE.UNIT_QNETHER;
            plcRequest.cpu_type = PLC_CPU_TYPE.CPU_Q04UDVCPU;
            plcRequest.port = PLC_PORT.CPU_Q_TCP;
            var deviceList = txtListAddr.Text.Trim().Split(',');

            List<plc_address> plcAddress = new List<plc_address>();
            foreach (string item in deviceList)
            {
                plc_address plc_Address = new plc_address();
                plc_Address.device = item.Trim();
                plc_Address.value = "";
                plcAddress.Add(plc_Address);
            }

            plcRequest.devices = plcAddress;
            string reqString = JsonConvert.SerializeObject(plcRequest);

            NEasyTcp.Message message;
            if (numTimeOutReq.Value > 0)
                message = client.SendAndGetReply(reqString, TimeSpan.FromSeconds((double)numTimeOutReq.Value));
            else
                message = client.SendAndGetReply(reqString, TimeSpan.FromSeconds(1));
            if (message != null)
            {
                string b = message.GetString;
                printLogs(b);
            }
            else
                printLogs("Bị Null rồi!");

            client.Disconnect();
            lock (obj)
            {
                counter++;
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            counter = 0;
            clientConnected = 0;
            stopwatch1.Start();
            timer1.Start();
            Task.Factory.StartNew(()=> 
            {
                Parallel.ForEach(listIp, ip =>
                RunProg(ip));
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                Thread.Sleep(10000);
            });
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(ABC);
            thread.Start();
            if (!thread.Join(TimeSpan.FromSeconds(2)))
            {
                thread.Abort();
            }                
        }

        private void ABC()
        {
            Thread.Sleep(10000);
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            AutoUpdater.Start(Properties.Settings.Default.urlconfig);
        }

        private async void btnBrFileMC_ClickAsync(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xls) | *.xls";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string importFileName = openFileDialog.FileName;
                lblFileNameImport.Text = openFileDialog.SafeFileName;
                string[,] importData = new string[100, 100];
                btnImportDB.Enabled = false;
                await Task.Factory.StartNew(()=> {
                    EXCEL_HELPER.Read(importFileName, out importData);
                });
                
                if (importData.GetLength(1) > 4)
                {
                    MessageBox.Show("Định dang file không đúng");
                    return;
                }
                
                for (int i = 1; i < importData.GetLength(0); i++)
                {
                    MachineImportModel machineImportModel = new MachineImportModel();
                    machineImportModel.mc_ip = importData[i, 0].Trim();
                    listIp.Add(importData[i, 0].Trim());
                    machineImportModel.mc_name = importData[i, 1].Trim();
                    machineImportModel.plc_name = importData[i, 2].Trim();
                    machineImportModel.plc_keyAddr = importData[i, 3].Trim();
                    machineImportModels.Add(machineImportModel);
                }
                lblPLCs.Text = machineImportModels.Count.ToString();
                btnImportDB.Enabled = true;
            }
        }

        private async void btnBrFileDV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xls) | *.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string importFileName = openFileDialog.FileName;
                lblFileImportDevice.Text = openFileDialog.SafeFileName;
                string[,] importData = new string[100, 100];
                btnImportDB.Enabled = false;
                await Task.Factory.StartNew(()=> {
                    EXCEL_HELPER.Read(importFileName, out importData);
                });
                if (importData.GetLength(1)>4)
                {
                    MessageBox.Show("Định dạng file không đúng");
                    return;
                }

                for (int i = 1; i < importData.GetLength(0); i++)
                {
                    DeviceErrorImportModel deviceErrorImportModel = new DeviceErrorImportModel();
                    deviceErrorImportModel.device_name = importData[i, 0].Trim();
                    deviceErrorImportModel.error_name = importData[i, 1];
                    deviceErrorImportModel.error_description = importData[i, 2];
                    deviceErrorImportModel.error_solution = importData[i, 3];
                    deviceErrorImportModels.Add(deviceErrorImportModel);
                }
                btnImportDB.Enabled = true;
            }
        }

        private async void btnImportDB_Click(object sender, EventArgs e)
        {
            btnImportDB.Enabled = false;
            await Task.Factory.StartNew(() =>
            {
                using (PAD_MCEMEntities db = new PAD_MCEMEntities())
                {
                    foreach (var item in machineImportModels)
                    {
                        if (!db.padmc_machines.ToList().Exists(m => m.mc_ip == item.mc_ip))
                        {
                            padmc_machines padmc_Machines = new padmc_machines();
                            padmc_Machines.mc_id = item.mc_ip.Replace(".", "");
                            padmc_Machines.mc_ip = item.mc_ip;
                            padmc_Machines.mc_name = item.mc_name;
                            padmc_Machines.mc_plcname = item.plc_name;
                            padmc_Machines.mc_devicekey = item.plc_keyAddr;
                            db.padmc_machines.Add(padmc_Machines);
                        }
                    }
                    foreach (var item in deviceErrorImportModels)
                    {
                        if (!db.padmc_errordevice.ToList().Exists(d => d.device_name == item.device_name))
                        {
                            padmc_errordevice padmc_Errordevice = new padmc_errordevice();
                            padmc_Errordevice.device_name = item.device_name;
                            padmc_Errordevice.device_errorname = item.error_name;
                            padmc_Errordevice.device_descrition = item.error_description;
                            padmc_Errordevice.device_solution = item.error_solution;
                            db.padmc_errordevice.Add(padmc_Errordevice);
                        }
                    }
                    db.SaveChanges();
                }
            });
            btnImportDB.Enabled = true;
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue(appName, Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue(appName, false);
            }

        }

        private async  void btnStartGetData_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew(() =>
            {
                using (PAD_MCEMEntities db = new PAD_MCEMEntities())
                {
                    var machines = db.padmc_machines.ToList();
                    if (machines.Count == 0)
                    {
                        MessageBox.Show("Chưa có dữ liệu máy trong cơ sở dữ liệu");
                        return;
                    }
                    while (true)
                    {
                        foreach (var machine in machines)
                        {
                            if (!string.IsNullOrEmpty(machine.mc_devicekey.Trim()))
                            {
                                var result = plcGetDataRequest(machine.mc_ip, machine.mc_plcname, machine.mc_devicekey);
                                if (result != -1)
                                {
                                    printLogs(result.ToString());
                                }
                            }
                        }
                    }
                }
            });
        }

        private int plcGetDataRequest(string ipPLC, string cpuName, string plcAddr)
        {
            EasyTcpClient client = new EasyTcpClient();
            string _ip = txtIpService.Text.Trim();
            ushort _port = (ushort)Convert.ToInt32(txtPortService.Text);
            client.Connect(_ip, _port, TimeSpan.FromSeconds(30));
            Stopwatch stopwatch_test = new Stopwatch();
            stopwatch_test.Start();

            plc_request plcRequest = new plc_request();
            plcRequest.command = PLC_COMMAND.READ;
            plcRequest.ip = ipPLC;
            plcRequest.cpu_unit = PLC_UNIT_TYPE.UNIT_QNETHER;
            cpuName = "CPU_"+cpuName.ToUpper()+"CPU";
            plcRequest.cpu_type = PLC_LIST.PLC_CPU_TYPE_LST[cpuName];
            plcRequest.port = PLC_PORT.CPU_Q_TCP;


            List<plc_address> plcAddress = new List<plc_address>();
            
            plc_address plc_Address = new plc_address();
            plc_Address.device = plcAddr.Trim();
            plc_Address.value = "";
            plcAddress.Add(plc_Address);
           

            plcRequest.devices = plcAddress;

            // Bien doi sang dang string
            string reqString = JsonConvert.SerializeObject(plcRequest);

            // Gui di va doi gia tri tra ve
            var result = client.SendAndGetReply(reqString, TimeSpan.FromSeconds(1));
            int returnResult = -1;
            if (result != null)
            {
                string resultStr = result.GetString;
                List<plc_address_respon> plc_Address_Respons = JsonConvert.DeserializeObject < List<plc_address_respon>>(resultStr);
                returnResult = Convert.ToInt32(plc_Address_Respons[0].value);
                printLogs(resultStr);
            }
            else
            {
                printLogs("Không có giá trị");
            }
            client.Disconnect();
            return returnResult;
        }

        private void btnGetServiceInfo_Click(object sender, EventArgs e)
        {
            EasyTcpClient client = new EasyTcpClient();
            string _ip = txtIpService.Text.Trim();
            ushort _port = (ushort)Convert.ToInt32(txtPortService.Text);
            client.Connect(_ip, _port, TimeSpan.FromSeconds(30));
            Stopwatch stopwatch_test = new Stopwatch();
            stopwatch_test.Start();

            plc_request plcRequest = new plc_request();
            plcRequest.command = PLC_COMMAND.INFO;
            plcRequest.ip = txtPLCIp.Text.Trim();
            plcRequest.cpu_unit = (int)cmbUnitPlc.SelectedValue; ;
            plcRequest.cpu_type = (int)cmbCPUPlc.SelectedValue; ;
            plcRequest.port = PLC_PORT.CPU_Q_TCP;
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
                return;
            var deviceList = txtAddress.Text.Trim().Split(',');

            List<plc_address> plcAddress = new List<plc_address>();
            foreach (string item in deviceList)
            {
                plc_address plc_Address = new plc_address();
                plc_Address.device = item.Trim();
                plc_Address.value = "";
                plcAddress.Add(plc_Address);
            }

            plcRequest.devices = plcAddress;

            // Bien doi sang dang string
            string reqString = JsonConvert.SerializeObject(plcRequest);

            // Gui di va doi gia tri tra ve
            var a = client.SendAndGetReply(reqString, TimeSpan.FromSeconds(1));

            if (a != null)
            {
                string b = a.GetString;
                printLogs(b);
                txtThoiGianThucHien.Text = stopwatch_test.ElapsedMilliseconds.ToString();
            }
            else
            {
                printLogs("Không có giá trị trả về");
            }
            client.Disconnect();
        }

        private void printLogs(string msg)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy");
            string msgLog = "[" + currentTime + "] " + msg;
            txtLogs.Invoke((MethodInvoker)(() => txtLogs.Text = msgLog + Environment.NewLine + txtLogs.Text));
        }

        private void btnClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLogs.Clear();
        }

        private void numTimeOutReq_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.timeOut = Convert.ToInt32(numTimeOutReq.Value);
            Properties.Settings.Default.Save();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ip = txtIpService.Text.Trim();
            Properties.Settings.Default.port = txtPortService.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?","Thông Báo Xóa Dữ Liệu",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                await Task.Factory.StartNew(() => {
                    using (PAD_MCEMEntities db = new PAD_MCEMEntities())
                    {
                        var all = from c in db.padmc_machines select c;
                        db.padmc_machines.RemoveRange(all);
                        db.SaveChanges();
                        MessageBox.Show("Bạn đã xóa xong toàn bộ dữ liệu");
                    }
                });
            }
        }

        private async void button5_Click_1Async(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông Báo Xóa Dữ Liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await Task.Factory.StartNew(() => {
                    using (PAD_MCEMEntities db = new PAD_MCEMEntities())
                    {
                        var all = from c in db.padmc_errordevice select c;
                        db.padmc_errordevice.RemoveRange(all);
                        db.SaveChanges();
                        MessageBox.Show("Bạn đã xóa xong toàn bộ dữ liệu");
                    }
                });
            }
        }
    }
    class MachineImportModel
    {
        public string mc_ip { get; set; }
        public string mc_name { get; set; }
        public string plc_name { get; set; }
        public string plc_keyAddr { get; set; }
    }
    class DeviceErrorImportModel
    {
        public string device_name { get; set; }
        public string error_name { get; set; }
        public string error_description { get; set; }
        public string error_solution { get; set; }
    }
    class DeviceOfMachineModel
    {
        public string machineIp { get; set; }
        public List<padmc_errordevice> machineDevices { get; set; }
    }
}
