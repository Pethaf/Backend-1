﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        
        //Navigational Properties
        //For Expenses
        public List<Expense>? ExpensesNav { get; set; }
        //For User
        public List<User>? UserNav { get; set; }



    }
}