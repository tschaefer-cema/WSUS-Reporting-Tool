using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UpdateServices.Administration;

namespace WSUS_Status_Check_GUI
{
    class WSUSGroup
    {
        private IComputerTargetGroup grp;

        public WSUSGroup(IComputerTargetGroup group)
        {
            grp = group;
        }


        public IComputerTargetGroup getWSUSGroup()
        {
            return grp;
        }

        public void setWSUSGroup(IComputerTargetGroup group)
        {
            grp = group;
        }

        public override string ToString()
        {
            return grp.Name;
        }
    }
}
