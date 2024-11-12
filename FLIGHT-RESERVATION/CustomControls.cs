using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;

namespace FLIGHT_RESERVATION
{
    public class CustomControls
    {
        public class RoundedButton : Button
        {
            private int borderRadius = 20;
            private Color borderColor = Color.FromArgb(118, 58, 238);
            private Color buttonColor = Color.White;
            private int borderSize = 0;

            public RoundedButton()
            {
                FlatStyle = FlatStyle.Flat;
                FlatAppearance.BorderSize = 0;
                Size = new Size(150, 40);
                BackColor = Color.FromArgb(118, 58, 238);
                ForeColor = Color.White;
                Font = new Font("Kantumruy Pro SemiBold", 11.0F, FontStyle.Bold);
                Resize += new EventHandler(Button_Resize);
            }

            private void Button_Resize(object sender, EventArgs e)
            {
                if (borderRadius > Height)
                    borderRadius = Height;
            }

            private GraphicsPath GetFigurePath(Rectangle rect, float radius)
            {
                GraphicsPath path = new GraphicsPath();
                float curveSize = radius * 2F;

                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();

                return path;
            }

            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
                Rectangle rectSurface = ClientRectangle;
                Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
                int smoothSize = 2;

                if (borderSize > 0)
                    smoothSize = borderSize;

                if (borderRadius > 2) //Rounded button
                {
                    using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                    using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                    using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        //Button surface
                        Region = new Region(pathSurface);
                        //Draw surface border for HD result
                        pevent.Graphics.DrawPath(penSurface, pathSurface);

                        //Button border                    
                        if (borderSize >= 1)
                            //Draw control border
                            pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
                else //Normal button
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.None;
                    //Button surface
                    Region = new Region(rectSurface);
                    //Button border
                    if (borderSize >= 1)
                    {
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        {
                            penBorder.Alignment = PenAlignment.Inset;
                            pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                        }
                    }
                }
            }

            [Category("Appearance")]
            public int BorderRadius
            {
                get => borderRadius;
                set { borderRadius = value; Invalidate(); }
            }
        }

        [DefaultEvent("TextChanged")]
        [ToolboxItem(true)]
        [ToolboxBitmap(typeof(TextBox))]
        public class RoundedTextBox : UserControl
        {
            private Color borderColor = ColorTranslator.FromHtml("#F4F4F4");
            private int borderSize = 1;
            private bool underlinedStyle = false;
            private Color borderFocusColor = Color.FromArgb(118, 58, 238);
            private bool isFocused = false;
            private int borderRadius = 10;
            private Color placeholderColor = Color.DarkGray;
            private string placeholderText = "";
            private bool isPlaceholderActive = true;

            private TextBox textBox1;

            public event EventHandler TextChanged;

            public RoundedTextBox()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                textBox1 = new TextBox();
                SuspendLayout();
                // 
                // textBox1
                // 
                textBox1.BorderStyle = BorderStyle.None;
                textBox1.Dock = DockStyle.Fill;
                textBox1.Location = new Point(10, 7);
                textBox1.Name = "textBox1";
                textBox1.Size = new Size(230, 15);
                textBox1.TabIndex = 0;
                textBox1.Click += new EventHandler(textBox1_Click);
                textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
                textBox1.Enter += new EventHandler(textBox1_Enter);
                textBox1.Leave += new EventHandler(textBox1_Leave);
                textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                // 
                // RoundedTextBox
                // 
                AutoScaleMode = AutoScaleMode.None;
                BackColor = SystemColors.Window;
                Controls.Add(textBox1);
                Font = new Font("Kantumruy Pro SemiBold", 11.0F, FontStyle.Bold);
                ForeColor = Color.FromArgb(64, 64, 64);
                Margin = new Padding(4);
                Name = "RoundedTextBox";
                Padding = new Padding(10, 7, 10, 7);
                Size = new Size(250, 30);
                ResumeLayout(false);
                PerformLayout();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                Graphics g = e.Graphics;

                if (borderRadius > 1)
                {
                    var rectBorderSmooth = this.ClientRectangle;
                    var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                    int smoothSize = borderSize > 0 ? borderSize : 1;

                    using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                    using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                    using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                    using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                    {
                        this.Region = new Region(pathBorderSmooth);
                        g.SmoothingMode = SmoothingMode.AntiAlias;

                        penBorder.Alignment = PenAlignment.Center;
                        if (underlinedStyle)
                        {
                            g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            g.DrawPath(penBorderSmooth, pathBorderSmooth);
                            g.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }

            private GraphicsPath GetFigurePath(Rectangle rect, float radius)
            {
                GraphicsPath path = new GraphicsPath();
                float curveSize = radius * 2F;

                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
                return path;
            }

            // Properties
            [Category("Appearance")]
            public Color BorderColor
            {
                get => borderColor;
                set { borderColor = value; Invalidate(); }
            }

            [Category("Appearance")]
            public int BorderSize
            {
                get => borderSize;
                set { borderSize = value; Invalidate(); }
            }

            [Category("Appearance")]
            public bool UnderlinedStyle
            {
                get => underlinedStyle;
                set { underlinedStyle = value; Invalidate(); }
            }

            [Category("Appearance")]
            public Color BorderFocusColor
            {
                get => borderFocusColor;
                set => borderFocusColor = value;
            }

            [Category("Appearance")]
            public int BorderRadius
            {
                get => borderRadius;
                set { borderRadius = value; Invalidate(); }
            }

            [Category("Appearance")]
            public Color PlaceholderColor
            {
                get => placeholderColor;
                set => placeholderColor = value;
            }

            [Category("Appearance")]
            public string PlaceholderText
            {
                get => placeholderText;
                set
                {
                    placeholderText = value;
                    textBox1.Text = "";
                    SetPlaceholder();
                }
            }

            public override Color BackColor
            {
                get => base.BackColor;
                set
                {
                    base.BackColor = value;
                    textBox1.BackColor = value;
                }
            }

            public override Color ForeColor
            {
                get => base.ForeColor;
                set
                {
                    base.ForeColor = value;
                    textBox1.ForeColor = value;
                }
            }

            public override Font Font
            {
                get => base.Font;
                set
                {
                    base.Font = value;
                    textBox1.Font = value;
                    if (DesignMode)
                        UpdateControlHeight();
                }
            }

            public string Text
            {
                get
                {
                    if (isPlaceholderActive) return "";
                    return textBox1.Text;
                }
                set
                {
                    textBox1.Text = value;
                    SetPlaceholder();
                }
            }

            public bool PasswordChar
            {
                get => textBox1.UseSystemPasswordChar;
                set => textBox1.UseSystemPasswordChar = value;
            }

            public bool Multiline
            {
                get => textBox1.Multiline;
                set { textBox1.Multiline = value; UpdateControlHeight(); }
            }

            private void SetPlaceholder()
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
                {
                    isPlaceholderActive = true;
                    textBox1.Text = placeholderText;
                    textBox1.ForeColor = placeholderColor;
                    if (PasswordChar) textBox1.UseSystemPasswordChar = false;
                }
            }

            private void RemovePlaceholder()
            {
                if (isPlaceholderActive && placeholderText != "")
                {
                    isPlaceholderActive = false;
                    textBox1.Text = "";
                    textBox1.ForeColor = this.ForeColor;
                    if (PasswordChar) textBox1.UseSystemPasswordChar = true;
                }
            }

            private void UpdateControlHeight()
            {
                if (!textBox1.Multiline)
                {
                    int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                    textBox1.Multiline = true;
                    textBox1.MinimumSize = new Size(0, txtHeight);
                    textBox1.Multiline = false;
                    this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
                }
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                if (TextChanged != null)
                    TextChanged.Invoke(sender, e);
            }

            private void textBox1_Click(object sender, EventArgs e)
            {
                this.OnClick(e);
            }

            private void textBox1_Enter(object sender, EventArgs e)
            {
                isFocused = true;
                this.Invalidate();
                RemovePlaceholder();
            }

            private void textBox1_Leave(object sender, EventArgs e)
            {
                isFocused = false;
                this.Invalidate();
                SetPlaceholder();
            }

            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
                this.OnKeyPress(e);
            }
        }
    }
}
