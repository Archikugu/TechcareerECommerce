﻿using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        public List<Order> Orders { get; set; }
        public List<BasketList> Baskets { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
