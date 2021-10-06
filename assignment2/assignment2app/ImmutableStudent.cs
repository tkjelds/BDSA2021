using System;

namespace assignment2app
{
    public record  ImmutableStudent{
        public int id {get;init;}

        public string GivenName {get;init;}

        public string SurNmae {get;init;}

        public DateTime StartDate {get;init;}

        public DateTime EndDate {get;init;}
        public DateTime GraduationDate {get;init;}

    }
}