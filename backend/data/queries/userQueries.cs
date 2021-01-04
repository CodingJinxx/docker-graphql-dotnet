using System;
using data.entities;

namespace data.queries{
    public class UserQueries{
        public User GetUser() => new User{
            Username = "CodingJinxx"
        };
    }
}