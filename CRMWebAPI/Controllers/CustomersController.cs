using Microsoft.AspNetCore.Mvc;
using CRMWebAPI.Models;

namespace CRMWebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    public CustomersController()
    {
               
    }

    
    [HttpGet("{id}")]
    public ActionResult<Customer> GetById(int Id)
    {
        return Ok(new Customer());
    }   

    [HttpGet]
     public ActionResult<List<Customer>> GetAll()
    {
        List<Customer> customers=new List<Customer>();
        customers.Add(new Customer{ Id=2,FirstName="shital",LastName="jadhav"});
        customers.Add(new Customer{ Id=3,FirstName="test1",LastName="test1"});
        customers.Add(new Customer{ Id=4,FirstName="test2",LastName="test2"});
        
        
        return Ok(customers);
    }

     [HttpPost]
     public ActionResult<Customer> Create(Customer customer)
    {
        return Ok("Customer Created");
    }

    [HttpPut("{id}")]
    public ActionResult<Customer> Update(int id, Customer customer)
    {
        return Ok("Customer Updated");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok("Customer Deleted");
    }   
    

}