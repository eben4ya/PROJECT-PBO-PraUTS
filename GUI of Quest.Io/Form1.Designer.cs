namespace GUI_of_Quest.Io
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Todolist = new System.Windows.Forms.TabPage();
            this.Notes = new System.Windows.Forms.TabPage();
            this.Pomodoro = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Todolist);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Controls.Add(this.Pomodoro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // Todolist
            // 
            this.Todolist.Location = new System.Drawing.Point(4, 25);
            this.Todolist.Name = "Todolist";
            this.Todolist.Padding = new System.Windows.Forms.Padding(3);
            this.Todolist.Size = new System.Drawing.Size(768, 404);
            this.Todolist.TabIndex = 0;
            this.Todolist.Text = "Todolist";
            this.Todolist.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(4, 25);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(768, 404);
            this.Notes.TabIndex = 1;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // Pomodoro
            // 
            this.Pomodoro.Location = new System.Drawing.Point(4, 25);
            this.Pomodoro.Name = "Pomodoro";
            this.Pomodoro.Padding = new System.Windows.Forms.Padding(3);
            this.Pomodoro.Size = new System.Drawing.Size(768, 404);
            this.Pomodoro.TabIndex = 2;
            this.Pomodoro.Text = "Pomodoro";
            this.Pomodoro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Todolist;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage Pomodoro;
    }
}

