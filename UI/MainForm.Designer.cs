
namespace AudioProcessHelper.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.windowSplitter = new System.Windows.Forms.SplitContainer();
            this._heading = new System.Windows.Forms.Label();
            this._descriptionWrapper = new System.Windows.Forms.Panel();
            this._description = new System.Windows.Forms.Label();
            this._descriptionHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._startButton = new System.Windows.Forms.Button();
            this._selectionWrapper = new System.Windows.Forms.Panel();
            this._processList = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._processNameInput = new System.Windows.Forms.TextBox();
            this._buttonWrapper = new System.Windows.Forms.Panel();
            this._removeButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowSplitter)).BeginInit();
            this.windowSplitter.Panel1.SuspendLayout();
            this.windowSplitter.Panel2.SuspendLayout();
            this.windowSplitter.SuspendLayout();
            this._descriptionWrapper.SuspendLayout();
            this.panel1.SuspendLayout();
            this._selectionWrapper.SuspendLayout();
            this.panel2.SuspendLayout();
            this._buttonWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowSplitter
            // 
            this.windowSplitter.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.windowSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.windowSplitter.IsSplitterFixed = true;
            this.windowSplitter.Location = new System.Drawing.Point(0, 0);
            this.windowSplitter.Name = "windowSplitter";
            this.windowSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // windowSplitter.Panel1
            // 
            this.windowSplitter.Panel1.Controls.Add(this._heading);
            // 
            // windowSplitter.Panel2
            // 
            this.windowSplitter.Panel2.Controls.Add(this._descriptionWrapper);
            this.windowSplitter.Panel2.Controls.Add(this.panel1);
            this.windowSplitter.Panel2.Controls.Add(this._selectionWrapper);
            this.windowSplitter.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowSplitter.Size = new System.Drawing.Size(654, 336);
            this.windowSplitter.SplitterDistance = 40;
            this.windowSplitter.TabIndex = 0;
            // 
            // _heading
            // 
            this._heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._heading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this._heading.Dock = System.Windows.Forms.DockStyle.Fill;
            this._heading.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._heading.Location = new System.Drawing.Point(0, 0);
            this._heading.Name = "_heading";
            this._heading.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._heading.Size = new System.Drawing.Size(654, 40);
            this._heading.TabIndex = 0;
            this._heading.Text = "Select the Processes that should be raised";
            this._heading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _descriptionWrapper
            // 
            this._descriptionWrapper.Controls.Add(this._description);
            this._descriptionWrapper.Controls.Add(this._descriptionHeading);
            this._descriptionWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionWrapper.Location = new System.Drawing.Point(200, 0);
            this._descriptionWrapper.Name = "_descriptionWrapper";
            this._descriptionWrapper.Padding = new System.Windows.Forms.Padding(0, 15, 15, 0);
            this._descriptionWrapper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._descriptionWrapper.Size = new System.Drawing.Size(454, 237);
            this._descriptionWrapper.TabIndex = 5;
            // 
            // _description
            // 
            this._description.Dock = System.Windows.Forms.DockStyle.Fill;
            this._description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._description.Location = new System.Drawing.Point(0, 59);
            this._description.Name = "_description";
            this._description.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this._description.Size = new System.Drawing.Size(439, 178);
            this._description.TabIndex = 8;
            this._description.Text = resources.GetString("_description.Text");
            // 
            // _descriptionHeading
            // 
            this._descriptionHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this._descriptionHeading.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._descriptionHeading.Location = new System.Drawing.Point(0, 15);
            this._descriptionHeading.Name = "_descriptionHeading";
            this._descriptionHeading.Size = new System.Drawing.Size(439, 44);
            this._descriptionHeading.TabIndex = 7;
            this._descriptionHeading.Text = "What am I going to do?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._startButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 237);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.panel1.Size = new System.Drawing.Size(454, 55);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "So if you\'re ready hit the button!";
            // 
            // _startButton
            // 
            this._startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(20)))));
            this._startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startButton.Location = new System.Drawing.Point(330, 15);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(109, 25);
            this._startButton.TabIndex = 4;
            this._startButton.Text = "Go!";
            this._startButton.UseVisualStyleBackColor = false;
            // 
            // _selectionWrapper
            // 
            this._selectionWrapper.Controls.Add(this._processList);
            this._selectionWrapper.Controls.Add(this.panel2);
            this._selectionWrapper.Controls.Add(this._buttonWrapper);
            this._selectionWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this._selectionWrapper.Location = new System.Drawing.Point(0, 0);
            this._selectionWrapper.Name = "_selectionWrapper";
            this._selectionWrapper.Padding = new System.Windows.Forms.Padding(15);
            this._selectionWrapper.Size = new System.Drawing.Size(200, 292);
            this._selectionWrapper.TabIndex = 3;
            // 
            // _processList
            // 
            this._processList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._processList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._processList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._processList.ForeColor = System.Drawing.Color.White;
            this._processList.FormattingEnabled = true;
            this._processList.Location = new System.Drawing.Point(15, 15);
            this._processList.Name = "_processList";
            this._processList.Size = new System.Drawing.Size(170, 192);
            this._processList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this._processNameInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 207);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel2.Size = new System.Drawing.Size(170, 38);
            this.panel2.TabIndex = 4;
            // 
            // _processNameInput
            // 
            this._processNameInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this._processNameInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this._processNameInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._processNameInput.Location = new System.Drawing.Point(0, 15);
            this._processNameInput.MaxLength = 50;
            this._processNameInput.Name = "_processNameInput";
            this._processNameInput.PlaceholderText = "Process Name";
            this._processNameInput.Size = new System.Drawing.Size(170, 23);
            this._processNameInput.TabIndex = 0;
            // 
            // _buttonWrapper
            // 
            this._buttonWrapper.Controls.Add(this._removeButton);
            this._buttonWrapper.Controls.Add(this._addButton);
            this._buttonWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonWrapper.Location = new System.Drawing.Point(15, 245);
            this._buttonWrapper.Name = "_buttonWrapper";
            this._buttonWrapper.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this._buttonWrapper.Size = new System.Drawing.Size(170, 32);
            this._buttonWrapper.TabIndex = 3;
            // 
            // _removeButton
            // 
            this._removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._removeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeButton.Location = new System.Drawing.Point(95, 7);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(75, 25);
            this._removeButton.TabIndex = 2;
            this._removeButton.Text = "Remove";
            this._removeButton.UseVisualStyleBackColor = false;
            // 
            // _addButton
            // 
            this._addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addButton.Location = new System.Drawing.Point(0, 7);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 25);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(654, 336);
            this.Controls.Add(this.windowSplitter);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Text = "Fix My Microphone";
            this.windowSplitter.Panel1.ResumeLayout(false);
            this.windowSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowSplitter)).EndInit();
            this.windowSplitter.ResumeLayout(false);
            this._descriptionWrapper.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this._selectionWrapper.ResumeLayout(false);
            this._selectionWrapper.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._buttonWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer windowSplitter;
        private System.Windows.Forms.Label _heading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Panel _descriptionWrapper;
        private System.Windows.Forms.Panel _selectionWrapper;
        private System.Windows.Forms.CheckedListBox _processList;
        private System.Windows.Forms.Panel _buttonWrapper;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _processNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _descriptionHeading;
        private System.Windows.Forms.Label _description;
    }
}

