using demooo.Entity;
using demooo.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demooo.Repository
{
    public class UserRepository
    {
        FileIO file = new FileIO();
        public List<UserEntity> FindAllUser()
        {
            string value = file.ReadFileJson(Constant.DATA_USER);
            List<UserEntity> users = JsonConvert.DeserializeObject<List<UserEntity>>(value);
            return users;
        }

        public UserEntity FindUserByUsername(string username)
        {
            List<UserEntity> users = FindAllUser();
            foreach (UserEntity user in users)
            {
                if (user.Username.Equals(username))
                    return user;
            }
            return null;
        }
    }
}