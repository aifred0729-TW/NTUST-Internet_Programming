using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udp_draw {
    public partial class Form1 : Form {
        UdpClient udpClient;
        Thread receiveThread;

        bool isDrawing = false;
        Canvas canvas = new Canvas();

        public Form1() {
            InitializeComponent();
            this.Text += $" {getLocalIP()}";
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.TB_RHOST.Text = getLocalIP();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            isDrawing = true;
            canvas.CreateNewLine();
            canvas.DrawOnLine(e.Location);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (!isDrawing) return;
            canvas.DrawOnLine(e.Location);
            this.Invalidate(); // Request to repaint the form
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            isDrawing = false;
            if (TB_RPORT.Text != "") sendPointsData(canvas.LineToStr());
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics graph = e.Graphics;
            foreach (Line line in canvas.lines) {
                Pen pen = new Pen(line.color, 2);
                for (int i = 0; i < line.points.Count - 1; i++) {
                    graph.DrawLine(pen, line.points[i], line.points[i + 1]);
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;
            if (TB_LPORT.Text != "") {
                receiveThread = new Thread(receiveUDP);
                receiveThread.Start();
                BtnConnect.Enabled = false;
            }
        }

        private void sendPointsData(string data) {
            if (BtnConnect.Enabled) return;
            byte[] bytes = Encoding.Default.GetBytes(data);
            int port = int.Parse(TB_RPORT.Text);
            udpClient.Send(bytes, bytes.Length, TB_RHOST.Text, port);
        }

        private void receiveUDP() {
            int port = int.Parse(TB_LPORT.Text);
            udpClient = new UdpClient(port);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            while (true) {
                try {
                    byte[] data = udpClient.Receive(ref endpoint);
                    string message = Encoding.Default.GetString(data);
                    loadPointsData(message);
                    this.Invalidate();
                }
                catch (SocketException ex) {
                    Console.WriteLine($"SocketException: {ex.Message}");
                }
                catch (Exception ex) {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        private void loadPointsData(string data) {
            canvas.AddLineFromStr(data);
        }

        private string getLocalIP() {
            string hostname = Dns.GetHostName();
            IPAddress[] ipList = Dns.GetHostEntry(hostname).AddressList;
            foreach (IPAddress ip in ipList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            return "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            receiveThread?.Abort();
            udpClient?.Close();
        }

        private void ColorRadioButton_CheckedChanged(object sender, EventArgs e) {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked) {
                if (radioButton == BtnRed) canvas.NowColor = Color.Red;
                else if (radioButton == BtnGreen) canvas.NowColor = Color.Green;
                else if (radioButton == BtnBlue) canvas.NowColor = Color.Blue;
                else if (radioButton == BtnBlack) canvas.NowColor = Color.Black;
            }
        }
    }

    public class Line {
        public Color color = Color.Black;
        public List<Point> points = new List<Point>();

        public Line() {
            this.color = Color.Black;
        }

        public Line(Color c) {
            this.color = c;
        }
    }

    public class Canvas {
        public List<Line> lines = new List<Line>();
        public Color NowColor = Color.Black;

        public void CreateNewLine() {
            lines.Add(new Line(NowColor));
        }

        public void DrawOnLine(Point point) {
            if (lines.Count == 0) {
                CreateNewLine();
            }
            lines[lines.Count - 1].points.Add(point);
        }

        public void AddLineFromStr(string data) {
            string[] parts = data.Split(':');
            string colorStr = parts[0];
            Color color = Color.Black;
            switch (colorStr) {
                case "Red":
                    color = Color.Red;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Black":
                    color = Color.Black;
                    break;
            }
            string[] points = parts[1].Split(';');
            Line line = new Line(color);
            foreach (string point in points) {
                string[] coordinates = point.Split(',');
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);
                line.points.Add(new Point(x, y));
            }
            lines.Add(line);
        }

        public string LineToStr() {
            if (lines.Count == 0) {
                return "";
            }
            Line line = lines[lines.Count - 1];
            return $"{NowColor.Name}:{string.Join(";", line.points.Select(p => $"{p.X},{p.Y}"))}";
        }
    }
}
