﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace db_mapping
{
    /// <summary>
    /// Clasa Users mapeaza tabelul "Users" din baza de date.
    /// </summary>
    public class User
    {
        public static int UninitializedInt = -100000;

        public User()
        {
            id_ = UninitializedInt;
            email_ = password_ = first_name_ = last_name_ = null;
            specifics_list_ = null;
            join_date_ = default(DateTime);
        }

        public void Initialize(int id , String email , String password, String first_name = null, 
            String last_name = null, DateTime join_date = default(DateTime), List<string> specifics_list = null)
        {
            id_ = id;
            email_ = email;
            password_ = password;
            first_name_ = first_name;
            last_name_ = last_name;
            join_date_ = join_date;
            specifics_list_ = specifics_list;
        }

        public String toString()
        {
            String user = "";
            if (id_ != UninitializedInt)
            {
                user += "Id = " + id_ + " ";
                user += "Email = " + email_ + " ";
                user += "Password = " + password_ + " ";
                user += "First Name = " + first_name_ + " ";
                user += "Last Name = " + last_name_ + " ";
                user += "Join Date = " + join_date_ + "\n";
            }
            return user;
        }

        // Getteri pentru fiecare atribut.
        public int getId()
        {
            return id_;
        }

        public String getEmail()
        {
            return email_;
        }

        public String getFirstName()
        {
            return first_name_;
        }

        public String getLastName()
        {
            return last_name_;
        }

        public string getPassword()
        {
            return password_;
        }

        public DateTime getJoinDate()
        {
            return join_date_;
        }

        public List<string> getSpecificsList()
        {
            return specifics_list_;
        }

        private int id_;
        private string email_;
        private string first_name_;
        private string last_name_;
        private string password_;
        private List<string> specifics_list_;
        private DateTime join_date_;
    }
}//namespace