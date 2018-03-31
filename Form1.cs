using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
  public partial class Form1 : Form
  {
    private int workMinutes, workSeconds, restMinutes, restSeconds; //время работы и отдыха

    private void Form1_Load(object sender, EventArgs e)
    {
      //инициализация времени стандартными значениями(25 минут работы, 5 минут отдыха)
      workMinutes = 10; workSeconds = 15;
      restMinutes = 5; restSeconds = 0;
      //показ начальных значений времени
      showTime();
      //запуск таймера
      timer1.Enabled = true;
    }

    private void showTime()
    {
      if (workMinutes >= 10)
        workMinutesLabel.Text = workMinutes.ToString();
      else
      {
        workMinutesLabel.Text = "0";
        workMinutesLabel.Text += workMinutes.ToString();
      }
      if (workSeconds >= 10)
        workSecondsLabel.Text = workSeconds.ToString();
      else
      {
        workSecondsLabel.Text = "0";
        workSecondsLabel.Text += workSeconds.ToString();
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (workSeconds == 0)
      {
        workSeconds = 59;
        workMinutes--;
      }
      else
      {
        workSeconds--;
      }
      showTime();
    }

    public Form1()
    {
      InitializeComponent();
    }


  }
}
