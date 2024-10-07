using AiChat.Models;
using DevExpress.XtraSplashScreen;
namespace AiChat
{
    public partial class frmChat : DevExpress.XtraEditors.XtraForm
    {
        public frmChat()
        {
            InitializeComponent();
        }
        Service1 chatos = new Service1();
        private List<string> codeBlocks = new List<string>();
        private bool isDialogOpen = false;

        public void HighlightAndAddCopyButton()
        {
            codeBlocks.Clear();
            string inputText = txtGpt.Text;
            string startTag = "```";
            string endTag = "```";
            int startIndex = 0;
            while ((startIndex = inputText.IndexOf(startTag, startIndex)) != -1)
            {
                int endIndex = inputText.IndexOf(endTag, startIndex + startTag.Length);
                if (endIndex == -1) break;
                int codeStartIndex = inputText.IndexOf('\n', startIndex) + 1;
                int codeEndIndex = inputText.LastIndexOf('\n', endIndex) - 1;
                string codeBlock = inputText.Substring(codeStartIndex, codeEndIndex - codeStartIndex + 1).Trim();
                codeBlocks.Add(codeBlock);
                startIndex = endIndex + endTag.Length;
            }

            btnCopyCode.Click -= BtnCopyCode_Click;
            btnCopyCode.Click += BtnCopyCode_Click;
        }

        private void BtnCopyCode_Click(object sender, EventArgs e)
        {
            if (isDialogOpen) return;

            if (codeBlocks.Count > 1)
            {
                isDialogOpen = true;
                ShowCodeSelectionDialog();
            }
            else if (codeBlocks.Count == 1)
            {
                Clipboard.SetText(codeBlocks[0]);
                MessageBox.Show("Kod panoya kopyalandı!");
            }
            else
            {
                MessageBox.Show("Kopyalanacak kod bulunamadı.");
            }
        }

        private void ShowCodeSelectionDialog()
        {
            var selectionForm = new Form
            {
                Text = "Kod Seçimi",
                Size = new Size(400, 300)
            };

            selectionForm.FormClosed += (s, args) => { isDialogOpen = false; };

            var listBox = new ListBox
            {
                Dock = DockStyle.Fill,
                SelectionMode = SelectionMode.One,
                DataSource = codeBlocks.Select((code, index) => $"Kod Bloğu {index + 1}").ToList()
            };

            var copyButton = new Button
            {
                Text = "Kopyala",
                Dock = DockStyle.Bottom
            };

            copyButton.Click += (s, args) =>
            {
                if (listBox.SelectedIndex >= 0)
                {
                    string selectedCode = codeBlocks[listBox.SelectedIndex];
                    Clipboard.SetText(selectedCode);
                    MessageBox.Show("Kod panoya kopyalandı!");
                    selectionForm.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen bir kod bloğu seçin.");
                }
            };

            selectionForm.Controls.Add(listBox);
            selectionForm.Controls.Add(copyButton);
            selectionForm.ShowDialog();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(Form.ActiveForm, typeof(frmLoad), true, true, false);
            var response = await chatos.SendMessageAsync(txtPrompt.Text);
            txtGpt.Text = response;
            HighlightAndAddCopyButton();
            SplashScreenManager.CloseForm(false);
        }

        private void txtPrompt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!e.Shift)
                {
                    btnSend.PerformClick();
                    Thread.Sleep(3000);
                    e.SuppressKeyPress = true;
                }
                else
                {
                    e.SuppressKeyPress = false;
                }
            }
        }
    }
}