using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MegaCentralFinance.Data;
using MegaCentralFinance.Models.Dto;
using MegaCentralFinance.Models;

namespace MegaCentralFinance.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MegaCentralFinanceController : ControllerBase
	{
		private readonly ApplicationDbContext _db;

		public MegaCentralFinanceController(ApplicationDbContext db)
		{
			_db = db;
		}

		[HttpGet]
		public IActionResult Get()
		{
			var connection = _db.Database.GetDbConnection().Database;

			return Ok($"Connected to database: {connection}");
		}

		[HttpGet("users")]
		public IActionResult GetAllUsers()
		{
			var result = _db.Users.ToList();

			return Ok(result);
		}

		[HttpGet("users/{id}")]
		public IActionResult GetUserById(long id)
		{
			var result = _db.Users.Find(id);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("storageLocations")]
		public IActionResult GetAllStorageLocations()
		{
			var result = _db.StorageLocations.ToList();

			return Ok(result);
		}

		[HttpGet("storageLocations/{id}")]
		public IActionResult GetAllStorageLocationById(string id)
		{
			var result = _db.StorageLocations.Find(id);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("bpkbs")]
		public IActionResult GetAllBpkbs()
		{
			var result = _db.Bpkbs.ToList();

			return Ok(result);
		}

		[HttpGet("bpkbs/{id}")]
		public IActionResult GetAllBpkbById(string id)
		{
			var result = _db.Bpkbs.Find(id);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpPost("login")]
		public IActionResult Login(LoginDto data)
		{
			var result = _db.Users.FirstOrDefault(e => e.UserName == data.UserName && e.Password == data.Password);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpPost("postBpkb")]
		public IActionResult PostBpkb(CreateBpkbDto data)
		{
			var result = new TrBpkbModel
			{
				AgreementNumber = data.AgreementNumber,
				BpkbNo = data.BpkbNo,
				BranchId = data.BranchId,
				BpkbDate = data.BpkbDate,
				FakturNo = data.FakturNo,
				FakturDate = data.FakturDate,
				LocationId = data.LocationId,
				PoliceNo = data.PoliceNo,
				BpkbDateIn = data.BpkbDateIn
			};

			_db.Bpkbs.Add(result);
			_db.SaveChanges();

			return Ok();
		}
	}
}