
using AutoMapper;
using Core.Entities;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos.Taches;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TachesController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public TachesController(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        // GET: api/Taches
        [HttpGet]
        public ActionResult<IEnumerable<TacheDto>> Get()
        {
            var tasks = _repositoryManager.Tache.GetAll(false);
            var map = _mapper.Map<IEnumerable<TacheDto>>(tasks);
            return Ok(map);
        }

        // GET: api/Taches/5
        [HttpGet("{id}", Name = "TacheGet")]
        public ActionResult<Taches> Get(int id)
        {
            var tache = _repositoryManager.Tache.GetTache(id,false);
            if (tache is null )
            {
                return NotFound();
            }
            var map = _mapper.Map<TacheDto>(tache);
            return Ok(map);
        }

        // POST: api/Taches
        [HttpPost]
        public IActionResult Post([FromBody] CreateTacheDto tacheDto)
        {
            var tache = _mapper.Map<Taches>(tacheDto);
            _repositoryManager.Tache.CreateTache(tache);
            _repositoryManager.Save();

            var tacheToReturn = _mapper.Map<TacheDto>(tache);
            return CreatedAtRoute("TacheGet",new {id = tache.Id},tacheToReturn);
        }

        // PUT: api/Taches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE: api/Taches/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tache = _repositoryManager.Tache.GetTache(id,false);
            if (tache is null)
            {
                return NotFound();
            }
            _repositoryManager.Tache.DeleteTache(tache);
            _repositoryManager.Save();
            return NoContent();

        }
    }
}
