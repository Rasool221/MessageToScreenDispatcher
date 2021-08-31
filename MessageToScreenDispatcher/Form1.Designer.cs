namespace MessageToScreenDispatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monitorsListBox = new System.Windows.Forms.ListView();
            this.monitorResolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monitorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dispatchMessageToScreenButton = new System.Windows.Forms.Button();
            this.terminateDispatchedWindowButton = new System.Windows.Forms.Button();
            this.refreshMonitorListButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monitorsListBox);
            this.groupBox1.Location = new System.Drawing.Point(393, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connected Monitor(s)";
            // 
            // monitorsListBox
            // 
            this.monitorsListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.monitorResolution,
            this.monitorName});
            this.monitorsListBox.HideSelection = false;
            this.monitorsListBox.Location = new System.Drawing.Point(6, 14);
            this.monitorsListBox.Name = "monitorsListBox";
            this.monitorsListBox.Size = new System.Drawing.Size(382, 219);
            this.monitorsListBox.TabIndex = 0;
            this.monitorsListBox.UseCompatibleStateImageBehavior = false;
            this.monitorsListBox.View = System.Windows.Forms.View.Details;
            this.monitorsListBox.SelectedIndexChanged += new System.EventHandler(this.monitorsListBox_SelectedIndexChanged);
            // 
            // monitorResolution
            // 
            this.monitorResolution.Text = "Monitor Resolution";
            this.monitorResolution.Width = 222;
            // 
            // monitorName
            // 
            this.monitorName.Text = "Monitor Name";
            this.monitorName.Width = 155;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageText);
            this.groupBox2.Location = new System.Drawing.Point(13, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message To Send";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(7, 20);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(762, 164);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "";
            this.messageText.TextChanged += new System.EventHandler(this.messageText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dispatchMessageToScreenButton);
            this.groupBox3.Controls.Add(this.terminateDispatchedWindowButton);
            this.groupBox3.Controls.Add(this.refreshMonitorListButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 239);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // dispatchMessageToScreenButton
            // 
            this.dispatchMessageToScreenButton.Location = new System.Drawing.Point(7, 201);
            this.dispatchMessageToScreenButton.Name = "dispatchMessageToScreenButton";
            this.dispatchMessageToScreenButton.Size = new System.Drawing.Size(361, 32);
            this.dispatchMessageToScreenButton.TabIndex = 2;
            this.dispatchMessageToScreenButton.Text = "Dispatch Message";
            this.dispatchMessageToScreenButton.UseVisualStyleBackColor = true;
            this.dispatchMessageToScreenButton.Click += new System.EventHandler(this.dispatchMessageToScreenButton_Click);
            // 
            // terminateDispatchedWindowButton
            // 
            this.terminateDispatchedWindowButton.Location = new System.Drawing.Point(7, 162);
            this.terminateDispatchedWindowButton.Name = "terminateDispatchedWindowButton";
            this.terminateDispatchedWindowButton.Size = new System.Drawing.Size(361, 33);
            this.terminateDispatchedWindowButton.TabIndex = 1;
            this.terminateDispatchedWindowButton.Text = "Terminate Message";
            this.terminateDispatchedWindowButton.UseVisualStyleBackColor = true;
            this.terminateDispatchedWindowButton.Click += new System.EventHandler(this.terminateDispatchedWindowButton_Click);
            // 
            // refreshMonitorListButton
            // 
            this.refreshMonitorListButton.Location = new System.Drawing.Point(7, 19);
            this.refreshMonitorListButton.Name = "refreshMonitorListButton";
            this.refreshMonitorListButton.Size = new System.Drawing.Size(367, 33);
            this.refreshMonitorListButton.TabIndex = 0;
            this.refreshMonitorListButton.Text = "Refresh Monitor List";
            this.refreshMonitorListButton.UseVisualStyleBackColor = true;
            this.refreshMonitorListButton.Click += new System.EventHandler(this.refreshMonitorListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Message Dispatcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView monitorsListBox;
        private System.Windows.Forms.ColumnHeader monitorResolution;
        private System.Windows.Forms.ColumnHeader monitorName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button refreshMonitorListButton;
        private System.Windows.Forms.Button dispatchMessageToScreenButton;
        private System.Windows.Forms.Button terminateDispatchedWindowButton;
    }
}

