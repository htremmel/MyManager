using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManager.Database
{
    class ForeignKeyAttribute : Attribute
    {
    	public object KeyObject { get; set; }
    }
    
    class PrimaryKeyAttribute : Attribute
    {
    	public object KeyObject { get; set; }
    }
    
}
