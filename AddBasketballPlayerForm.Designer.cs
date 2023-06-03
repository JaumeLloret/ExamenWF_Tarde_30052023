namespace ExamenWF_Tarde_30052023
{
    partial class AddBasketballPlayerForm
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
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            positionComboBox = new ComboBox();
            label3 = new Label();
            heightMaskedTextBox = new MaskedTextBox();
            label4 = new Label();
            teamTextBox = new TextBox();
            addButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo del Jugador";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(25, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(305, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Posición del Jugador";
            // 
            // positionComboBox
            // 
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Items.AddRange(new object[] { "Base", "Escolta", "Alero", "AlaPivot", "Pivot" });
            positionComboBox.Location = new Point(25, 84);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(305, 23);
            positionComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 4;
            label3.Text = "Altura del Jugador";
            // 
            // heightMaskedTextBox
            // 
            heightMaskedTextBox.Location = new Point(25, 141);
            heightMaskedTextBox.Mask = "0.00";
            heightMaskedTextBox.Name = "heightMaskedTextBox";
            heightMaskedTextBox.Size = new Size(305, 23);
            heightMaskedTextBox.TabIndex = 5;
            heightMaskedTextBox.Validated += HeightMaskedTextBox_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 6;
            label4.Text = "Equipo al que pertenece";
            // 
            // teamTextBox
            // 
            teamTextBox.Location = new Point(25, 197);
            teamTextBox.Name = "teamTextBox";
            teamTextBox.Size = new Size(305, 23);
            teamTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 231);
            addButton.Name = "addButton";
            addButton.Size = new Size(163, 74);
            addButton.TabIndex = 8;
            addButton.Text = "Añadir";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(181, 231);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(157, 74);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // AddBasketballPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 312);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(teamTextBox);
            Controls.Add(label4);
            Controls.Add(heightMaskedTextBox);
            Controls.Add(label3);
            Controls.Add(positionComboBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "AddBasketballPlayerForm";
            Text = "AddBasketballPlayerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private ComboBox positionComboBox;
        private Label label3;
        private MaskedTextBox heightMaskedTextBox;
        private Label label4;
        private TextBox teamTextBox;
        private Button addButton;
        private Button cancelButton;
    }
}