
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RafahiaBlazorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityRegistarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActivityRegistarController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAync()
        {
            //var Registar = await _context.activityRegisters.ToListAsync();
            //return Ok(Registar);
            //var file = HttpContext.Request.Form.Files;
            //var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file[0].FileName);
            //using var filStrem = new FileStream(Path.Combine(@"wwwroot/", "Images", ImageName), FileMode.Create);
            //file[0].CopyTo(filStrem);
            //dto.ImageActivity = ImageName;

            //await m.ImageActivity.CopyToAsync(filStrem);
            //var applicationDbContext = _context.activityRegisters.Include(c => c.curse).Include(c => c.type);

            var Registar = await _context.activityRegisters
                .Include(m => m.User ).Include(m => m.type)
                .Select(m => new ActivityRegisterDetailsDto
                {
                    UserID = m.UserID,
                    UserName = m.User.UserName,
                    TypeId = m.TypeId,
                    TypeName =m.type.TypeName,
                    NameIctivity = m.NameIctivity,
                    PhoneIctivity = m.PhoneIctivity,
                    AddressIctivity = m.AddressIctivity,
                    ContryIctivity = m.ContryIctivity,
                    DescriptionIctivity = m.DescriptionIctivity,
                    parking = m.parking,
                    restaurant = m.restaurant,
                    swimmingpool = m.swimmingpool,
                    StarsIctivity = m.StarsIctivity,
                    ImageActivity = m.ImageActivity,
                })
                .ToListAsync();
            return Ok(Registar);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetById(string name)
        {
            var Activity = await _context.activityRegisters
                .Include(m => m.User).Include(m => m.type)
                .SingleOrDefaultAsync(m => m.NameIctivity == name);
            if (Activity == null)
                return NotFound($"No Activity Was Found whith Id {name}");

            var dto = new ActivityRegisterDetailsDto
            {
                UserID = Activity.UserID,
                UserName = Activity.User?.UserName,
                TypeId = Activity.TypeId,
                TypeName = Activity.type?.TypeName,
                NameIctivity = Activity.NameIctivity,
                PhoneIctivity = Activity.PhoneIctivity,
                AddressIctivity = Activity.AddressIctivity,
                ContryIctivity = Activity.ContryIctivity,
                DescriptionIctivity = Activity.DescriptionIctivity,
                parking = Activity.parking,
                restaurant = Activity.restaurant,
                swimmingpool = Activity.swimmingpool,
                StarsIctivity = Activity.StarsIctivity,
                ImageActivity = Activity.ImageActivity,
            };

            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> CreatAsync([FromForm]ActivityRegisterDto dto)
        {
            if (dto.ImageActivity == null)
                return BadRequest("Image Is Null");
            var isValidType = await _context.typeIctivities.AnyAsync(t => t.TypeId == dto.TypeId);
            if (!isValidType)
                return BadRequest("Invalid Type Id");
            var isValidUser = await _context.Users.AnyAsync(t => t.Id == dto.UserID);
            if (!isValidType)
                return BadRequest("Invalid user Id");
            var file = HttpContext.Request.Form.Files;
            //if (file.Count() > 0)
            //{

            //    //E:\Visual Studio 2022\projects\BokarRare\wwwroot\Images\
            //}
            //else if (dto.ImageActivity == null && dto.UserID == null)
            //{
            //    dto.ImageActivity = "1.jpg";
            //}
            //else
            //{
            //    dto.ImageActivity = dto.ImageActivity;
            //}
            //using var dataStream = new MemoryStream();
            //await dto.ImageActivity.CopyToAsync(dataStream);

            var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file[0].FileName);
            using var filStrem = new FileStream(Path.Combine(@"wwwroot/", "Images", ImageName), FileMode.Create);
            file[0].CopyTo(filStrem);
            //dto.ImageActivity = ImageName;

            await dto.ImageActivity.CopyToAsync(filStrem);

            var Activity = new ActivityRegister
            {
                UserID = dto.UserID,
                TypeId = dto.TypeId,
                NameIctivity = dto.NameIctivity,
                PhoneIctivity = dto.PhoneIctivity,
                AddressIctivity = dto.AddressIctivity,
                ContryIctivity = dto.ContryIctivity,
                DescriptionIctivity = dto.DescriptionIctivity,
                parking = dto.parking,
                restaurant = dto.restaurant,
                swimmingpool = dto.swimmingpool,
                StarsIctivity = dto.StarsIctivity,
                ImageActivity = ImageName,
            };

            //if (ModelState.IsValid)
            //{

            //    return RedirectToAction(nameof(Index));
            //}

            await _context.AddAsync(Activity);
            _context.SaveChanges();
            return Ok(Activity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id , [FromForm] ActivityRegisterDto dto)
        {
            var file = HttpContext.Request.Form.Files;
            var Activity = await _context.activityRegisters
                //.Include(m => m.User).Include(m => m.type)
                //.SingleOrDefaultAsync(m => m.IDActivity == id);
                .FindAsync(id);
            if (Activity == null)
                return NotFound($"No Activity Was Found whith Id {id}");
            var isValidType = await _context.typeIctivities.AnyAsync(t => t.TypeId == dto.TypeId);
            if (!isValidType)
                return BadRequest("Invalid Type Id");
            var isValidUser = await _context.Users.AnyAsync(t => t.Id == dto.UserID);
            if (!isValidType)
                return BadRequest("Invalid user Id");
            if (dto.ImageActivity != null)
            {
                var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file[0].FileName);
                using var filStrem = new FileStream(Path.Combine(@"wwwroot/", "Images", ImageName), FileMode.Create);
                file[0].CopyTo(filStrem);
                await dto.ImageActivity.CopyToAsync(filStrem);
                Activity.ImageActivity = ImageName;
            }

            //Activity.User.UserName = dto.UserID;
            Activity.TypeId = dto.TypeId;
            //Activity.type.TypeName = dto.TypeName;
            Activity.NameIctivity = dto.NameIctivity;
            Activity.PhoneIctivity = dto.PhoneIctivity;
            Activity.AddressIctivity = dto.AddressIctivity;
            Activity.ContryIctivity = dto.ContryIctivity;
            Activity.DescriptionIctivity = dto.DescriptionIctivity;
            Activity.parking = dto.parking;
            Activity.restaurant = dto.restaurant;
            Activity.swimmingpool = dto.swimmingpool;
            Activity.StarsIctivity = dto.StarsIctivity;
            _context.SaveChanges();
            return Ok(Activity);

        }
    }
}
