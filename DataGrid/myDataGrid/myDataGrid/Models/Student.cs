using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDataGrid.Models
{
    public class Student
    {
        private int _nId;

        public int nID
        {
            get { return _nId; }
            set { _nId = value; }
        }

        private string _strName;

        public string strName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private bool _bIsSoccerPlayer;

        public bool bIsSoccerPlayer
        {
            get { return _bIsSoccerPlayer; }
            set { _bIsSoccerPlayer = value; }
        }

        private Gender _gender;

        public Gender emGender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public static ObservableCollection<Student> lstGetStudents()
        {
            var lstStudents = new ObservableCollection<Student> (){
                new Student() {strName="Archer", nID=001, bIsSoccerPlayer=false, emGender=Gender.Male },
                new Student() {strName="Bobson", nID=002, bIsSoccerPlayer=true, emGender = Gender.Male },
                new Student() {strName="Alan", nID=003, bIsSoccerPlayer=false, emGender=Gender.Male },
                new Student() {strName="Mei", nID=004, bIsSoccerPlayer=false, emGender=Gender.Female},
                new Student() {strName = "Ike", nID=005, bIsSoccerPlayer=true, emGender=Gender.Male }
            };

            return lstStudents;
        }

    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}
