using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace demo1 { class Student { private string id; private string name; private string marks;

    public string getid()
    {
        return this.id;
    }

    public string  getname()
    {
        return this.name;
    }

    public string getmarks()
    {
        return this.marks;

    }

    public void setId(string value)
    {
        this.id = value;
    }
    
    
    
    

    public void setname(string value)
    {
        this.name = value;

    }

    public void setmarks(string  value )
    {
        this.marks = value;
    }
}
}

main method

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace demo1 { class Program { static void Main(string[] args) { Student d = new Student(); d.setId("12"); d.setmarks("65"); d.setname("ubed");

    }
}
}
