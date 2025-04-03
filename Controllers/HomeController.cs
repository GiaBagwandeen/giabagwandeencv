using System.Collections.Generic;
using GBCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBCV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Create and populate the CV model
            var cv = new CVModels
            {
                FullName = "Gia Bagwandeen",
                ProfessionalTitle = "Final Year BCAD Application Development Student",
                Email = "gia.bagwandeen@gmail.com",
                Phone = "063 366 8671",
                Location = "Johannesburg, South Africa",
                LinkedIn = "",
                ProfessionalSummary = @"As a final-year BCAD student at Varsity College, I bridge technical expertise with creative expression. 
        By day, I architect software solutions using C#, ASP.NET, and SQL, transforming complex requirements into 
        elegant applications. By evening, I channel this same problem-solving mindset into teaching Bollywood dance 
        to young students aged 2-10, developing their coordination and confidence through movement.

Both disciplines share my passion for structured creativity - whether crafting clean code architecture 
        or choreographing dance routines, I thrive on designing systems that are both functional and beautiful. 
        Seeking opportunities where I can apply my technical training while maintaining the rhythm between 
        logical problem-solving and artistic expression.",

                Educations = new List<Education>
                {
                    new Education
                    {
                        Institution = "Varsity College Sandton",
                        Degree = "Bachelor of Computer and Information Sciences in Application Development (BCAD)",
                        Year = "2022 - 2024 (Final Year)"
                    },
                    new Education
                    {
                        Institution = "Curro Academy Wilgeheuwel",
                        Degree = "National Senior Certificate",
                        Year = "2018 - 2022"
                    }
                },

                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        Company = "Surya Dance Academy", 
                        Position = "Bollywood Dance Instructor",
                        Duration = "2020 - Present",
                        Description = "Teaching authentic Bollywood dance techniques to students aged 2-10, focusing on rhythm, expression, and cultural appreciation."
                    }
                },

                Skills = new List<Skill>
                {
                    new Skill { Name = "C#", Proficiency = 90 },
                    new Skill { Name = "ASP.NET MVC", Proficiency = 85 },
                    new Skill { Name = "JavaScript", Proficiency = 80 },
                    new Skill { Name = "SQL", Proficiency = 95 },
                    new Skill { Name = "HTML/CSS", Proficiency = 85 },
                  
                },

                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Academic Project 1",
                        Description = "Web application developed for advanced programming course demonstrating MVC architecture and database integration.",
                        Technologies = "ASP.NET MVC, Entity Framework, JavaScript"
                    },
                    new Project
                    {
                        Title = "Academic Project 2",
                        Description = "Mobile-responsive task management system created for software engineering principles course.",
                        Technologies = "ASP.NET Core, SQL Server, Bootstrap"
                    }
                }
            };

            return View(cv);
        }
    }
}