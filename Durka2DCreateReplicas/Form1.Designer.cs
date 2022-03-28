
namespace Durka2DCreateReplicas
{
    partial class Durka2DCreateReplicas
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.AddedReplicasLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AddReplicasLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.CharacterName = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(456, 286);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(140, 47);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить реплику";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddedReplicasLabel
            // 
            this.AddedReplicasLabel.AutoSize = true;
            this.AddedReplicasLabel.Location = new System.Drawing.Point(13, 22);
            this.AddedReplicasLabel.Name = "AddedReplicasLabel";
            this.AddedReplicasLabel.Size = new System.Drawing.Size(123, 13);
            this.AddedReplicasLabel.TabIndex = 2;
            this.AddedReplicasLabel.Text = "Добавленные реплики";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(372, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 217);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 348);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // AddReplicasLabel
            // 
            this.AddReplicasLabel.AutoSize = true;
            this.AddReplicasLabel.Location = new System.Drawing.Point(372, 22);
            this.AddReplicasLabel.Name = "AddReplicasLabel";
            this.AddReplicasLabel.Size = new System.Drawing.Size(115, 13);
            this.AddReplicasLabel.TabIndex = 5;
            this.AddReplicasLabel.Text = "Добавление реплики";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 123);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SerializeButton
            // 
            this.SerializeButton.BackColor = System.Drawing.Color.OrangeRed;
            this.SerializeButton.Location = new System.Drawing.Point(537, 339);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(137, 56);
            this.SerializeButton.TabIndex = 6;
            this.SerializeButton.Text = "Сохранить XML-файл";
            this.SerializeButton.UseVisualStyleBackColor = false;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.BackColor = System.Drawing.Color.Salmon;
            this.DeserializeButton.Location = new System.Drawing.Point(375, 339);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(137, 56);
            this.DeserializeButton.TabIndex = 7;
            this.DeserializeButton.Text = "Изменить XML- файл";
            this.DeserializeButton.UseVisualStyleBackColor = false;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Location = new System.Drawing.Point(375, 197);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(88, 13);
            this.CharacterName.TabIndex = 9;
            this.CharacterName.Text = "Имя персонажа";
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.AcceptsTab = true;
            this.CharacterNameTextBox.Location = new System.Drawing.Point(375, 228);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(299, 20);
            this.CharacterNameTextBox.TabIndex = 10;
            this.CharacterNameTextBox.TextChanged += new System.EventHandler(this.CharacterNameTextBox_TextChanged);
            // 
            // Durka2DCreateReplicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 407);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Controls.Add(this.CharacterName);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.AddReplicasLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddedReplicasLabel);
            this.Controls.Add(this.AddButton);
            this.Name = "Durka2DCreateReplicas";
            this.Text = "Durka2DCreateReplicas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AddedReplicasLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label AddReplicasLabel;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
    }
}

