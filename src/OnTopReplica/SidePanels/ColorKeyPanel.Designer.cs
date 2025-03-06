using System;
using System.Windows.Forms;

namespace OnTopReplica.SidePanels {
    partial class ColorKeyPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listColorKeys = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddFromScreen = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkEnabled = new System.Windows.Forms.CheckBox();
            this.textHexColor = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelHex = new System.Windows.Forms.Label();
            this.numTolerance = new System.Windows.Forms.NumericUpDown();
            this.labelTolerance = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).BeginInit();
            this.SuspendLayout();

            // 
            // listColorKeys
            // 
            this.listColorKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listColorKeys.FullRowSelect = true;
            this.listColorKeys.HideSelection = false;
            this.listColorKeys.Location = new System.Drawing.Point(13, 39);
            this.listColorKeys.Name = "listColorKeys";
            this.listColorKeys.Size = new System.Drawing.Size(277, 105);
            this.listColorKeys.TabIndex = 0;
            this.listColorKeys.UseCompatibleStateImageBehavior = false;
            this.listColorKeys.View = System.Windows.Forms.View.List;
            this.listColorKeys.SelectedIndexChanged += new System.EventHandler(this.listColorKeys_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(157, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddFromScreen
            // 
            this.buttonAddFromScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddFromScreen.Location = new System.Drawing.Point(13, 150);
            this.buttonAddFromScreen.Name = "buttonAddFromScreen";
            this.buttonAddFromScreen.Size = new System.Drawing.Size(112, 23);
            this.buttonAddFromScreen.TabIndex = 1;
            this.buttonAddFromScreen.Text = "Pick from screen";
            this.buttonAddFromScreen.UseVisualStyleBackColor = true;
            this.buttonAddFromScreen.Click += new System.EventHandler(this.buttonAddFromScreen_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(131, 150);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(212, 150);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkEnabled
            // 
            this.checkEnabled.AutoSize = true;
            this.checkEnabled.Location = new System.Drawing.Point(13, 16);
            this.checkEnabled.Name = "checkEnabled";
            this.checkEnabled.Size = new System.Drawing.Size(152, 17);
            this.checkEnabled.TabIndex = 0;
            this.checkEnabled.Text = "Enable Color Transparency";
            this.checkEnabled.UseVisualStyleBackColor = true;
            this.checkEnabled.CheckedChanged += new System.EventHandler(this.checkEnabled_CheckedChanged);
            // 
            // textHexColor
            // 
            this.textHexColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textHexColor.Location = new System.Drawing.Point(67, 183);
            this.textHexColor.Name = "textHexColor";
            this.textHexColor.Size = new System.Drawing.Size(84, 20);
            this.textHexColor.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(171, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(63, 13);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Color Keys:";
            // 
            // labelHex
            // 
            this.labelHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHex.AutoSize = true;
            this.labelHex.Location = new System.Drawing.Point(13, 186);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(48, 13);
            this.labelHex.TabIndex = 9;
            this.labelHex.Text = "Hex color:";
            // 
            // numTolerance
            // 
            this.numTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numTolerance.Location = new System.Drawing.Point(223, 183);
            this.numTolerance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numTolerance.Name = "numTolerance";
            this.numTolerance.Size = new System.Drawing.Size(64, 20);
            this.numTolerance.TabIndex = 6;
            this.numTolerance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelTolerance
            // 
            this.labelTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTolerance.AutoSize = true;
            this.labelTolerance.Location = new System.Drawing.Point(167, 186);
            this.labelTolerance.Name = "labelTolerance";
            this.labelTolerance.Size = new System.Drawing.Size(55, 13);
            this.labelTolerance.TabIndex = 11;
            this.labelTolerance.Text = "Tolerance:";
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(215, 238);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Close";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // ColorKeyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelTolerance);
            this.Controls.Add(this.numTolerance);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textHexColor);
            this.Controls.Add(this.checkEnabled);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddFromScreen);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listColorKeys);
            this.Name = "ColorKeyPanel";
            this.Size = new System.Drawing.Size(305, 275);
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ListView listColorKeys;
        private Button buttonAdd;
        private Button buttonAddFromScreen;
        private Button buttonRemove;
        private Button buttonClear;
        private CheckBox checkEnabled;
        private TextBox textHexColor;
        private Label labelTitle;
        private Label labelHex;
        private NumericUpDown numTolerance;
        private Label labelTolerance;
        private Button buttonApply;

        /// <summary>
        /// Gets string resources for ColorKeyPanel
        /// </summary>
        private class Strings {
            private static global::System.Resources.ResourceManager resourceMan;
            
            private static global::System.Globalization.CultureInfo resourceCulture;
            
            /// <summary>
            /// Returns the cached ResourceManager instance used by this class.
            /// </summary>
            private static global::System.Resources.ResourceManager ResourceManager {
                get {
                    if (object.ReferenceEquals(resourceMan, null)) {
                        global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OnTopReplica.SidePanels.ColorKeyPanel", typeof(ColorKeyPanel).Assembly);
                        resourceMan = temp;
                    }
                    return resourceMan;
                }
            }
            
            /// <summary>
            /// Gets or sets the culture for resource lookups
            /// </summary>
            public static global::System.Globalization.CultureInfo Culture {
                get {
                    return resourceCulture;
                }
                set {
                    resourceCulture = value;
                }
            }
            
            public static string TitleLabel {
                get {
                    return ResourceManager.GetString("TitleLabel", resourceCulture);
                }
            }
            
            public static string HexLabel {
                get {
                    return ResourceManager.GetString("HexLabel", resourceCulture);
                }
            }
            
            public static string ToleranceLabel {
                get {
                    return ResourceManager.GetString("ToleranceLabel", resourceCulture);
                }
            }
            
            public static string AddButton {
                get {
                    return ResourceManager.GetString("AddButton", resourceCulture);
                }
            }
            
            public static string AddFromScreenButton {
                get {
                    return ResourceManager.GetString("AddFromScreenButton", resourceCulture);
                }
            }
            
            public static string RemoveButton {
                get {
                    return ResourceManager.GetString("RemoveButton", resourceCulture);
                }
            }
            
            public static string ClearButton {
                get {
                    return ResourceManager.GetString("ClearButton", resourceCulture);
                }
            }
            
            public static string EnabledCheckbox {
                get {
                    return ResourceManager.GetString("EnabledCheckbox", resourceCulture);
                }
            }
            
            public static string ApplyButton {
                get {
                    return ResourceManager.GetString("ApplyButton", resourceCulture);
                }
            }
            
            public static string PanelTitle {
                get {
                    return ResourceManager.GetString("PanelTitle", resourceCulture);
                }
            }
        }
    }
}