using System;
using System.Drawing;
using System.Windows.Forms;
using OnTopReplica.Properties;

namespace OnTopReplica.SidePanels {
    
    partial class ColorKeyPanel : SidePanel {
        
        public ColorKeyPanel() {
            InitializeComponent();
            Localize();
            
            // Set minimum size to match the designer size
            this.MinimumSize = new System.Drawing.Size(330, 275);
            
            // Initialize color key list
            RefreshColorKeyList();
        }
        
        private void Localize() {
            labelTitle.Text = Strings.TitleLabel;
            labelHex.Text = Strings.HexLabel;
            labelTolerance.Text = Strings.ToleranceLabel;
            buttonAdd.Text = Strings.AddButton;
            buttonAddFromScreen.Text = Strings.AddFromScreenButton;
            buttonRemove.Text = Strings.RemoveButton;
            buttonClear.Text = Strings.ClearButton;
            checkEnabled.Text = Strings.EnabledCheckbox;
            buttonApply.Text = Strings.ApplyButton;
        }
        
        public override string Title {
            get {
                return Strings.PanelTitle;
            }
        }
        
        public override void OnFirstShown(MainForm form) {
            base.OnFirstShown(form);
            
            // Load current state
            checkEnabled.Checked = form.ThumbnailPanel.ColorKeyingEnabled;
            RefreshColorKeyList();
        }
        
        private void RefreshColorKeyList() {
            if (ParentMainForm != null) {
                listColorKeys.Items.Clear();
                
                foreach (var colorKey in ParentMainForm.ThumbnailPanel.ColorKeys.ColorKeys) {
                    var item = new ListViewItem($"#{colorKey.Color.R:X2}{colorKey.Color.G:X2}{colorKey.Color.B:X2} (Tolerance: {colorKey.Tolerance})");
                    item.Tag = colorKey;
                    listColorKeys.Items.Add(item);
                }
                
                UpdateButtonStates();
            }
        }
        
        private void UpdateButtonStates() {
            buttonRemove.Enabled = listColorKeys.SelectedItems.Count > 0;
            buttonClear.Enabled = listColorKeys.Items.Count > 0;
        }
        
        private void checkEnabled_CheckedChanged(object sender, EventArgs e) {
            if (ParentMainForm != null) {
                ParentMainForm.ThumbnailPanel.ColorKeyingEnabled = checkEnabled.Checked;
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e) {
            if (ParentMainForm != null) {
                string hexColor = textHexColor.Text;
                int tolerance = (int)numTolerance.Value;
                
                try {
                    ParentMainForm.ThumbnailPanel.ColorKeys.AddFromHex(hexColor, tolerance);
                    RefreshColorKeyList();
                    textHexColor.Clear();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void buttonAddFromScreen_Click(object sender, EventArgs e) {
            if (ParentMainForm != null) {
                // Request closing the panel while keeping color picking mode
                ParentMainForm.ThumbnailPanel.StartColorPicking();
                OnRequestClosing();
            }
        }
        
        private void buttonRemove_Click(object sender, EventArgs e) {
            if (ParentMainForm != null && listColorKeys.SelectedIndices.Count > 0) {
                int index = listColorKeys.SelectedIndices[0];
                ParentMainForm.ThumbnailPanel.ColorKeys.RemoveAt(index);
                RefreshColorKeyList();
            }
        }
        
        private void buttonClear_Click(object sender, EventArgs e) {
            if (ParentMainForm != null) {
                ParentMainForm.ThumbnailPanel.ColorKeys.Clear();
                RefreshColorKeyList();
            }
        }
        
        private void buttonApply_Click(object sender, EventArgs e) {
            OnRequestClosing();
        }
        
        private void listColorKeys_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateButtonStates();
        }
    }
}