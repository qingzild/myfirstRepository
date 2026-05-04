namespace HelloWorldApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Button button1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Hello World";

        button1 = new Button();
        button1.Location = new Point(350, 200);
        button1.Size = new Size(100, 40);
        button1.Text = "点击我";
        button1.Click += button1_Click;
        
        this.Controls.Add(button1);
    }

    #endregion
}
