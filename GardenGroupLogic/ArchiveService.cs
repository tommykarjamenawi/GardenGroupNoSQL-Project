using GardenGroupDAO;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogic
{
   public class ArchiveService
    {
        ArchiveDAO archiveDAO;
        public ArchiveService()
        {
            archiveDAO = new ArchiveDAO();
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
