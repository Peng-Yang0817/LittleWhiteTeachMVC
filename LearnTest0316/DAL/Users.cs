namespace LearnTest0316.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}
