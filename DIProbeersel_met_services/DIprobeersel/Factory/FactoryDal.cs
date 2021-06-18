<<<<<<< HEAD
﻿using Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FactoryDal
    {
        public static IEmployeDal CreateEmpolyeDal()
        {
            return new EmployeDal();
        }
    }
}
=======
﻿using Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class FactoryDal
    {
        public static IEmployeDal CreateEmpolyeDal()
        {
            return new EmployeDal();
        }
    }
}
>>>>>>> main
