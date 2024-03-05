using chilltchat.Data;
using chilltchat.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chilltchat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        private IConfiguration _config;
        private readonly ILogger<RegistrationController> _logger;
        private ApplicationDbContext _context;

        public RegistrationController(ApplicationDbContext context, IConfiguration config, ILogger<RegistrationController> logger)
        {
            _context = context;
            _config = config;
            _logger = logger;
        }
        [HttpPost("registartion")]
        public async Task Registration(Registration modal)
        { 
        Registration reg=new Registration();
            try
            {
                reg.UserName = modal.UserName;
                reg.Password = modal.Password;
                reg.Email = modal.Email;
                reg.Phone = modal.Phone;
                reg.IsActive = 1;
                _context.Add(reg);
                _context.SaveChanges();
            }
            catch (Exception ex) {

                throw ex;
                    
            
            }
        
        }


    }
}
