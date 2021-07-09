using Newtonsoft.Json;
using ProcessMemoryAccessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTrainer
{
    public partial class frmMain : Form
    {
        private ProcessMemoryCore memCore;
       
        
        public frmMain()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            var p = sizeof(float);
            frmMain_Resize(sender, e);
            cmbTypes.Text = cmbTypes.Items[0].ToString();
           
            /*IntPtr read;
            ReadProcessMemory(ProcessHandle, new IntPtr(0x0072E1D8),  buff, sizeof(int), out read);
            var val = BitConverter.ToInt32(buff, 0);*/

            //pointer check
            //var fp = FindFinalPointer(new IntPtr(0x0074E1E0), new int[] {4,4,4,4,4,4,4,4,4,4,4,0 });
            //var fp = FindFinalPointer(new IntPtr(0x01AB4C9C), new int[] { 0xD0 });

            /*var mem = "0x0074E1D8";
            var val = ReadMemAsInt(mem);
            WriteToMem(mem, 1500);
            mem = "[0x0074E1E0],4,4,4,4,4,4,4,4,4,4,4,0";
            val = ReadMemAsInt(mem);
            WriteToMem(mem, 1500);*/
        }

   

        

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmdUnlock_Click(null, null);
        }

        private void lblDtType_Click(object sender, EventArgs e)
        {

        }

        private void cmdLockWindow_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWindow.Text.Trim().Length > 0)
                {
                    if (memCore == null)
                    {
                        memCore = new ProcessMemoryCore(txtWindow.Text);
                    }
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmdUnlock_Click(object sender, EventArgs e)
        {
            try
            {
                if (memCore != null)
                {
                    memCore.Release();
                    memCore = null;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmeReadMem_Click(object sender, EventArgs e)
        {
            try
            {
                if (memCore != null)
                {
                    if (grdLocs.RowCount > 0)
                    {
                        for (int i = 0; i < grdLocs.RowCount; i++)
                        {
                            var mem = grdLocs[0, i].Value.ToString();
                            var dt = grdLocs[1, i].Value.ToString();
                            if (dt == "int")
                            {
                                grdLocs[2, i].Value = memCore.ReadMemAsInt(mem);
                            }
                            else if (dt == "float")
                            {
                                grdLocs[2, i].Value = memCore.ReadMemAsFloat(mem);
                            }
                            else if (dt == "double")
                            {
                                grdLocs[2, i].Value = memCore.ReadMemAsDouble(mem);
                            }
                            else if (dt == "byte")
                            {
                                grdLocs[2, i].Value = memCore.ReadMemAsByte(mem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < grdLocs.ColumnCount; i++)
            {
                grdLocs.Columns[i].Width = grdLocs.Width / grdLocs.ColumnCount;
            }
            
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtMemOp.Text.Trim().Length > 0 && cmbTypes.Text.Trim().Length > 0)
            {
                grdLocs.Rows.Add(new string[] {txtMemOp.Text, cmbTypes.Text, "" });
            }
        }

        private void cmdFreeze_Click(object sender, EventArgs e)
        {

        }

        private void chkFreeze_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFreeze.Checked)
            {
                for (int i = 0; i < grdLocs.RowCount; i++)
                {
                    var mem = grdLocs[0, i].Value.ToString();
                    var dt = grdLocs[1, i].Value.ToString();
                    var val = grdLocs[2, i].Value.ToString();
                    if (val == "")
                    {
                        val = "0";
                    }
                    
                    Task.Factory.StartNew (() => {
                        while (chkFreeze.Checked)
                        {
                            try
                            {
                                if (dt == "int")
                                {
                                    var ri = memCore.ReadMemAsInt(mem);
                                    if (ri.HasValue)
                                    {
                                        memCore.WriteToMem(mem, int.Parse(val));
                                    }
                                    
                                }
                                else if (dt == "float")
                                {
                                    var rf = memCore.ReadMemAsFloat(mem);
                                    if (rf.HasValue)
                                    {
                                        memCore.WriteToMem(mem, float.Parse(val));
                                    }
                                    
                                }
                                else if (dt == "double")
                                {
                                    var rd = memCore.ReadMemAsDouble(mem);
                                    if (rd.HasValue)
                                    {
                                        memCore.WriteToMem(mem, double.Parse(val));
                                    }

                                }
                                else if (dt == "byte")
                                {
                                    var rd = memCore.ReadMemAsByte(mem);
                                    if (rd.HasValue)
                                    {
                                        memCore.WriteToMem(mem, byte.Parse(val));
                                    }
                                }
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.ToString());
                            }
                            Thread.Sleep(1);
                        }
                    },  TaskCreationOptions.LongRunning);
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (grdLocs.RowCount > 0)
            {


                dynamic[] obj = new ExpandoObject[grdLocs.RowCount];
                dynamic _base = new ExpandoObject();
                for (int i = 0; i < grdLocs.RowCount; i++)
                {
                    var _mem = grdLocs[0, i].Value.ToString();
                    var _dt = grdLocs[1, i].Value.ToString();
                    var _val = grdLocs[2, i].Value.ToString();
                    if (_val == "")
                    {
                        _val = "0";
                    }
                    obj[i] = new ExpandoObject();
                    obj[i].mem = _mem;
                    obj[i].dt = _dt;
                    obj[i].val = _val;

                }
                _base.windowName = txtWindow.Text.Trim();
                _base.mems = obj;
                var srO = JsonConvert.SerializeObject(_base);
                var sfD = new SaveFileDialog();
                sfD.Filter = "JSON|*.json";
                var res = sfD.ShowDialog();

                if (res != DialogResult.Cancel)
                {
                    File.WriteAllText(sfD.FileName, srO);
                }
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
           
            var oFd = new OpenFileDialog();
            oFd.Filter = "JSON|*.json";
            var res = oFd.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                grdLocs.Rows.Clear();
                var str = File.ReadAllText(oFd.FileName);
                dynamic _base = JsonConvert.DeserializeObject<dynamic>(str);
                var objs = _base.mems;

                foreach (var obj in objs)
                {
                    String mm = obj.mem;
                    grdLocs.Rows.Add(new string[] { obj.mem, obj.dt, obj.val });
                }

                txtWindow.Text = _base.windowName;
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (grdLocs.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grdLocs.SelectedRows)
                {
                    grdLocs.Rows.Remove(row);
                }
                
            }
        }

        private void cmdRP_Click(object sender, EventArgs e)
        {
            if (memCore != null)
            {
                memCore.ResetPointerCache();
            }
        }
    }
}
