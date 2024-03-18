namespace lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<data_student> liststudent = new List<data_student>();
        data_student student_DATA;

        string id_student;
        string name_student;
        double score_student;
        
        int arr_index = 0;
        string[] arrid = new string[1000];
        string[] arrname = new string[1000];
        int[] arrscore = new int[1000];

       
        int[] c_score = new int[1];
        int start = 0, stop, sub_arr_length;
        int max_idx, max_value, min_value, min_idx;
         
        double[] all_grade = new double[8];
        double[] gpa = {4.0,3.5,3.0,2.5,2.0,1.5,1.0 };

        int[] n_grade = new int[8];

        private void save_button_Click(object sender, EventArgs e)
        {
            id_student = text_id_student.Text;
            name_student = text_name.Text;
            score_student = double.Parse(text_point.Text);

            data_student student = new data_student();
            student.student = id_student;
            student.name = name_student;
            student.score = score_student;

            liststudent.Add(student);


            arr_index++;
            text_name.Text = "";
            text_id_student.Text = "";
            text_point.Text = string.Empty;

            double max= 0;
            foreach (data_student item in liststudent)
            {

                if (item.score > max)
                {
                    max = item.score;
                    student_max.Text = item.student;
                    name_max.Text = item.name;
                    socre_max.Text= item.score.ToString();

                }

            }

            double min = max;
            foreach (data_student item in liststudent)
            {
                min = item.score;
                student_min.Text = item.student;
                name_min.Text = item.name;
                socre_min.Text= item.score.ToString();
            }

            double sum_lis = (double)liststudent.Sum(MIMX => MIMX.score);
            avg_point.Text = (sum_lis / (double)liststudent.Count).ToString("0.0");

            double cu_point = score_student;
            if (cu_point >= 80 && cu_point <= 100) 
            {
                n_grade[0]++;
                all_grade[0] = (n_grade[0] * gpa[0]);
                textBox_A.Text = n_grade[0].ToString();

            }
            else if (cu_point >= 75 && cu_point <= 79) 
            {
                n_grade[1]++;
                all_grade[1] = (n_grade[1] * gpa[1]);
                textBox_B_pass.Text = n_grade[1].ToString();
            }
            else if (cu_point >= 70 && cu_point <= 74) 
            {
                n_grade[2]++;
                all_grade[2] = (n_grade[2] * gpa[2]);
                textBox_B.Text = n_grade[2].ToString();
            }
            else if (cu_point >= 65 && cu_point <= 69)
            {
                n_grade[3]++;
                all_grade[3] = (n_grade[3] * gpa[3]);
                textBox_C_pass.Text= n_grade[3].ToString();
            }
            else if (cu_point >= 60 && cu_point <= 64)
            {
                n_grade[4]++;
                all_grade[4] = (n_grade[4] * gpa[4]);
                textBox_C.Text = n_grade[4].ToString();
            }
            else if (cu_point >= 55 && cu_point <= 69)
            {
                n_grade[5]++;
                all_grade[5] = (n_grade[5] * gpa[5]);
                textBox_D_pass.Text = n_grade[5].ToString();
            }
            else if (cu_point >= 50 && cu_point <= 54)
            {
                n_grade[6]++;
                all_grade[6] = (n_grade[6] * gpa[6]);
                textBox_D.Text = n_grade[6].ToString();
            }
            else 
            {
                n_grade[7]++;
                textBox_F.Text = n_grade[7].ToString();
            }

            double ga = 0.0;
            for (int i = 0; i < n_grade.Length; i++)
            {
                ga += all_grade[i]; 
            }

            int n_of_stu = liststudent.Count;
            double gga = ga / n_of_stu;
            text_avg.Text = gga.ToString("0.00");
        }
    }
}
