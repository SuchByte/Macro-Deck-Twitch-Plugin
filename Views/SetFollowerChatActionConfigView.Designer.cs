﻿
using SuchByte.MacroDeck.GUI.CustomControls;

namespace SuchByte.TwitchPlugin.Views
{
    partial class SetFollowerChatActionConfigView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioOn = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.radioOff = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.radioToggle = new SuchByte.MacroDeck.GUI.CustomControls.TabRadioButton();
            this.requiredFollowTime = new System.Windows.Forms.NumericUpDown();
            this.unit = new SuchByte.MacroDeck.GUI.CustomControls.RoundedComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requiredFollowTime)).BeginInit();
            this.SuspendLayout();
            // 
            // radioOn
            // 
            this.radioOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioOn.Location = new System.Drawing.Point(325, 196);
            this.radioOn.Name = "radioOn";
            this.radioOn.Size = new System.Drawing.Size(100, 27);
            this.radioOn.TabIndex = 0;
            this.radioOn.TabStop = true;
            this.radioOn.Text = "On";
            this.radioOn.UseVisualStyleBackColor = true;
            // 
            // radioOff
            // 
            this.radioOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioOff.Location = new System.Drawing.Point(431, 196);
            this.radioOff.Name = "radioOff";
            this.radioOff.Size = new System.Drawing.Size(100, 27);
            this.radioOff.TabIndex = 1;
            this.radioOff.TabStop = true;
            this.radioOff.Text = "Off";
            this.radioOff.UseVisualStyleBackColor = true;
            // 
            // radioToggle
            // 
            this.radioToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioToggle.Location = new System.Drawing.Point(460, 120);
            this.radioToggle.Name = "radioToggle";
            this.radioToggle.Size = new System.Drawing.Size(135, 27);
            this.radioToggle.TabIndex = 2;
            this.radioToggle.TabStop = true;
            this.radioToggle.Text = "Toggle";
            this.radioToggle.UseVisualStyleBackColor = true;
            this.radioToggle.Visible = false;
            // 
            // requiredFollowTime
            // 
            this.requiredFollowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.requiredFollowTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requiredFollowTime.ForeColor = System.Drawing.Color.White;
            this.requiredFollowTime.Location = new System.Drawing.Point(396, 255);
            this.requiredFollowTime.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.requiredFollowTime.Name = "requiredFollowTime";
            this.requiredFollowTime.Size = new System.Drawing.Size(75, 26);
            this.requiredFollowTime.TabIndex = 3;
            // 
            // unit
            // 
            this.unit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.unit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unit.Icon = null;
            this.unit.Location = new System.Drawing.Point(482, 255);
            this.unit.Name = "unit";
            this.unit.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.unit.SelectedIndex = -1;
            this.unit.SelectedItem = null;
            this.unit.Size = new System.Drawing.Size(166, 26);
            this.unit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Required follow time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetFollowerChatActionConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requiredFollowTime);
            this.Controls.Add(this.radioToggle);
            this.Controls.Add(this.radioOff);
            this.Controls.Add(this.radioOn);
            this.Name = "SetFollowerChatActionConfigView";
            this.Load += new System.EventHandler(this.SetStateView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requiredFollowTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabRadioButton radioOn;
        private TabRadioButton radioOff;
        private TabRadioButton radioToggle;
        private System.Windows.Forms.NumericUpDown requiredFollowTime;
        private RoundedComboBox unit;
        private System.Windows.Forms.Label label1;
    }
}