using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmdbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductionController : ControllerBase
{
    [HttpPost]
    public ProductionViewModel Add(ProductionViewModel model)
    {
        return model;
    }

    public List<ProductionViewModel> GetAll(ProductionFilter filter)
    {
        return new List<ProductionViewModel>();
    }
}