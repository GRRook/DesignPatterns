using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionNoLambda;

namespace DesignPatterns
{
    

    class DecoratorPattern
    {
        public void Run()
        {
            StudentConcrete stdRam = new StudentConcrete { Age = 10, Name = "Ram", Grade = "One" };
            var stdRamInformation = stdRam.DisplayInformation();
            Console.WriteLine(stdRamInformation);

            ScienceStudentDecorator stdScienceRam = new ScienceStudentDecorator(stdRam) { Labs = "Biology" };
            var stdScienceRamInformation = stdScienceRam.DisplayInformation();
            Console.WriteLine(stdScienceRamInformation);

            SportsStudentDecorator stdScienceSportsRam = new SportsStudentDecorator(stdScienceRam) { Games = "Cricket" };
            var s2Information = stdScienceSportsRam.DisplayInformation();
            Console.WriteLine(s2Information);

        }
    }

    public abstract class Student
    {
        public abstract string DisplayInformation();
    }

    public class StudentConcrete : Student
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Grade { set; get; }
        public override string DisplayInformation()
        {
            return Name + "who is " + Age + " years old is in grade : " + Grade;
        }
    }

    public class StudentDecorator : Student
    {
        Student baseStudent = null;
        protected StudentDecorator(Student s)
        {
            baseStudent = s;
        }
        public override string DisplayInformation()
        {
            string baseInformation = baseStudent.DisplayInformation();
            return baseInformation;
        }
    }

    public class ScienceStudentDecorator : StudentDecorator
    {
        public string Labs { get; set; }
        public ScienceStudentDecorator(Student baseStudent) : base(baseStudent)
        {

        }

        public override string DisplayInformation()
        {
            var result = base.DisplayInformation();
            result = result + " labs are " + Labs;
            return result;
        }
    }
    

public class SportsStudentDecorator : StudentDecorator
    {
        public string Games { get; set; }
        public SportsStudentDecorator(Student baseStudent)
            : base(baseStudent)
        {

        }

        public override string DisplayInformation()
        {
            var result = base.DisplayInformation();
            result = result + " games are " + Games;
            return result;
        }
    }



}
