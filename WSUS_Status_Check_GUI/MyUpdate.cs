using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UpdateServices.Administration;

namespace WSUS_Status_Check_GUI
{
    class MyUpdate
    {
        IUpdate update;

        public MyUpdate(IUpdate upd)
        {
            update = upd;
        }

        public IUpdate getUpdate()
        {
            return update;
        }

        public override string ToString()
        {
            string result = String.Empty;

            foreach (string str in update.SecurityBulletins)
            {
                result += str + ", ";
            }

            return result.Remove(result.Length - 2);
        }
    }
}
