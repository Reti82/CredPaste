using System.Runtime.InteropServices;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;
using WindowsInput;
using WindowsInput.Native;


namespace CredPaste
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        private const int MOD_CONTROL = 0x0002; // CTRL key
        private const int MOD_SHIFT = 0x0004; // SHIFT key
        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;
        const int VK_TAB = 0x09;
        const int VK_RETURN = 0x0D;

        private SharpClipboard clipboard = new SharpClipboard();
        private string user;
        private string password;
        private string initialClipboardContent;
        private bool isStartup = false;
        private const int WM_CLIPBOARDUPDATE = 0x031D;
        public Form1()
        {
            InitializeComponent();
            Clipboard.Clear();
            bool registration = RegisterHotKey(this.Handle, 1, MOD_CONTROL | MOD_SHIFT, (int)Keys.P);
            var key = "P";
            if (!registration)
            {
                //MessageBox.Show("Hot Key not available");
                bool registration2 = RegisterHotKey(this.Handle, 1, MOD_CONTROL | MOD_SHIFT, (int)Keys.B);
                if (!registration2)
                {
                    MessageBox.Show("Hot Key not available");
                }
                key = "B";

            }
            label3.Text = label3.Text + key;
            button1.Enabled = false;
            isStartup = true;
            LoadNewCredentials(this);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoadNewCredentials(this);
        }
        private void ClipboardChangedEvent(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            if (e.ContentType == SharpClipboard.ContentTypes.Text)
            {
                string currentContent;
                currentContent = Clipboard.GetText();
                // currentContent = clipboard.ClipboardText;

                if (user == null)
                {
                    user = currentContent;
                    Console.WriteLine("First change captured: " + user);
                    UserBox.BackColor = Color.White;
                    UserBox.Text = user;
                    PWBox.BackColor = Color.Green;
                }
                else if (password == null)
                {
                    password = currentContent;
                    Console.WriteLine("Second change captured: ***");
                    PWBox.BackColor = Color.White;
                    PWBox.Text = "***";                   
                    Clipboard.Clear();
                    Console.WriteLine("Both changes captured. Event handler detached.");
                    button1.Enabled = true;
                    clipboard.Dispose();
                }

            }

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                switch (id)
                {
                    case 1:
                        SendCredentials();
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void SendCredentials()
        {
            Thread.Sleep(500);
            var simulator = new InputSimulator();
            if (!PWOnlyCheckBox.Checked)
            {
                //simulator.Keyboard.TextEntry(user);
                SendKeys.Send(user);

                Thread.Sleep(100);
                SendKeys.Send("{TAB}");
                //simulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            }
            Thread.Sleep(100);
            SendKeys.Send(password);
            // simulator.Keyboard.TextEntry(password);
            Thread.Sleep(100);
            SendKeys.Send("{ENTER}");
            //simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);

        }

        private void LoadNewCredentials(Form1 form1)
        {
            var clipboard = new SharpClipboard();
            clipboard = new SharpClipboard();
            Clipboard.Clear();
            
            user = null;
            password = null;
            if (isStartup)
            {
                clipboard.ClipboardChanged += ClipboardChangedEvent;
                isStartup = false;
            }
            UserBox.BackColor = Color.Green;

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
