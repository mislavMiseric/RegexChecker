using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace RegexChecker
{
    public partial class RegexCheckerForm : Form
    {
        private Timer m_delayedTextChangedTimer;
        public RegexCheckerForm()
        {
            InitializeComponent();
        }

        // rucna provjera regexa
        private void btnFind_Click(object sender, EventArgs e)
        {
            removeBackColor(rtfInput);
            try
            {
                findAndColor(rtfInput, tbFind.Text);
            }
            catch(ArgumentException)
            {
                if (m_delayedTextChangedTimer != null)
                    m_delayedTextChangedTimer.Stop();
                MessageBox.Show("Regex nije ispravan.");
            }
        }

        // rucna zamjena teksta
        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                rtfOutput.Text = Regex.Replace(rtfInput.Text, tbFind.Text, tbReplace.Text);
            }
            catch(ArgumentException)
            {
                if (m_delayedTextChangedTimer != null)
                    m_delayedTextChangedTimer.Stop();
                MessageBox.Show("Regex nije ispravan.");
            }
        }

        // micanje oznacenog od prijasnjeg izvrsavanja regexa
        private void removeBackColor(RichTextBox text)
        {
            text.SelectAll();
            text.SelectionBackColor = Color.White;
        }

        // pronalazak i oznacavanje teksta koji odgovara regexu
        private void findAndColor(RichTextBox text, string regExpString)
        {
            Regex regExp;
            
            regExp = new Regex(regExpString);

            // pronalazak i oznacavanje teksta koji odgovara regexu
            foreach (Match match in regExp.Matches(text.Text))
            {
                text.Select(match.Index, match.Length);
                text.SelectionBackColor = Color.Yellow;
            }
        }

        // na promjeni ulazong teksta ukljucuje se timer za okidanje regexa (poslije 400ms)
        private void rtfInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            regexTimerStart();
        }

        // na promjeni teksta regex izraza ili teksta za zamjenu ukljucuje se timer za okidanje regexa (poslije 400ms)
        private void regex_TextChanged(object sender, EventArgs e)
        {
            regexTimerStart();
        }

        // logika za okidanje regexa nakon 400ms
        private void regexTimerStart()
        {
            if (m_delayedTextChangedTimer != null)
                m_delayedTextChangedTimer.Stop();

            if (m_delayedTextChangedTimer == null || m_delayedTextChangedTimer.Interval != 400)
            {
                m_delayedTextChangedTimer = new Timer();
                m_delayedTextChangedTimer.Tick += regexAction;
                m_delayedTextChangedTimer.Interval = 400;
            }

            m_delayedTextChangedTimer.Start();
        }


        private void regexAction(object sender, EventArgs e)
        {
            //spremamo poziciju u tekstu (ako smo fokusirani na kontrolu ulaznog teksta)
            int pos = rtfInput.Focused ? rtfInput.SelectionStart + rtfInput.SelectionLength : -1;
            removeBackColor(rtfInput);
            
            try
            {
                findAndColor(rtfInput, tbFind.Text);
                rtfOutput.Text = Regex.Replace(rtfInput.Text, tbFind.Text, tbReplace.Text);
            }
            catch(ArgumentException)
            {
                // gastimo timer ako je regex neispravan
                if (m_delayedTextChangedTimer != null)
                    m_delayedTextChangedTimer.Stop();

                // regex je još u fazi pisanja
                // ako je regex napisan, grešku cemo dobiti pritiskom na gumb find
                return;
            }

            m_delayedTextChangedTimer.Stop();
            //postavljamo se na prethodno spremljenu poziciju u tekstu (ako smo fokusirani na kontrolu ulaznog teksta)
            if (pos != -1)
                rtfInput.Select(pos, 0);
        }
    }
}
