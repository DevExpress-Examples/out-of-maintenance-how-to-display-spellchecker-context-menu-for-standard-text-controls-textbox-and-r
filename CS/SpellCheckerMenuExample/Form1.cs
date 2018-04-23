using DevExpress.XtraBars;
using DevExpress.XtraSpellChecker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpellCheckerMenuExample
{
    public partial class Form1 : Form
    {
        PopupMenu popupMenu1 = new PopupMenu();
        BarManager barManager1 = new BarManager();
        
        public Form1()
        {
            InitializeComponent();
            spellChecker1.PrepareSuggestions += spellChecker1_PrepareSuggestions;
            barManager1.Form = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            spellChecker1.ParentContainer = this;
            spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;

            popupMenu1.Manager = barManager1;
            barManager1.QueryShowPopupMenu += barManager1_QueryShowPopupMenu;

            // Add spelling menu to the standard controls.
            barManager1.SetPopupContextMenu(textBox1, popupMenu1);
            barManager1.SetPopupContextMenu(richTextBox1, popupMenu1);
        }

        private void barManager1_QueryShowPopupMenu(object sender, QueryShowPopupMenuEventArgs e)
        {
            Point position = e.Control.PointToClient(e.Position);
            DevExpress.XtraSpellChecker.Rules.SpellCheckErrorBase error = spellChecker1.CalcError(position);
            e.Cancel = error == null;
            List<SpellCheckerCommand> commands = spellChecker1.GetCommandsByError(error);
            if (commands != null)
            {
                popupMenu1.ItemLinks.Clear();
                foreach (SpellCheckerCommand command in commands)
                {
                    BarButtonItem item = new BarButtonItem(barManager1, command.Caption);
                    item.Enabled = command.Enabled;
                    item.Tag = command;
                    item.ItemClick += new ItemClickEventHandler(OnPopupMenuItemClick);
                    popupMenu1.ItemLinks.Add(item);
                }
                BarButtonItem itemShowSpellingForm = new BarButtonItem(barManager1, "Show Spelling Form");
                itemShowSpellingForm.ItemClick += OnPopupMenuShowSpellingForm_ItemClick;
                popupMenu1.ItemLinks.Add(itemShowSpellingForm);
            }
        }

        void OnPopupMenuItemClick(object sender, ItemClickEventArgs e)
        {
            (e.Item.Tag as SpellCheckerCommand).DoCommand();
        }

        void OnPopupMenuShowSpellingForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            spellChecker1.Check(this.ActiveControl);
        }

        #region #preparesuggestions_event
        void spellChecker1_PrepareSuggestions(object sender, PrepareSuggestionsEventArgs e)
        {
            string pattern = "(De|de)[a-z]+x[a-z]*s+";
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex(pattern);
            if (rgx.IsMatch(e.Word)) e.Suggestions.Insert(0, new SuggestionBase("DevExpress", 0));
        }
        #endregion #preparesuggestions_event
    }
}
