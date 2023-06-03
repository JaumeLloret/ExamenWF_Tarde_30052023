namespace ExamenWF_Tarde_30052023
{
    partial class ShowBasketballPlayerForm
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
            nameLabel = new Label();
            label2 = new Label();
            positionLabel = new Label();
            label3 = new Label();
            heightLabel = new Label();
            label5 = new Label();
            teamLabel = new Label();
            label4 = new Label();
            updateButton = new Button();
            returnButton = new Button();
            pointsNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pointsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del jugador";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(27, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 2;
            label2.Text = "Posición en la que juega";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(27, 81);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(38, 15);
            positionLabel.TabIndex = 3;
            positionLabel.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Altura del jugador";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(27, 128);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(38, 15);
            heightLabel.TabIndex = 5;
            heightLabel.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 6;
            label5.Text = "Equipo donde juega";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Location = new Point(27, 173);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(38, 15);
            teamLabel.TabIndex = 7;
            teamLabel.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "Puntos por partido";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(164, 216);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 10;
            updateButton.Text = "Actualizar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 256);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(227, 36);
            returnButton.TabIndex = 11;
            returnButton.Text = "Volver";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += ReturnButton_Click;
            // 
            // pointsNumericUpDown
            // 
            pointsNumericUpDown.DecimalPlaces = 2;
            pointsNumericUpDown.Location = new Point(27, 216);
            pointsNumericUpDown.Name = "pointsNumericUpDown";
            pointsNumericUpDown.Size = new Size(120, 23);
            pointsNumericUpDown.TabIndex = 12;
            // 
            // ShowBasketballPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 300);
            ControlBox = false;
            Controls.Add(pointsNumericUpDown);
            Controls.Add(returnButton);
            Controls.Add(updateButton);
            Controls.Add(label4);
            Controls.Add(teamLabel);
            Controls.Add(label5);
            Controls.Add(heightLabel);
            Controls.Add(label3);
            Controls.Add(positionLabel);
            Controls.Add(label2);
            Controls.Add(nameLabel);
            Controls.Add(label1);
            Name = "ShowBasketballPlayerForm";
            Text = "ShowBasketballPlayerForm";
            ((System.ComponentModel.ISupportInitialize)pointsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameLabel;
        private Label label2;
        private Label positionLabel;
        private Label label3;
        private Label heightLabel;
        private Label label5;
        private Label teamLabel;
        private Label label4;
        private Button updateButton;
        private Button returnButton;
        private NumericUpDown pointsNumericUpDown;
    }
}