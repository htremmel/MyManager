using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyManager.Database;
using MyManager;
using act = MyManager.Database.Activity;

namespace MyManager_Test.LibraryTests
{
    public class DataObjectsTest
    {

    }

    public class DataObjectFactory
    {
        static Dictionary<int, Project> Projects = new Dictionary<int,Project>()
        {
            {1,new Project(){Name = "Project 1", Key = 1,Description = "First project in a dummy test series.",CreationDate = DateTime.Now}},
            {2, new Project() {Name = "Project 2", Key = 2, Description = "Second project in a dummy test series.",CreationDate = DateTime.Parse("01/08/1985"),CompletionDate = DateTime.Now} },        
        };

        static Dictionary<int,act> Activities = new Dictionary<int,Activity>()
        {
            {1, new act() {Name = "Activity 1 for Project 1", Key = 1, ProjectKey = 1, CreationDate = DateTime.Now, Description ="First activity in a dummy test series.", StartDate = DateTime.Now} },
            {2, new act() {Name = "Activity 1 for Project 2", Key = 2, ProjectKey = 2, CreationDate = DateTime.Now, Description = "Second activity in a dummy test series.", StartDate = DateTime.Parse("01/08.1985"),EndDate = DateTime.Now} },
            {3, new act() {Name = "Activity 2 for Project 2", Key = 2, ProjectKey = 2, CreationDate = DateTime.Now, Description = "Third activity in a dummy test series.", StartDate = DateTime.Parse("01/08.1985"),EndDate = DateTime.Now} }
        };

        public static  List<Project> GetDummyListOfProjects()
        {
            return Projects.Values.ToList();
        }

        public static List<Activity> GetDummyListOfActivities()
        {
            return Activities.Values.ToList();
        }
    }
}
