namespace JogoGourmetDotNetObjectiveRenan.View
{
    partial class FoodGuessView
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
            mainLabel = new Label();
            yesButton = new Button();
            noButton = new Button();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Location = new Point(133, 34);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(293, 20);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Quer jogar? Se sim, Imagine uma COMIDA.";
            // 
            // yesButton
            // 
            yesButton.Location = new Point(102, 102);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 1;
            yesButton.Text = "Sim";
            yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            noButton.Location = new Point(347, 102);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 2;
            noButton.Text = "Não";
            noButton.UseVisualStyleBackColor = true;
            // 
            // FoodGuess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 167);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(mainLabel);
            Name = "FoodGuess";
            Text = "FoodGuess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private Button yesButton;
        private Button noButton;
    }
}