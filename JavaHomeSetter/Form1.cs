/*
 * The MIT License (MIT)

Copyright (c) 2014 cindy_k

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JavaHomeSetter
{
    public partial class Form1 : Form
    {
        String Java_Home = "";
        String OrigJava_Home = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Java_Home = Environment.GetEnvironmentVariable("JAVA_HOME",EnvironmentVariableTarget.Machine);
            OrigJava_Home = Java_Home;
            txtJavaHome.Text = Java_Home;
            
            lblExample.Text = "Example: D:\\Program Files\\Java\\jdk1.7.0_21";
            lblJavaHome.Text = "Set the path to your Java JDK here, without a trailing \\ :";
            lblAbout.Text = "This software is provided by cindy_k to help set Java_home.\n" +
                           "It is licensed under: http://opensource.org/licenses/MIT ";
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select Java JDK Path";
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.Cancel)
                return;

            Java_Home = folderBrowserDialog1.SelectedPath;
            txtJavaHome.Text = Java_Home;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Java_Home = txtJavaHome.Text;
            
            String msg = "This will take a minute to set your JAVA_HOME variable!\n\n" +                   
                         "Original Path: " + OrigJava_Home +
                         "\nNew Path: "+Java_Home;

            DialogResult dr = MessageBox.Show(this, msg, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                // Set cursor as hourglass
                Cursor.Current = Cursors.WaitCursor;
                Environment.SetEnvironmentVariable("JAVA_HOME", Java_Home, EnvironmentVariableTarget.Machine);
                // Set cursor as default arrow
                Cursor.Current = Cursors.Default;
            }
            else
            {
                txtJavaHome.Text = OrigJava_Home;
                Java_Home = OrigJava_Home;
            }
        }

    }
}
