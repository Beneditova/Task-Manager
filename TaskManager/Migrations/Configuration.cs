namespace TaskManager.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManager.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManager.Models.ApplicationDbContext context)
        {
            AddUsers(context);
            AddCourses(context);
        }

        void AddUsers(TaskManager.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "testuser@gmail.com" };
            var test = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            test.Create(user, "password");
        }

        void AddCourses(TaskManager.Models.ApplicationDbContext context)
        {
            var courses = new List<Course>
            {
               new Course{CourseID=1050,Title="Chemistry",Credits=3,},
               new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
               new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
               new Course{CourseID=1045,Title="Calculus",Credits=4,},
               new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
               new Course{CourseID=2021,Title="Composition",Credits=3,},
               new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
        }

        void Add≈nrollments(TaskManager.Models.ApplicationDbContext context)
        {
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=1050},
                new Enrollment{StudentID=1,CourseID=1050,},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=1045},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
