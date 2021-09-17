using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.InitialDirectory = "C:\\Users\\sandy\\OneDrive\\Documents\\1. PennState\\SWENG421\\Labs\\Lab5\\Lab5\\Lab5";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                try
                {
                    // read all lines and put into array
                    string[] listOfOperations = File.ReadAllLines(filePath);

                    // sort array alphabetically
                    Array.Sort(listOfOperations, StringComparer.InvariantCulture);

                    // print array to console
                    foreach (string operation in listOfOperations)
                    {
                        listBox1.Items.Add(operation);
                    }
                    listBox1.EndUpdate();
                }

                catch (IOException)
                {
                }

            }
        }


        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            Console.WriteLine(selectedItem);    // test


            if (selectedItem != "Log")
            {
                IOperationFactory iof = new OperationFactory();
                IOperation newOperation = iof.createOperation(selectedItem);
                string promptValue = Form1.ShowDialog("Please Input Value: ", selectedItem);
                Console.WriteLine(newOperation.perform(new Input(double.Parse(promptValue))));

            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";

        }

    }

}
