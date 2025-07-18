namespace Accent_Chooser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            deviceList = new ComboBox();
            saveZonesButton = new Button();
            zoneList = new ComboBox();
            deviceLabel = new Label();
            zoneLabel = new Label();
            userSID = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // deviceList
            // 
            deviceList.FormattingEnabled = true;
            deviceList.Location = new Point(80, 8);
            deviceList.Name = "deviceList";
            deviceList.Size = new Size(282, 23);
            deviceList.TabIndex = 0;
            deviceList.TextChanged += deviceList_TextChanged;
            // 
            // saveZonesButton
            // 
            saveZonesButton.Location = new Point(8, 70);
            saveZonesButton.Name = "saveZonesButton";
            saveZonesButton.Size = new Size(354, 23);
            saveZonesButton.TabIndex = 1;
            saveZonesButton.Text = "Seleccionar";
            saveZonesButton.UseVisualStyleBackColor = true;
            saveZonesButton.Click += saveZonesButton_Click;
            // 
            // zoneList
            // 
            zoneList.FormattingEnabled = true;
            zoneList.Location = new Point(80, 41);
            zoneList.Name = "zoneList";
            zoneList.Size = new Size(282, 23);
            zoneList.TabIndex = 2;
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.Location = new Point(8, 11);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new Size(65, 15);
            deviceLabel.TabIndex = 5;
            deviceLabel.Text = "Dispositivo";
            // 
            // zoneLabel
            // 
            zoneLabel.AutoSize = true;
            zoneLabel.Location = new Point(8, 44);
            zoneLabel.Name = "zoneLabel";
            zoneLabel.Size = new Size(34, 15);
            zoneLabel.TabIndex = 6;
            zoneLabel.Text = "Zona";
            // 
            // userSID
            // 
            userSID.AutoSize = true;
            userSID.Location = new Point(12, 102);
            userSID.Name = "userSID";
            userSID.Size = new Size(38, 15);
            userSID.TabIndex = 7;
            userSID.Text = "label4";
            toolTip1.SetToolTip(userSID, "Haz click para copiar el SID");
            userSID.Click += userSID_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 129);
            Controls.Add(userSID);
            Controls.Add(zoneLabel);
            Controls.Add(deviceLabel);
            Controls.Add(zoneList);
            Controls.Add(saveZonesButton);
            Controls.Add(deviceList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox deviceList;
        private Button saveZonesButton;
        private ComboBox zoneList;
        private Label label1;
        private Label deviceLabel;
        private Label zoneLabel;
        private Label userSID;
        private ToolTip toolTip1;
    }
}
