using CQRSMediatRAndRepositoryPattern.Models;
using CQRSMediatRAndRepositoryPattern.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatRAndRepositoryPattern.Features.Emp
{
    public class GetEmployeeQuery:IRequest<List<Employee>>
    {
        public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, List<Employee>>
        {
            private readonly IemployeeService _employeeService;
            public GetEmployeeHandler(IemployeeService employeeService)
            {
                _employeeService = employeeService;
            }
            public async Task<List<Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
            {
                return await Task.FromResult(_employeeService.GetEmployees());
            }
        }
    }
}
