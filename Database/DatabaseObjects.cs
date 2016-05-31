using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManager.Database
{
    partial class Project
    {
        [PrimaryKeyAttribute] public int Key { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Description { get; set; }
    }

    partial class Task
    {
        [PrimaryKeyAttribute] public int Key { get; set; }
        [ForeignKeyAttribute] public int ProjectKey { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Description { get; set; }
    }

    partial class Activity
    {
    	[PrimaryKeyAttribute] public int Key { get; set; } 
    	[ForeignKeyAttribute] public int ProjectKey { get; set; }
    	public string Name { get; set; }
    	public DateTime CreationDate { get; set; }
    	public DateTime CompletionDate { get; set; }
    	public DateTime StartDate { get; set; }
    	public DateTime EndDate { get; set; }
    	public float Duration { get; set; }
    	public string Description { get; set; }
    }
    
    partial class Dependency
    {
    	[PrimaryKeyAttribute] public int Key { get; set; }
    	[ForeignKeyAttribute] public int PredecessorKey { get; set; }
    	[ForeignKeyAttribute] public int SuccessorKey { get; set; }    	
    }

    partial class Goal
    {
    	[PrimaryKeyAttribute] public int Key { get; set; }
    	public string Name { get; set; }
        public string Description { get; set; }
    	public DateTime CreationDate { get; set; }
    	public DateTime CompletionDate { get; set; }
    	public DateTime StartDate { get; set; }
    	public DateTime EndDate { get; set; }
    	public bool IsSuccessful { get; set; }
    }

    partial class Log
    {
        [PrimaryKey] public int Key { get; set; }
        [ForeignKey] public int TaskKey { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
