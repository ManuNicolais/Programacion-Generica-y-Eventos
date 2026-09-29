using System;
using System.Drawing;
using System.Windows.Forms;

public class LienzoForm : Form
{
    private bool dibujando = false;
    private Point puntoInicio;
    private Panel panelLienzo;

    public LienzoForm()
    {
        this.Text = "Lienzo de Dibujo";
        this.Size = new Size(800, 600);

        panelLienzo = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.White
        };

        panelLienzo.MouseDown += new MouseEventHandler(PanelLienzo_MouseDown);
        panelLienzo.MouseMove += new MouseEventHandler(PanelLienzo_MouseMove);
        panelLienzo.MouseUp += new MouseEventHandler(PanelLienzo_MouseUp);

        this.Controls.Add(panelLienzo);
    }

    private void PanelLienzo_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            dibujando = true;
            puntoInicio = e.Location;
        }
    }

    private void PanelLienzo_MouseMove(object sender, MouseEventArgs e)
    {
        if (dibujando)
        {
            using (Graphics g = panelLienzo.CreateGraphics())
            {
                g.DrawLine(Pens.Black, puntoInicio, e.Location);
            }
            puntoInicio = e.Location;
        }
    }

    private void PanelLienzo_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            dibujando = false;
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new LienzoForm());
    }
}
