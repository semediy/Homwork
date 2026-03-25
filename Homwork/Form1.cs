using System;
using System.Linq;
using System.Windows.Forms;

namespace Homwork;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    

    private void button1_Click_1(object sender, EventArgs e)
    {
        var controls = GetAllControls(this);

        int total = controls.Count();

        var grouped = controls
            .GroupBy(c => c.GetType().Name)
            .Select(g => $"{g.Key}: {g.Count()}");

        string message = "Кількість елементів на формі: " + total + "\n\n";
        message += string.Join("\n", grouped);

        MessageBox.Show(message); 
    }
    private IEnumerable<Control> GetAllControls(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            yield return control;

            foreach (var child in GetAllControls(control))
                yield return child;
        }
    }
}