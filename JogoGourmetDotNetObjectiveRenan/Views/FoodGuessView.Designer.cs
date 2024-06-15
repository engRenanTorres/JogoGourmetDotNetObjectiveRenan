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
            tipLabel = new Label();
            yesButton = new Button();
            noButton = new Button();
            initButton = new Button();
            guessLabel = new Label();
            SuspendLayout();
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.Location = new Point(133, 34);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(293, 20);
            tipLabel.TabIndex = 0;
            tipLabel.Text = "Quer jogar? Se sim, Imagine uma COMIDA.";
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
            // initButton
            // 
            initButton.Location = new Point(226, 102);
            initButton.Name = "initButton";
            initButton.Size = new Size(94, 29);
            initButton.TabIndex = 3;
            initButton.Text = "Iniciar";
            initButton.UseVisualStyleBackColor = true;
            // 
            // guessLabel
            // 
            guessLabel.AutoSize = true;
            guessLabel.Location = new Point(133, 54);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(50, 20);
            guessLabel.TabIndex = 4;
            guessLabel.Text = "label1";
            // 
            // FoodGuessView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 167);
            Controls.Add(guessLabel);
            Controls.Add(initButton);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(tipLabel);
            Name = "FoodGuessView";
            Text = "FoodGuess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tipLabel;
        private Button yesButton;
        private Button noButton;
        private Button initButton;
        private Label guessLabel;
    }
}