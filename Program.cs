using System; //EventHandler
using System.Windows.Forms; //Form
using System.Drawing; //Point
using System.Drawing.Drawing2D; //CircularButton 
using System.Text; //Encoding
using System.IO;
using System.Media;
using System.Collections.Generic;

class CircularButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath gp = new GraphicsPath();
        gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(gp);
        base.OnPaint(pevent);

    }
}

class MyForm : Form
{
    private Button windInstruments;
    private Button percussions;
    private Button btnIdShow;
    private Button btnIdShow1;
    private MainMenu menu;
    private Button btnClose;
    private Button btn, btn2, btn3, btn4, btn5,btn8,btn7,btn9;
    private Label lb;
    private TextBox tbox;
    private PictureBox pb;
    private List<string> workers = new List<string>();
    public MyForm()
    {
        int i = 0;
        ToolTip tooltip = new ToolTip();
        //form
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(640, 600); //form size
        BackColor = Color.FromArgb(127, 250, 212);//form color
        FormBorderStyle = FormBorderStyle.Fixed3D;

    

        btnClose = new Button();
        btnClose.Size = new Size(50, 50);
        btnClose.Location = new Point(50, 20);
        btnClose.Text = "Close";
        btnClose.Font = new Font("", 8F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
        btnClose.BackColor = Color.Pink;
        btnClose.ForeColor = Color.White;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.FlatAppearance.BorderColor = Color.Black;
        btnClose.FlatAppearance.BorderSize = 3;
        Controls.Add(btnClose);
        btnClose.Click += new EventHandler(btnClose_Click);

        //button 1
        btn = new CircularButton();
        btn.Size = new Size(80, 80);
        btn.Location = new Point(100, 200);
        btn.Text = "Music store";
        btn.BackColor = Color.Pink;
        btn.ForeColor = Color.Black;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderColor = Color.Red;
        btn.FlatAppearance.BorderSize = 0;
        Controls.Add(btn);
        btn.Click += new EventHandler(btn_Click);

        //button 2
        btn2 = new CircularButton();
        btn2.Size = new Size(80, 80);
        btn2.Location = new Point(200, 200);
        btn2.Text = "Minimum price";
        btn2.BackColor = Color.Pink;
        btn2.ForeColor = Color.Black;
        btn2.FlatStyle = FlatStyle.Flat;
        btn2.FlatAppearance.BorderColor = Color.Blue;
        btn2.FlatAppearance.BorderSize = 0;
        Controls.Add(btn2);
        btn2.Click += new EventHandler(btn2_Click);

        //button 3
        btn3 = new CircularButton();
        btn3.Size = new Size(80, 80);
        btn3.Location = new Point(300, 200);
        btn3.Text = "maximum price";
        btn3.BackColor = Color.Pink;
        btn3.ForeColor = Color.Black;
        btn3.FlatStyle = FlatStyle.Flat;
        btn3.FlatAppearance.BorderColor = Color.Blue;
        btn3.FlatAppearance.BorderSize = 0;
        Controls.Add(btn3);
        btn3.Click += new EventHandler(btn3_Click);

        //button 4
        btn4 = new CircularButton();
        btn4.Size = new Size(80, 80);
        btn4.Location = new Point(400, 200);
        btn4.Text = "average price";
        btn4.BackColor = Color.Pink;
        btn4.ForeColor = Color.Black;
        btn4.FlatStyle = FlatStyle.Flat;
        btn4.FlatAppearance.BorderColor = Color.Blue;
        btn4.FlatAppearance.BorderSize = 0;
        Controls.Add(btn4);
        btn4.Click += new EventHandler(btn4_Click);

        btn4 = new CircularButton();
        btn4.Size = new Size(80, 80);
        btn4.Location = new Point(500, 200);
        btn4.Text = "play music";
        btn4.BackColor = Color.Red;
        btn4.ForeColor = Color.Black;
        btn4.FlatStyle = FlatStyle.Flat;
        btn4.FlatAppearance.BorderColor = Color.Blue;
        btn4.FlatAppearance.BorderSize = 0;
        Controls.Add(btn4);
        btn4.Click += new EventHandler(btn5_Click);

        btn5 = new CircularButton();
        btn5.Size = new Size(80, 80);
        btn5.Location = new Point(290, 290);
        btn5.Text = "add workers";
        btn5.BackColor = Color.HotPink;
        btn5.ForeColor = Color.Black;
        btn5.FlatStyle = FlatStyle.Flat;
        btn5.FlatAppearance.BorderColor = Color.Blue;
        btn5.FlatAppearance.BorderSize = 0;
        Controls.Add(btn5);
        btn5.Click += new EventHandler(btn5_Click);

        btn8 = new CircularButton();
        btn8.Size = new Size(80, 80);
        btn8.Location = new Point(200, 290);
        btn8.Text = "remove workers";
        btn8.BackColor = Color.HotPink;
        btn8.ForeColor = Color.Black;
        btn8.FlatStyle = FlatStyle.Flat;
        btn8.FlatAppearance.BorderColor = Color.Blue;
        btn8.FlatAppearance.BorderSize = 0;
        Controls.Add(btn8);
        btn8.Click += new EventHandler(btn8_Click);

        //tmuna
        pb = new PictureBox();
        pb.ImageLocation = "C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\cats.jpg";
        pb.Location = new System.Drawing.Point(0, 0);
        pb.Size = new System.Drawing.Size(640, 600);
        pb.SizeMode = PictureBoxSizeMode.Zoom;
        tooltip.SetToolTip(this.pb, "");
        Controls.Add(this.pb);
        
        this.menu = new MainMenu();
        MenuItem m1 = new MenuItem("our people");
        MenuItem m2 = new MenuItem("stores");
        MenuItem m3 = new MenuItem("collections");
        MenuItem m4 = new MenuItem("about us");
       
        this.menu.MenuItems.Add(m1);
        this.menu.MenuItems.Add(m2);
        this.menu.MenuItems.Add(m3);
        this.menu.MenuItems.Add(m4);

        MenuItem i1 = new MenuItem("Workers");
        m1.MenuItems.Add(i1);
        MenuItem i2 = new MenuItem("Managers");
        m1.MenuItems.Add(i2);
        MenuItem i3 = new MenuItem("Staff details");
        m1.MenuItems.Add(i3);
        
        i1.Click += Workers;
        i2.Click += Managers;
        i3.Click += StaffDetails;
        m2.Click += ourStores;
        m3.Click += MoreItems;
        m4.Click += aboutUs;
        Menu = menu;

    }
    private void Workers(object sender, EventArgs e)
    {
        TextReader tr = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\workers.txt");
        string s;
        string abc = "";
        while ((s = tr.ReadLine()) != null)
        {
            abc += s + '\n';
        }
        tr.Close();
        MessageBox.Show(abc);
    }
    // Managers
    private void Managers(object sender, EventArgs e)
    {
        TextReader tr = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\manager.txt");
        string s;
        string abc = "";
        while ((s = tr.ReadLine()) != null)
        {
            abc += s + '\n';
        }
        tr.Close();
        MessageBox.Show(abc);
    }

    //StaffDetails
    private void StaffDetails(object sender, EventArgs e)
    {
        Form form3 = new Form();
        form3.StartPosition = FormStartPosition.CenterScreen;
        form3.ClientSize = new Size(500, 500); //form size
        form3.BackColor = Color.FromArgb(255, 215, 0);//form color
        form3.FormBorderStyle = FormBorderStyle.Fixed3D;
        form3.Show();
        form3.BackgroundImage = Image.FromFile("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\backround3.jpg");

        //label
        lb = new Label();
        lb.AutoSize = true;
        lb.Font = new Font("Cooper black", 16F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        lb.Location = new Point(100, 75); //label location
        lb.Text = "workers info - high security!!!";
        lb.ForeColor = Color.Black;
        form3.Controls.Add(lb);

        //buttonToIdShow
        btnIdShow = new Button();
        btnIdShow.Size = new Size(200, 70);
        btnIdShow.Location = new Point(150, 200);
        btnIdShow.Text = "workers ID: ";
        btnIdShow.Font = new Font("AmericanCaptain", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        btnIdShow.BackColor = Color.Pink;
        btnIdShow.ForeColor = Color.White;
        btnIdShow.FlatStyle = FlatStyle.Flat;
        btnIdShow.FlatAppearance.BorderColor = Color.Black;
        btnIdShow.FlatAppearance.BorderSize = 3;
        form3.Controls.Add(btnIdShow);
        btnIdShow.Click += new EventHandler(btnIdShow_Click);

        void btnIdShow_Click(object sender4, EventArgs e4)
        {
            TextReader tr = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\workersID.txt");
            string x;
            string abc = "";
            while ((x = tr.ReadLine()) != null)
            {
                abc += x + '\n';
            }
            tr.Close();
            MessageBox.Show(abc);
        }

        //buttonToIdShow1
        btnIdShow1 = new Button();
        btnIdShow1.Size = new Size(200, 70);
        btnIdShow1.Location = new Point(150, 300);
        btnIdShow1.Text = "managers ID: ";
        btnIdShow1.Font = new Font("AmericanCaptain", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        btnIdShow1.BackColor = Color.Pink;
        btnIdShow1.ForeColor = Color.White;
        btnIdShow1.FlatStyle = FlatStyle.Flat;
        btnIdShow1.FlatAppearance.BorderColor = Color.Black;
        btnIdShow1.FlatAppearance.BorderSize = 3;
        form3.Controls.Add(btnIdShow1);
        btnIdShow1.Click += new EventHandler(btnIdShow1_Click);

        void btnIdShow1_Click(object sender4, EventArgs e4)
        {
            TextReader tr = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\‏‏managerID.txt");
            string x;
            string abc = "";
            while ((x = tr.ReadLine()) != null)
            {
                abc += x + '\n';
            }
            tr.Close();
            MessageBox.Show(abc);
        }
    }
    //our stores
    private void ourStores(object sender, EventArgs e)
    {
        MessageBox.Show("Our stores in: LA, New York, Israel and Brazil");
    }

    //abous us
    private void aboutUs(object sender, EventArgs e8)
    {
       MessageBox.Show("This musical instrument store was created out of a love for music.\n The Creator Sendi Shira Bernstein has set up this pop - up store at cheap prices for all music lovers.\n In this store you will find pianos, keyboards, guitars, drums, wind instruments and more.\n What are you waiting for ? Start buying! :) ");
    }
    //MoreItems
    private void MoreItems(object sender5, EventArgs e5)
    {
        Form MoreItems = new Form();
        MoreItems.StartPosition = FormStartPosition.CenterScreen;
        MoreItems.ClientSize = new Size(500, 500); //form size
        MoreItems.BackColor = Color.FromArgb(255, 215, 0);//form color
        MoreItems.FormBorderStyle = FormBorderStyle.Fixed3D;
        MoreItems.Show();
        MoreItems.BackgroundImage = Image.FromFile("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\backround2.png");

        //label
        lb = new Label();
        lb.AutoSize = true;
        lb.Font = new Font("Cooper Black", 19F, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
        lb.Location = new Point(25, 60); //label location
        lb.Text = "Our musical " +
            "instrument collections:";
        lb.ForeColor = Color.HotPink;
        MoreItems.Controls.Add(lb);

        
        windInstruments = new Button();
        windInstruments.Size = new Size(200, 70);
        windInstruments.Location = new Point(150, 200);
        windInstruments.Text = "Wind Instruments";
        windInstruments.Font = new Font("AmericanCaptain", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        windInstruments.BackColor = Color.DeepPink;
        windInstruments.ForeColor = Color.White;
        windInstruments.FlatStyle = FlatStyle.Flat;
        windInstruments.FlatAppearance.BorderColor = Color.Black;
        windInstruments.FlatAppearance.BorderSize = 3;
        MoreItems.Controls.Add(windInstruments);
        windInstruments.Click += new EventHandler(btnwindInstrumentsShow_Click);
        void btnwindInstrumentsShow_Click(object sender4, EventArgs e4)
        {
            TextReader th = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\windInstruments.txt");
            string x;
            string abc = "";
            while ((x = th.ReadLine()) != null)
            {
                abc += x + '\n';
            }
            th.Close();
            MessageBox.Show(abc);
        }

        //percussions
        percussions = new Button();
        percussions.Size = new Size(200, 70);
        percussions.Location = new Point(150, 300);
        percussions.Text = "percussions";
        percussions.Font = new Font("AmericanCaptain", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        percussions.BackColor = Color.DeepPink;
        percussions.ForeColor = Color.White;
        percussions.FlatStyle = FlatStyle.Flat;
        percussions.FlatAppearance.BorderColor = Color.Black;
        percussions.FlatAppearance.BorderSize = 3;
        MoreItems.Controls.Add(percussions);
        percussions.Click += new EventHandler(btnpercussionsShow_Click);
        void btnpercussionsShow_Click(object sender4, EventArgs e4)
        {
            TextReader tr = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\percussions.txt");
            string x;
            string abc = "";
            while ((x = tr.ReadLine()) != null)
            {
                abc += x + '\n';
            }
            tr.Close();
            MessageBox.Show(abc);
        }
}
    //2. buttonClose event
    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
    // button1 event
    private void btn_Click(object sender, EventArgs e)
    {
        TextReader T = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\sendi1.txt");
        TextReader F = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\sendi2.txt");
        string G = "";
        string S = "";
        while ((G = T.ReadLine()) != null)
        {
            S += G + "-" + F.ReadLine() + "$" + "\n";

        }
        T.Close();
        F.Close();
        MessageBox.Show(S);
    }
    // button2 event
    private void btn2_Click(object sender, EventArgs e)
    {
        TextReader T = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\sendi2.txt");
        int num = int.Parse(T.ReadLine());
        string s = "";
        int min = num;
        while ((s = T.ReadLine()) != null)
        {
            if (min > int.Parse(s))
            {

                min = int.Parse(s);
            }
        }
        MessageBox.Show("the minimum price is : " + min);

    }
    // button3 event
    private void btn3_Click(object sender, EventArgs e)
    {
        TextReader T = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\sendi2.txt");
        string G = "";
        int max = 0;
        while ((G = T.ReadLine()) != null)
        {
            if (int.Parse(G) > max)
            {
                max = int.Parse(G);
            }
        }
        MessageBox.Show("The maxmimum price is : " + max);
    }

    // button4 event
    private void btn4_Click(object sender, EventArgs e)
    {
        TextReader T = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\sendi2.txt");
        int sum = 0;
        string H = "";
        double avg = 0;
        while ((H = T.ReadLine()) != null)
        {
            sum += int.Parse(H);
        }
        avg = (double)sum / NumOfLines("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\sendi2.txt");
        T.Close();
        MessageBox.Show("The average price is " + avg.ToString());
    }
    public int NumOfLines(string path)
    {
        int c = 0;
        TextReader tr = new StreamReader(path);
        string s = tr.ReadLine();
        while (s != null)
        {
            c++;
            s = tr.ReadLine();
        }
        tr.Close();
        return c;
    }
    private void btn5_Click(object sender, EventArgs e)
    {
        SoundPlayer splayer = new SoundPlayer("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\song.wav");
        splayer.Play();
    }
    private void btn8_Click(object sender, EventArgs e)
    {
        int i = 0;
        TextReader T = new StreamReader("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\workers.txt");
        string s = T.ReadLine();
        while (s != null)
        {
            MessageBox.Show("sbhjdsd");
            s = T.ReadLine();
            workers[i] = s;
            i++;
        }
        

        string name = "";
        btn9 = new Button();
        Form MoreItems = new Form();
        MoreItems.StartPosition = FormStartPosition.CenterScreen;
        MoreItems.ClientSize = new Size(500, 500); //form size
        MoreItems.BackColor = Color.FromArgb(255, 215, 0);//form color
        MoreItems.FormBorderStyle = FormBorderStyle.Fixed3D;
        MoreItems.Show();
        MoreItems.BackgroundImage = Image.FromFile("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\employees.jpg");

        //button
        btn = new CircularButton();
        btn.Size = new Size(300, 300);
        btn.Location = new Point(10, 10);
        btn.Font = new Font("Cooper Black", 10F, FontStyle.Italic | FontStyle.Italic, GraphicsUnit.Point, (byte)0);
        btn.Text = "Close";
        btn.BackColor = Color.IndianRed;
        btn.ForeColor = Color.White;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderColor = Color.BurlyWood;
        btn.FlatAppearance.BorderSize = 0;
        MoreItems.Controls.Add(btn9);
        btn9.Click += new EventHandler(btn9_Click);
        
        //label
        lb = new Label();
        lb.AutoSize = true;
        lb.Font = new Font("Cooper Black", 11F, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
        lb.Location = new Point(50, 200); //label location
        lb.Text = "Enter the worker name you want to delete";
        lb.ForeColor = Color.HotPink;
        MoreItems.Controls.Add(lb);

        //textbox 
        tbox = new TextBox();
        tbox.Location = new Point(50, 350); //textbox location
        tbox.Size = new Size(50, 20); //textbox size
        tbox.TabIndex = 0;
        tbox.ClientSize = new Size(200, 261);
        tbox.BackColor = SystemColors.GradientActiveCaption;
        tbox.ForeColor = Color.Black; //font color
        Font myfont = new Font("Arial", 14.0f); //font size
        tbox.Font = myfont;
        tbox.RightToLeft = RightToLeft.No;
        tbox.BorderStyle = BorderStyle.FixedSingle;
        MoreItems.Controls.Add(tbox);
    }
    private void btn9_Click(object sender, EventArgs e)
    {
       string name = tbox.Text.ToString();
       workers.RemoveAt(workers.IndexOf(name));
    }
    private void btn6_Click(object sender, EventArgs e)
    {
        btn7 = new Button();
        Form MoreItems = new Form();
        MoreItems.StartPosition = FormStartPosition.CenterScreen;
        MoreItems.ClientSize = new Size(500, 500); //form size
        MoreItems.BackColor = Color.FromArgb(255, 215, 0);//form color
        MoreItems.FormBorderStyle = FormBorderStyle.Fixed3D;
        MoreItems.Show();
        MoreItems.BackgroundImage = Image.FromFile("C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\employees.jpg");

        //button
        btn = new CircularButton();
        btn.Size = new Size(300, 300);
        btn.Location = new Point(10, 10);
        btn.Font = new Font("Cooper Black", 10F, FontStyle.Italic | FontStyle.Italic, GraphicsUnit.Point, (byte)0);
        btn.Text = "Close";
        btn.BackColor = Color.IndianRed;
        btn.ForeColor = Color.White;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderColor = Color.BurlyWood;
        btn.FlatAppearance.BorderSize = 0;
        MoreItems.Controls.Add(btn7);
        btn7.Click += new EventHandler(btn7_Click);
        //label
        lb = new Label();
        lb.AutoSize = true;
        lb.Font = new Font("Cooper Black", 19F, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
        lb.Location = new Point(25, 30); //label location
        lb.Text = "we want you!";
        lb.ForeColor = Color.HotPink;
        MoreItems.Controls.Add(lb);

        lb = new Label();
        lb.AutoSize = true;
        lb.Font = new Font("Cooper Black", 11F, FontStyle.Italic, GraphicsUnit.Point, (byte)0);
        lb.Location = new Point(50, 200); //label location
        lb.Text = "Enter your name and age" +
            " (Example: sendi - 19)";
        
        lb.ForeColor = Color.HotPink;
        MoreItems.Controls.Add(lb);
        
        //textbox 
        tbox = new TextBox();
        tbox.Location = new Point(50, 350); //textbox location
        tbox.Size = new Size(50, 20); //textbox size
        tbox.TabIndex = 0;
        tbox.ClientSize = new Size(200, 261);
        tbox.BackColor = SystemColors.GradientActiveCaption;
        tbox.ForeColor = Color.Black; //font color
        Font myfont = new Font("Arial", 14.0f); //font size
        tbox.Font = myfont;
        tbox.RightToLeft = RightToLeft.No;
        tbox.BorderStyle = BorderStyle.FixedSingle;
        MoreItems.Controls.Add(tbox);
        
    }
    
    //check if the new worker is liglle
    private void btn7_Click(object sender, EventArgs e)
    {
        string path = "C:\\Users\\משתמש\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\workers.txt";
        string name = tbox.Text.ToString();
        string[] words = name.Split('-');
        
        //name in the [0] place and age in the [1] place
        int age = Int32.Parse(words[1]);

        if (age < 18)
        {
            MessageBox.Show("sorry but you are too young to get this job , only 18+");
        }
        else
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(name);
            }

            //tw.WriteLine(tbox.Text); //taarih
            //tw.Close();
            MessageBox.Show(words[0] + "we add you as a new empliyes in sendi's company!");
            workers.Add(name);
        }
    }


    //4. main
    [STAThread]
    static void Main()
    {
        MyForm f = new MyForm();
        Application.EnableVisualStyles();
        Application.Run(f);
    }
    
}