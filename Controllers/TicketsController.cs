using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YVTestServer.DTOs;
using YVTestServer.Repos;

namespace YVTestServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        public readonly ITicketsRepository repo;

        public TicketsController(ITicketsRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("list")]
        public TimesListDTO[] Getlist()
        {
            return repo.Getlist();
        }

        [HttpPost]
        public OrderTicketsDTO OrderTickets(OrderTicketsDTO dto)
        {
            return repo.OrderTickets(dto);
        }

    }
}
