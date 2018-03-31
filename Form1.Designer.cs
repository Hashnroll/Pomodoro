namespace pomodoro
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.workTimeLabel = new System.Windows.Forms.Label();
      this.restTimeLabel = new System.Windows.Forms.Label();
      this.workBox = new System.Windows.Forms.GroupBox();
      this.workSecondsLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.workMinutesLabel = new System.Windows.Forms.Label();
      this.workRestartButton = new System.Windows.Forms.Button();
      this.workPauseButton = new System.Windows.Forms.Button();
      this.workStartButton = new System.Windows.Forms.Button();
      this.restBox = new System.Windows.Forms.GroupBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.workBox.SuspendLayout();
      this.restBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // workTimeLabel
      // 
      this.workTimeLabel.AutoSize = true;
      this.workTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.workTimeLabel.Location = new System.Drawing.Point(94, 29);
      this.workTimeLabel.Name = "workTimeLabel";
      this.workTimeLabel.Size = new System.Drawing.Size(260, 39);
      this.workTimeLabel.TabIndex = 0;
      this.workTimeLabel.Text = "Рабочее время";
      // 
      // restTimeLabel
      // 
      this.restTimeLabel.AutoSize = true;
      this.restTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.restTimeLabel.Location = new System.Drawing.Point(112, 29);
      this.restTimeLabel.Name = "restTimeLabel";
      this.restTimeLabel.Size = new System.Drawing.Size(244, 39);
      this.restTimeLabel.TabIndex = 1;
      this.restTimeLabel.Text = "Время отдыха";
      // 
      // workBox
      // 
      this.workBox.Controls.Add(this.workSecondsLabel);
      this.workBox.Controls.Add(this.label2);
      this.workBox.Controls.Add(this.workMinutesLabel);
      this.workBox.Controls.Add(this.workTimeLabel);
      this.workBox.Location = new System.Drawing.Point(73, 74);
      this.workBox.Name = "workBox";
      this.workBox.Size = new System.Drawing.Size(500, 439);
      this.workBox.TabIndex = 2;
      this.workBox.TabStop = false;
      // 
      // workSecondsLabel
      // 
      this.workSecondsLabel.AutoSize = true;
      this.workSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.workSecondsLabel.Location = new System.Drawing.Point(255, 188);
      this.workSecondsLabel.Name = "workSecondsLabel";
      this.workSecondsLabel.Size = new System.Drawing.Size(134, 95);
      this.workSecondsLabel.TabIndex = 3;
      this.workSecondsLabel.Text = "00";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(213, 179);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 95);
      this.label2.TabIndex = 2;
      this.label2.Text = ":";
      // 
      // workMinutesLabel
      // 
      this.workMinutesLabel.AutoSize = true;
      this.workMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.workMinutesLabel.Location = new System.Drawing.Point(102, 188);
      this.workMinutesLabel.Name = "workMinutesLabel";
      this.workMinutesLabel.Size = new System.Drawing.Size(134, 95);
      this.workMinutesLabel.TabIndex = 1;
      this.workMinutesLabel.Text = "25";
      // 
      // workRestartButton
      // 
      this.workRestartButton.Location = new System.Drawing.Point(668, 547);
      this.workRestartButton.Name = "workRestartButton";
      this.workRestartButton.Size = new System.Drawing.Size(115, 46);
      this.workRestartButton.TabIndex = 3;
      this.workRestartButton.Text = "Рестарт";
      this.workRestartButton.UseVisualStyleBackColor = true;
      // 
      // workPauseButton
      // 
      this.workPauseButton.Location = new System.Drawing.Point(511, 547);
      this.workPauseButton.Name = "workPauseButton";
      this.workPauseButton.Size = new System.Drawing.Size(124, 46);
      this.workPauseButton.TabIndex = 2;
      this.workPauseButton.Text = "Пауза";
      this.workPauseButton.UseVisualStyleBackColor = true;
      // 
      // workStartButton
      // 
      this.workStartButton.Location = new System.Drawing.Point(361, 547);
      this.workStartButton.Name = "workStartButton";
      this.workStartButton.Size = new System.Drawing.Size(118, 46);
      this.workStartButton.TabIndex = 1;
      this.workStartButton.Text = "Старт";
      this.workStartButton.UseVisualStyleBackColor = true;
      // 
      // restBox
      // 
      this.restBox.Controls.Add(this.restTimeLabel);
      this.restBox.Location = new System.Drawing.Point(579, 74);
      this.restBox.Name = "restBox";
      this.restBox.Size = new System.Drawing.Size(500, 439);
      this.restBox.TabIndex = 3;
      this.restBox.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1152, 621);
      this.Controls.Add(this.workRestartButton);
      this.Controls.Add(this.restBox);
      this.Controls.Add(this.workPauseButton);
      this.Controls.Add(this.workBox);
      this.Controls.Add(this.workStartButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.workBox.ResumeLayout(false);
      this.workBox.PerformLayout();
      this.restBox.ResumeLayout(false);
      this.restBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label workTimeLabel;
    private System.Windows.Forms.Label restTimeLabel;
    private System.Windows.Forms.GroupBox workBox;
    private System.Windows.Forms.Button workRestartButton;
    private System.Windows.Forms.Button workPauseButton;
    private System.Windows.Forms.Button workStartButton;
    private System.Windows.Forms.GroupBox restBox;
    private System.Windows.Forms.Label workSecondsLabel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label workMinutesLabel;
    private System.Windows.Forms.Timer timer1;
  }
}

