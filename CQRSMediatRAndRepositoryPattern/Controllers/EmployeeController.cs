using CQRSMediatRAndRepositoryPattern.Features.Emp;
using CQRSMediatRAndRepositoryPattern.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatRAndRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getemployee")]
        public async Task<List<Employee>> GetEmployee()
        {
            return await _mediator.Send(new GetEmployeeQuery());
        }
    }
}
