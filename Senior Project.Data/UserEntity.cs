using Senior_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project.Data
{
    public class UserEntity : IDataHelper<User>
    {
        List<User> listOfUsers;
        private User user;
        public UserEntity()
        {
            listOfUsers = new List<User>
            {
                new User(){Id=1,FirstName = "Ahmed",LastName = "Omer" , Email = "fswf@gmail.com" , Password = "123456",Phone =156650511,Bio = ".New Div" },
                new User(){Id=1,FirstName = "Mahmed",LastName = "Omer" , Email = "kjtjf@gmail.com" , Password = "127856",Phone =785650511,Bio = ".New Div" },
                new User(){Id=1,FirstName = "Ahmed",LastName = "Ali" , Email = "jbjdjh@gmail.com" , Password = "127896",Phone =156259511,Bio = ".New Div" }
            };
            this.user = new User();
        }
        public void Add(User item)
        {
            listOfUsers.Add(item);
        }

        public void Delete(int id)
        {
            user = Find(id);
            listOfUsers.Remove(user);
        }

        public User Find(int id)
        {
            return listOfUsers.Where(x => x.Id == id).First();
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
            user = Find(id);
            user = new User
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Bio = item.Bio
            };
        }


    }
    
    
}
