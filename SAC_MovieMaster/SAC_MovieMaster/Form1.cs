namespace SAC_MovieMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int check = 0;
        int i = 1;
        int count = 1;
        int searchLength = 0;
        string alphabetCheck = null;
        string[] details;
        //int arrayLength = 999999;

        string filePath = "titlebasicsDecreased.txt";

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstViewCSV.View = View.Details;

            lstViewCSV.Columns.Add("#", 50, HorizontalAlignment.Right);
            lstViewCSV.Columns.Add("Movie Name", 225, HorizontalAlignment.Left);
            lstViewCSV.Columns.Add("Release Date", 80, HorizontalAlignment.Left);
            lstViewCSV.Columns.Add("Genre", 150, HorizontalAlignment.Left);

            lstWatched.View = View.Details;

            lstWatched.Columns.Add("#", 50, HorizontalAlignment.Right);
            lstWatched.Columns.Add("Movie Name", 100, HorizontalAlignment.Right);
            lstWatched.Columns.Add("Release Date", 80, HorizontalAlignment.Left);
            lstWatched.Columns.Add("Genre", 150, HorizontalAlignment.Left);

            if (lstViewCSV.Items.Count == 0)
            {
                
            }
            else
            {
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstViewCSV.Items.Count; i++)
            {
                if (lstViewCSV.Items[i].Selected)
                {
                    string[] details = { lstViewCSV.Items[i].ToString() };
                    lstViewCSV.Items[i].Remove();

                    lstViewCSV.Items.Add(lstViewCSV.Items[i]);
                    

                    i--;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchLength = txtSearch.Text.Length;

            if (check == 0)
            {
                txtSearch.Text = "";
                check++;
            }
            else
            {


                if (txtSearch.Text != string.Empty || txtSearch.Text != " ")
                {

                    while (true)
                    {

                        if (lstViewCSV.Items.Count == 0)
                        {
                            i = 1;
                            var reader = new StreamReader(File.OpenRead(filePath));
                            //Reads file
                            while (!reader.EndOfStream) //while not at end of the file.
                            {


                                //reads each line, and each value is split between a tab
                                var nextLine = reader.ReadLine();
                                var values = nextLine.Split('\t');

                                if (values[2] != "primaryTitle")
                                {
                                    //values are added into the array
                                    string[] details = { (i++).ToString(), values[2], values[5], values[8] };

                                    alphabetCheck = details[1].ToUpper();

                                    if (alphabetCheck == txtSearch.Text)
                                    {
                                        //listview has array added into it.
                                        var listViewItem = new ListViewItem(details);
                                        lstViewCSV.Items.Add(listViewItem);
                                    }

                                    Array.Clear(details, 0, details.Length);
                                }
                            }

                            break;
                        }
                        else
                        {
                            lstViewCSV.Items.Clear();
                        }

                    }
                }
            }
            


        }
    }
}
