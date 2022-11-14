using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sherlock
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            // timerLabel is not visible
            this.timerLabel.Visible = false;

            // initialize the timerLabel to 20
            this.timerLabel.Text = "20";

            // associate a KeyPress delegate method with the textBox
            this.textBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

            // timer initialize to 1000ms
            this.timer.Interval = 1000;

            // associate a Tick delegate method for each time the timer lapses
            this.timer.Tick += new EventHandler(Timer__Tick);

            // suppress any web/script warnings in the webBrowser control
            this.webBrowser.ScriptErrorsSuppressed = true;

            // associate a WebBrowserDocumentCompleted delegate method with the wb
            this.webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser__DocumentCompleted);

            // navigate the wb to url
            this.webBrowser.Navigate("https://people.rit.edu/dxsigm/sherlock.html");

            // hide the sad pb
            this.sadPictureBox.Visible = false;

            // hide the happy pb
            this.happyPictureBox.Visible = false;

            // disable the exit button
            this.exitButton.Enabled = false;

            // associate a Click delegate method with the exit button
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // could be written more succinctly, but then you do not see the delegate method signature
            //this.exitButton.Click += ExitButton__Click;

        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            // if timerLabel is still "20" then start the timer and show the timerLabel
            if (this.timerLabel.Text == "20")
            {
                this.timer.Start();
                this.timerLabel.Visible = true;
            }

            // if they typed the correct character
            if (this.quickLabel.Text[this.textBox.TextLength] == e.KeyChar)
            {
                // tell .NET to add it to the TextBox
                // (we are not handling it)
                e.Handled = false;

                // hide the sad face
                this.sadPictureBox.Visible = false;

                // show the happy face
                this.happyPictureBox.Visible = true;

                // if they typed the whole sentence
                if (this.textBox.Text + e.KeyChar == this.quickLabel.Text)
                {
                    //enable the Exit button
                    this.exitButton.Enabled = true;

                    // remove the KeyPress event handler from the TextBox
                    this.textBox.KeyPress -= TextBox__KeyPress;
                }
            }
            // else they did not type the correct character
            else
            {
                // tell .NET that we are handling the keypress and it should not show it
                e.Handled = true;

                // show the sad face
                this.sadPictureBox.Visible = true;

                // hide the happy face
                this.happyPictureBox.Visible = false;
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            // if the timer Text is "1"
            if (timerLabel.Text == "1")
            {
                // stop the timer
                timer.Stop();

                // clear the TextBox
                textBox.Text = "";

                // hide the timer label
                timerLabel.Visible = false;

                // reset the timer label to "20"
                timerLabel.Text = "20";

                // hide the sad face
                sadPictureBox.Visible = false;

                // hide the happy face
                happyPictureBox.Visible = false;
            }
            else
            {
                // decrement the textLabel by 1
                timerLabel.Text = (Int32.Parse(timerLabel.Text) - 1).ToString();
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void WebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;

            // get the collection of anchor elements
            HtmlElementCollection htmlElementCollection = wb.Document.GetElementsByTagName("a");

            foreach (HtmlElement htmlElement in htmlElementCollection)
            {
                // associate a click delegate method with each anchor tag
                htmlElement.Click += new HtmlElementEventHandler(Anchor__Click);
            }

            // remove this event handler from the wb
            wb.DocumentCompleted -= WebBrowser__DocumentCompleted;
        }

        private void Anchor__Click(object sender, HtmlElementEventArgs e)
        {
            // // fetch the HtmlElement that was clicked
            HtmlElement htmlElement = (HtmlElement)sender;

            // if the text contains "again"
            if( htmlElement.InnerText.Contains("again"))
            {
                //    // change the text and the style to the last phrase
                htmlElement.InnerText = "I asked you to stop it.";
                htmlElement.Style = "color: purple; font-size: 2.5rem";

                //    // remove the delegate from the element
                htmlElement.Click -= Anchor__Click;

            }
            else if (htmlElement.InnerText.Contains("clicked"))
            {
                // else if the text contains "clicked"
                //    // change the text and style to the second phrase
                htmlElement.InnerText = "You clicked me again.  Now stop it.";
                htmlElement.Style = "color: red; font-size: 2rem";
            }
            else
            {
                // else
                //    // change the text to the first phrase
                htmlElement.InnerText = "You clicked me!";
                htmlElement.Style = "color: blue; font-size: 1.5rem";
            }
        }
    }
}
