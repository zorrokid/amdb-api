using Application.Models;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmdbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductionController : ControllerBase
{
    [HttpPost]
    public Production Add(Production model)
    {
        return model;
    }

    public List<Production> GetAll(ProductionFilter filter)
    {
        return new List<Production>();
    }
}