using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {

       
        ArrayList StudentList = new ArrayList();
        ArrayList GroupList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 9; i++)
            {
                
                StudentList.Add(new Student("" + (i + 1))); 
            }

           
            dataGridView1.DataSource = StudentList;

           
            for (int i = 0; i < 4; i++)
            {
               
                GroupList.Add(new Group("" + (i + 1))); 
                ((Group)GroupList[i]).groupName = "groupID" + (i + 1);
            }

           
            dataGridView3.DataSource = GroupList;


            
            comboGroupID.DataSource = GroupList;
            comboGroupID.DisplayMember = "groupName";
            comboGroupID.ValueMember = "groupID";
        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            
            foreach (object o in StudentList)
            {
                string str = (((Student)o).studentID);
                string studentID = textStudentID.Text;
                if (studentID == "")
                {
                    MessageBox.Show("You must input student ID first");
                    return;
                }
            }

            
            foreach (object o in StudentList)
            {
                string str = (((Student)o).studentID).ToUpper();

                
                if (str.CompareTo((this.textStudentID.Text).ToUpper()) == 0)
                {
                    

                    string message = "A Student with ID = " + str + " already exists!\n Do you really want to update this Student's record with new details";
                    string caption = "A Student already exists!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                  

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        

                        ((Student)o).firstName = this.textFirstName.Text;
                        ((Student)o).surname = this.textSurname.Text;
                        ((Student)o).email = this.textEmail.Text;
                        ((Student)o).stuMark = this.textStuMark.Text;
                        ((Student)o).groupID = this.comboGroupID.SelectedValue.ToString();


                        MessageBox.Show(((Student)o).firstName + " record has been updated with new details, except the ID Number.");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = StudentList;
                    }

                    return;
                }
            }

            Student newStudent = new Student(this.textStudentID.Text);
            newStudent.firstName = this.textFirstName.Text;
            newStudent.surname = this.textSurname.Text;
            newStudent.email = this.textEmail.Text;
            newStudent.stuMark = this.textStuMark.Text;
            newStudent.groupID = this.comboGroupID.SelectedValue.ToString();

            StudentList.Add(newStudent);

            MessageBox.Show(newStudent.firstName + " has been added to the list of students");

       
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

        }

      
        private void buttonCreateGrp_Click(object sender, EventArgs e)
        {
            
            foreach (object o in GroupList)
            {
                string str = (((Group)o).groupID);
                string groupID = textGroupID.Text;
                if (groupID == "")
                {
                    MessageBox.Show("you must input group ID before allocating group marks and group name");
                    return;
                }
            }

            
            foreach (object o in GroupList)
            {
                string str = (((Group)o).groupID).ToUpper();

                
                if (str.CompareTo((this.textGroupID.Text).ToUpper()) == 0)
                {

                    

                    string message = "A group with ID = " + str + " already exists!\n Do you really want to update this group's record with new details";
                    string caption = "group already exists!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                  

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                       

                        ((Group)o).groupName = this.textGroupName.Text;
                        ((Group)o).groupMark = this.textGroupMark.Text;
                        MessageBox.Show(((Group)o).groupID + " record has been updated with new details, except the groupID.");

                       
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = GroupList;
                        dataGridView3.DataSource = null;
                        dataGridView3.DataSource = GroupList;

                        comboGroupID.DataSource = null;
                        comboGroupID.DataSource = GroupList;
                        comboGroupID.DisplayMember = "groupName";
                        comboGroupID.ValueMember = "groupID";
                    }

                    return;

                }
            }

           
            Group newGroup = new Group(this.textGroupID.Text);
            newGroup.groupName = this.textGroupName.Text;
            GroupList.Add(newGroup);

            MessageBox.Show(newGroup.groupName + " group has been created");

            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = GroupList;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = GroupList;

            comboGroupID.DataSource = null;
            comboGroupID.DataSource = GroupList;
            comboGroupID.DisplayMember = "groupName";
            comboGroupID.ValueMember = "groupID";
        }


        private void comboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (this.comboGroupID.SelectedValue != null)
            {
                string selGroup = this.comboGroupID.SelectedValue.ToString();

                ArrayList GroupStaff = new ArrayList();

                foreach (object obj in StudentList)
                {
                    string str = (((Student)obj).groupID);

                    if (str.CompareTo(selGroup) == 0)
                        GroupStaff.Add((Student)obj);
                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = GroupStaff;
            }
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Student selectedStudent = row.DataBoundItem as Student;
                if (selectedStudent != null)
                {
                    this.textStudentID.Text = selectedStudent.studentID;
                    this.textFirstName.Text = selectedStudent.firstName;
                    this.textSurname.Text = selectedStudent.surname;
                    this.textEmail.Text = selectedStudent.email;
                    this.textStuMark.Text = selectedStudent.stuMark;
                    this.comboGroupID.SelectedValue = selectedStudent.groupID; 

                }
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            Stream stream = File.Open("StudentDetails.dat", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, StudentList);
            stream.Close();

     
            stream = File.Open("GroupDetails.dat", FileMode.Create);
            bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, GroupList);
            stream.Close();

            MessageBox.Show("student's and Group's Data saved to file");
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {

                
                Stream stream = File.Open("StudentDetails.dat", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

     
                StudentList = (ArrayList)bformatter.Deserialize(stream);

                stream.Close();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = StudentList;


                stream = File.Open("GroupDetails.dat", FileMode.Open);
                bformatter = new BinaryFormatter();

             
                GroupList = (ArrayList)bformatter.Deserialize(stream);

                stream.Close();

                comboGroupID.DataSource = null;
                comboGroupID.DataSource = GroupList;
                comboGroupID.DisplayMember = "groupName";
                comboGroupID.ValueMember = "groupID";

                MessageBox.Show("Student and Group Data is retrieved from file");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR reading file!");
            }


        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textStudentID.Text = "";
            this.textFirstName.Text = "";
            this.textSurname.Text = "";
            this.textEmail.Text = "";
            this.textStuMark.Text = "";
            this.textGroupID.Text = "";
            this.textGroupName.Text = "";
            this.textGroupMark.Text = "";
        }




    
        private void SortName_Click(object sender, EventArgs e)
        {
            StudentList.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;
        }

    
        private void SortStudentID_Click(object sender, EventArgs e)
        {

            StudentList.Sort(Student.sortByStudentID());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;
        }

        private void sortGroupID_Click(object sender, EventArgs e)
        {
            StudentList.Sort(Student.sortByGroupID());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

        }

    
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BulkAssign_Click(object sender, EventArgs e)
        {
  
            ArrayList studentWithoutGroup = new ArrayList();

            foreach (object obj in StudentList)
            {
                string str = (((Student)obj).groupID);

                if (str == null || str.Trim() == "")
                    studentWithoutGroup.Add((Student)obj);
            }

            int numOfStuRemaining = studentWithoutGroup.Count;


            string message = numOfStuRemaining + " students with no group" + "\nDo you want to execute bulk-assigment ?";

            string caption = "Bulk-Assign";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons);

      

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                const int maxPerGrp = 4;
                const int minPerGrp = 2;

                int numberOfRequiredGroups = (numOfStuRemaining + maxPerGrp - 1) / maxPerGrp;
                int remainder = numOfStuRemaining % maxPerGrp;


                int autoGrpCount = 0;
                int memberCount = 0;
                string newgroupID = "";


                foreach (object obj in studentWithoutGroup)
                {
                    if (memberCount == 0) 
                    {
                        autoGrpCount++;
                        newgroupID = textGroupID.Text + autoGrpCount;
                        Group newGroup = new Group(newgroupID);
                        newGroup.groupName = textGroupID.Text + autoGrpCount;
                        GroupList.Add(newGroup);
                    }

    

                    ((Student)obj).groupID = newgroupID;
                    memberCount++;



                    if ((numberOfRequiredGroups > 1 && remainder > 0 && autoGrpCount == 1 && memberCount == Math.Max(remainder, minPerGrp)) || (memberCount == maxPerGrp))
                    {
                  
                        memberCount = 0;
                    }

             

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = StudentList;

          
                    comboGroupID.DataSource = null;
                    comboGroupID.DataSource = GroupList;
                    comboGroupID.DisplayMember = "groupName";
                    comboGroupID.ValueMember = "groupID";
                }
            }
        }

        private void buttonImportCSV_Click(object sender, EventArgs e)
        {
     

            string message = "do you want to replace the current data with the data inside the CSV file ?";
            string caption = "Import from CSV file";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

     

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)

         

                StudentList.Clear();

          

            string CSVfilename = "Student.csv";

            string csvData = "";

         
            using (StreamReader oStreamReader = new StreamReader(File.OpenRead(CSVfilename)))
            {
                csvData = oStreamReader.ReadToEnd();
            }

          
            string[] rows = csvData.Replace("\r", "").Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue;

                string[] cols = row.Split(',');

                

                Student stuObj = new Student("");

                stuObj.studentID = cols[0];
                stuObj.firstName = cols[1];
                stuObj.surname = cols[2];
                stuObj.email    = cols[3];
                stuObj.groupID = cols[4];
                stuObj.stuMark = cols[5];


                StudentList.Add(stuObj);
            }

            //Refresh view

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

            //reset the textboxes

            this.textStudentID.Text = "";
            this.textFirstName.Text = "";
            this.textSurname.Text = "";
            this.comboGroupID.SelectedValue = 1;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}
