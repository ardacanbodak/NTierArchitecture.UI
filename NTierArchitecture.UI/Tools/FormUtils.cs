using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.Tools
{
    public class FormUtils
    {
        public static bool IsFormOpen(Form form)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == form.GetType())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
