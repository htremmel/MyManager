using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace MyManager.Database
{
    public partial class Project: IEquatable<Project>
    {
        public bool Equals(Project other)
        {
            if (other.Key.Equals(this.Key)) return true;
            return false;
        }
    }

    public partial class Task: IEquatable<Task>
    {
        public bool Equals(Task other)
        {
            if (other.Key.Equals(this.Key)) return true;
            return false;
        }
    }

    public partial class Activity: IEquatable<Activity>
    {
        public bool Equals(Activity other)
        {
            if (other.Key.Equals(this.Key)) return true;
            return false;
        }
    }

    public partial class Dependency: IEquatable<Dependency>
    {

        public bool Equals(Dependency other)
        {
            if (other.Key.Equals(this.Key)) return true;
            return false;
        }
    }

    public partial class Goal: IEquatable<Goal>
    {
        public bool Equals(Goal other)
        {
            if (other.Key.Equals(this.Key)) return true;
            return false;
        }
    }

    public partial class Log: IEquatable<Log>
    {
        public bool Equals(Log other)
        {
            if (other.Key.Equals(this.Key)) return true;
            return false;
        }
    }
}
