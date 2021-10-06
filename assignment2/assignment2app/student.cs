using System;

namespace assignment2app
{
    public class Student
    {
        public readonly int Id;

        String GivenName;

        String Surname;

        readonly Status Status;

        DateTime  StartDate;

        DateTime EndDate;

        DateTime GraduationDate;

        public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            Id = id;
            GivenName = givenName;
            Surname = surname;
            Status = calculateStatus(startDate,endDate,graduationDate);
            StartDate = startDate;
            EndDate = endDate;
            GraduationDate = graduationDate;
        }

        public Status calculateStatus(DateTime startDate, DateTime endDate, DateTime graduationDate){
            if (DateTime.Now > GraduationDate){
                return Status.Graduated;
            }
            if ((startDate < DateTime.Now) && (DateTime.Now < graduationDate)){
                return Status.Active;
            }
            if (DateTime.Now.Year == startDate.Year){
                return Status.New;   
            }
            return Status.Dropout;
        }
        public override string ToString(){ 
            return ($"id = {this.Id} @\n Name = {this.GivenName} {this.Surname} @\n Status = {this.Status} @\n StartDate = {this.StartDate.ToShortDateString()} @\n EndDate = {this.EndDate.ToShortDateString()} @\n GraduationDate = {this.GraduationDate.ToShortDateString()} ");
        }
    }

    public enum Status
    {
        New, Active, Dropout, Graduated
        
    }
}
