using System.Drawing;
using System.Windows.Forms;

namespace RemoteControl
{
    public partial class MainForm : Form
    {
        private int _noButtons;
        private ICommand[] _commands;
        static int i = 0;
        public MainForm()
        {
            InitializeComponent();

            _noButtons = 2;

            for (int i = 0; i < _noButtons; i++)
            {
                toolStrip.Items[i].Text = $"Command {i + 1}";
                toolStrip.Items[i].Paint += toolStripButton_Paint;
            }

            toolStrip.Items[_noButtons + 1].Text = "Configure";

            _commands = new ICommand[_noButtons];
            for (int i = 0; i < _noButtons; i++)
                _commands[i] = new NoCommand();
        }

        private void toolStripButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 1, 1, toolStrip.Items[0].Width - 3, toolStrip.Items[0].Height - 3);
            e.Graphics.DrawRectangle(Pens.Black, 2, 2, toolStrip.Items[0].Width - 5, toolStrip.Items[0].Height - 5);
        }

        private void toolStripButton5_Click(object sender, System.EventArgs e)
           
        {
            richTextBox.Clear();
            if (i == 3)
                i = 0;
            if (i == 0)
            {
                _commands[0] = new LightOnCommand(location.Text);
                _commands[1] = new LightOffCommand(location.Text);
            }

            else if (i == 1)
            {
                _commands[0] = new TVOnCommand(location.Text);
                _commands[1] = new TVOffCommand(location.Text);
            }

            else if (i == 2)
            {
                _commands[0] = new CeilingFanOnCommand(location.Text);
                _commands[1] = new CeilingFanOffCommand(location.Text);
            }


            i++;

            // in continuare se atribuie comenzi pentru celelalte trei butoane

            // o abordare mai eleganta este configurarea comenzilor in mod dinamic:
            // utilizatorul poate alege dintr-o lista cate o comanda pentru fiecare buton

            ShowCommandNames();
        }

        private void ShowCommandNames()
        {
            for (int i = 0; i < _noButtons; i++)
                toolStrip.Items[i].Text = _commands[i].GetName();
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            richTextBox.AppendText(_commands[0].Execute(location.Text));
            if(location.Text == "Bathroom")
            {
                if (_commands[0].GetName() == "Light ON")
                    button1.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "TV ON")
                    button2.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "Ceiling fan ON")
                    button3.BackColor = System.Drawing.Color.Green;
            }

            if(location.Text == "Bedroom")
            {
                if (_commands[0].GetName() == "Light ON")
                    button4.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "TV ON")
                    button5.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "Ceiling fan ON")
                    button6.BackColor = System.Drawing.Color.Green;
            }

            if(location.Text == "Kitchen")
            {
                if (_commands[0].GetName() == "Light ON")
                    button12.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "TV ON")
                    button11.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "Ceiling fan ON")
                    button10.BackColor = System.Drawing.Color.Green;
            }

            if(location.Text == "Living Room")
            {
                if (_commands[0].GetName() == "Light ON")
                    button9.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "TV ON")
                    button8.BackColor = System.Drawing.Color.Green;
                if (_commands[0].GetName() == "Ceiling fan ON")
                    button7.BackColor = System.Drawing.Color.Green;
            }
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            richTextBox.AppendText(_commands[1].Execute(location.Text));
            if (location.Text == "Bathroom")
            {
                if (_commands[1].GetName() == "Light OFF")
                    button1.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "TV OFF")
                    button2.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "Ceiling fan OFF")
                    button3.BackColor = System.Drawing.Color.Red;
            }

            if (location.Text == "Bedroom")
            {
                if (_commands[1].GetName() == "Light OFF")
                    button4.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "TV OFF")
                    button5.BackColor = System.Drawing.Color.Red;
                    button6.BackColor = System.Drawing.Color.Red;
            }

            if (location.Text == "Kitchen")
            {
                if (_commands[1].GetName() == "Light OFF")
                    button12.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "TV OFF")
                    button11.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "Ceiling fan OFF")
                    button10.BackColor = System.Drawing.Color.Red;
            }

            if (location.Text == "Living Room")
            {
                if (_commands[1].GetName() == "Light OFF")
                    button9.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "TV OFF")
                    button8.BackColor = System.Drawing.Color.Red;
                if (_commands[1].GetName() == "Ceiling fan OFF")
                    button7.BackColor = System.Drawing.Color.Red;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {

        }

        private void button13_Click(object sender, System.EventArgs e)
        { 
            MessageBox.Show("Welcome to the help menu!                                                                            If you want to use the application, through the 'Configure' button you choose what you want to start by pressing the button repeatedly.     Use the 'Location' button to select the location where to turn on the device / light.                                                                                               After you have met these requirements, in the first buttons you will be able to start / stop, according to the chosen options.");
        }
    }
}
