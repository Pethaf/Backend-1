﻿using DAL.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class UserService
    {
        private int _minimumPasswordLength = 8;
        private bool IsPasswordOk(string password)
        {
            return password.Length > _minimumPasswordLength;
        }
        public void RegisterUser(UserDTO newUser)
        {
            if(!IsPasswordOk(newUser.password))
            {
                throw new Exception("Password is too weak");
            }
            using(var context = new EconomiqContext())
            {
                if (context.Users.Where(user => user.UserName.ToLower() == newUser.Username.ToLower()).Count() > 0)
                {
                    throw new Exception("Username allready exists");
                }
                    var Email = new Email
                    {
                        Mail = newUser.email
                    };
                    var Emails = new List<Email>();
                    Emails.Add(Email);
                    context.Users.Add(new User
                    {
                        Fname = newUser.Fname,
                        Lname = newUser.Lname,
                        UserName = newUser.Username,
                        Password = newUser.password,
                        Emails = Emails,
                        IsLoggedIn = false
                    });
                    try
                    {
                        context.SaveChanges();
                    } 
                    catch (Exception ex) {
                        throw ex; 
                    }
                }
        }
        public bool LoginUser(string userName, string password)
        {
            using (var context = new EconomiqContext())
            {
                var user = context.Users.Where(user => user.UserName == userName).FirstOrDefault();
                if (user is null)
                {
                    throw new Exception("Invalid Username");
                }
                if (user.IsLoggedIn)
                {
                    throw new Exception("User is already logged in");
                }
                if (user.UserName == userName && user.Password == password)
                {
                    try
                    {
                        user.IsLoggedIn = true;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                else
                {
                    throw new Exception("Invalid username or password");
                }
            }
            return true;
        }
    }
}
