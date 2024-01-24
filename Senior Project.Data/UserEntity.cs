using Senior_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project.Data
{
    internal class UserEntity : IDataHelper<User>
    {
        List<User> listOfUsers;
        public UserEntity() { 
            listOfUsers = new List<User>();
        }
        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetData()
        {
            return listOfUsers;
        }

        public List<User> Search(string SearchItem)
        {
            return listOfUsers.Where(x => x.Id.ToString() == (SearchItem)
            || x.FirstName.Contains(SearchItem) 
            || x.LastName.Contains(SearchItem) 
            || x.Email == (SearchItem)
            || x.Phone.ToString() == (SearchItem)
            || x.Bio.Contains(SearchItem)
            ).ToList();
        }

        public void Update(int id, User item)
        {
            throw new NotImplementedException();
        }


    }
    
    
}
