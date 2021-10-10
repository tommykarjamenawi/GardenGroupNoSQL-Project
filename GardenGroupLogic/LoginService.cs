using GardenGroupModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using GardenGroupDAO;

namespace GardenGroupLogic
{
    public class LoginService
    {
        LoginDAO loginDao = new LoginDAO();
        public List<HardDrive> GetHardDriveId()
        {
            List<HardDrive> hardDriveDetails = new List<HardDrive>();
            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();  // User Defined Class
                hd.Model = wmi_HD["Model"].ToString();  //Model Number
                hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                hd.SerialNo = wmi_HD["SerialNumber"].ToString(); // Serial Number
                hardDriveDetails.Add(hd);
            }
            return hardDriveDetails;
        }

        public void AddRememberMe(RememberMe user)
        {
            loginDao.AddRememberMe(user);
        }

        public RememberMe CheckRememberMe(string serialHdd, string ProcessorSerial)
        {
            List<RememberMe> remembers = loginDao.CheckRememberMe();
            foreach (RememberMe remember in remembers)
            {
                if (serialHdd == remember.HddSerial && remember.ProcessorSerial == ProcessorSerial)
                {
                    return new RememberMe(remember.email, remember.password, remember.HddSerial, remember.ProcessorSerial);
                }
            }
            return null;
        }

        public void OverWriteRememberMe(RememberMe record)
        {
            loginDao.OverWriteRememberMe(record);
        }
    }
}
