using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_GarbageCollections
{
    class Students
    {
        string name;
        int id;
        public Students(string stuName, int stuid)
        {
            this.name = stuName;
            this.id = stuid;
        }
        [NewAttribute("Accessor","Given Student Name")]
        public string getName()
        {
            return name;
        }
        [NewAttribute("Accessor", "Given Student Id")]
        public int getId()
        {
            return id;
        }
    }
    class Teachers
    {
        string name;
        int id;
        public Teachers(string staffName, int staffId)
        {
            this.name=staffName;
            this.id = staffId;
        }
        [NewAttribute("Accessor", "Given Staffs Name")]
        public string getName()
        {
            return name;
        }
        [NewAttribute("Accessor", "Given Staffs Id")]
        public int getId()
        {
            return id;
        }
    }
}
