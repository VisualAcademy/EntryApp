using EntryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace EntryApp.Apis.Controllers
{
    //[Produces("application/json")]
    [ApiController] // @RestController
    [Route("/api/[controller]")] // [Route("/api/Entries")] // @RequestMapping
    public class EntriesController : ControllerBase
    {
        private readonly IEntryRepository _repository;
        private readonly ILogger _logger;

        public EntriesController(IEntryRepository repository, ILoggerFactory loggerFactory)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(EntriesController));
            this._logger = loggerFactory.CreateLogger(nameof(EntriesController));
        }

        [HttpGet]
        public string GetAll()
        {
            return "Hello JSON";
        }
    }
}
