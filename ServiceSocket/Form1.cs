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
using System.Threading;
using System.IO;


namespace ServiceSocket
{
    public partial class Form1 : Form
    {
        public string data = "";
        public Boolean ServersStatus = false;
        public Thread thread { get; set; }
        public Socket listen { get; set; }
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        Models.Petition auxPetition = new Models.Petition();
        
        public Form1()
        {
            InitializeComponent();
            clearLogFile();
        }

        public void BeginServer()
        {
            
            
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Socket conexion;
            IPEndPoint connet = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);

            try
            {
                listen.Bind(connet);
                listen.Listen(10);
                while (ServersStatus)
                {
                    conexion = listen.Accept();
                    Models.Petition aux = new Models.Petition();
                    aux.datePetition = DateTime.Now;

                    byte[] recibir_info = new byte[100];
                    int array_syze = 0;

                    array_syze = conexion.Receive(recibir_info, 0, recibir_info.Length, 0);
                    Array.Resize(ref recibir_info, array_syze);

                    data = Encoding.Default.GetString(recibir_info);
                    aux.message = data;
                    saveFile(aux.datePetition, aux.message);
                    UpdateLog();
                    MessageParameters(data, aux.datePetition);

                    if (InvokeRequired)
                    {
                        this.Invoke(new Action(() => this.txtDataRecibed.Text = data +" -> "+ aux.datePetition));
                    }
                    else
                        txtDataRecibed.Text += data + " -> " + aux.datePetition;
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error: "+ex);
            }
        }
        public string sortString(String str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string s = new string(arr);
            return s;
        }
        public void MessageParameters(string message, DateTime date)
        {
            auxPetition.datePetition = date;
            auxPetition.totalCaracteres = message.Length;
            auxPetition.secondCharter = message.Substring(1, 1);
            auxPetition.haveUpper = message.Any(c => Char.IsUpper(c));
            auxPetition.numberList = new List<int>();
            
            int countTotalUpper = 0;
            foreach(Char charter in message)
            {
                if (Char.IsUpper(charter))
                    countTotalUpper ++;
            }
            
            string algo = string.Join("", message.ToCharArray().Where(Char.IsDigit));
            algo = sortString(algo);

            auxPetition.countUpper = countTotalUpper;
            auxPetition.countNumbers = auxPetition.numberList.Count;
            string numbertext = string.Empty;



            //writing in view.
            this.Invoke(new Action(() => this.lbrHaveCapitalLetter.Text = auxPetition.haveUpper.ToString()));
            this.Invoke(new Action(() => this.lbrHaveCapitalLetter.Visible = true));
            this.Invoke(new Action(() => this.lbrLength.Text = auxPetition.totalCaracteres.ToString()));
            this.Invoke(new Action(() => this.lbrLength.Visible = true));
            this.Invoke(new Action(() => this.lbrListSortNumber.Text = algo));
            this.Invoke(new Action(() => this.lbrListSortNumber.Visible = true));
            this.Invoke(new Action(() => this.lbrSecondChar.Text = auxPetition.secondCharter.ToString()));
            this.Invoke(new Action(() => this.lbrSecondChar.Visible = true));
            this.Invoke(new Action(() => this.lbrTime.Text = auxPetition.datePetition.ToString()));
            this.Invoke(new Action(() => this.lbrTime.Visible = true));
            this.Invoke(new Action(() => this.lbrTotalCapitalLetter.Text = auxPetition.countUpper.ToString()));
            this.Invoke(new Action(() => this.lbrTotalCapitalLetter.Visible = true));
            this.Invoke(new Action(() => this.lbrTotalNumbers.Text = algo.Length.ToString()));
            this.Invoke(new Action(() => this.lbrTotalNumbers.Visible = true));



        }


        private void btChangeServer_Click(object sender, EventArgs e)
        {

            //change server status
            if (!ServersStatus)
            {
                thread = new Thread(BeginServer);
                ServersStatus = true;
                lbTitle.ForeColor = System.Drawing.Color.Green;
                saveFile(DateTime.Now, "Start Server");
                UpdateLog();
                thread.Start();
            }
            else
            {
                ServersStatus = false;
                lbTitle.ForeColor = System.Drawing.Color.Red;
                saveFile(DateTime.Now, "Stop server");
                UpdateLog();
                //thread.Interrupt();
                listen.Close();
                thread.Abort();


            }
        }
        public void saveFile(DateTime date, string message)
        {
            string Msg = date + " -> " + message ;

            StreamWriter sw = new StreamWriter(dirParameter, true);

            sw.WriteLine(Msg);
            sw.Close();
        }
        public void UpdateLog()
        {
            if (InvokeRequired)
            {

                this.Invoke(new Action(() => this.txtLog.Text = ""));
                this.Invoke(new Action(() => this.txtLog.Text = System.IO.File.ReadAllText(dirParameter)));
            }
            else
            {
                txtLog.Text = "";
                txtLog.Text += System.IO.File.ReadAllText(dirParameter);
            }


        }
        public void clearLogFile()
        {
            StreamWriter strm = File.CreateText(dirParameter);
            strm.Flush();
            strm.Close();
        }
    }
}
