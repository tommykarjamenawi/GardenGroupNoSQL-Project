using GardenGroupDAO;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogic
{
   public class UserArchiveService
    {
        UserArchiveDAO archiveDAO;
        public UserArchiveService()
        {
            archiveDAO = new UserArchiveDAO();
        }
       public List<User> GetAllArchivedUsers()
        {
            return archiveDAO.GetAllArchivedUsers();
        }
        public void AddUser(User user)
        {
            archiveDAO.AddUserToArchive(user);
        }
        public void RemoveUser(User user)
        {
            archiveDAO.RemoveUserArchive(user);
        }
    }
}
