using System.ComponentModel.DataAnnotations;

namespace chilltchat.Modal
{
    public class Registration
    {
        
            [Key]
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int IsActive { get; set; }
          
        }
    }

