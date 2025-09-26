using Microsoft.AspNetCore.Mvc;
using SeuProjeto.Models;

public class UserController : Controller
{
    private readonly IUserRepository _repo;

    public UserController(IUserRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public IActionResult Filter(string status)
    {
        var users = _repo.GetUsersByStatus(status);
        return PartialView("_UsersList", users); // Partial com o HTML da lista
    }
}
