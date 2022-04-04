using AbsaPhoneBook.Core.Interfaces;
using AbsaPhoneBook.SharedKernel.Dto;
using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AbsaPhoneBook.API.Endpoints.PhonebookEndpoints
{
    public class List : BaseAsyncEndpoint
    .WithoutRequest
    .WithResponse<PhoneBookListResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPhoneBookService _service;

        public List(IPhoneBookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("/PhoneBooks")]
        [SwaggerOperation(
            Summary = "PhoneBook List",
            Description = "Get a list of PhoneBooks",
            OperationId = "PhoneBook.Id",
            Tags = new[] { "PhoneBookEndpoints" })
        ]
        public override async Task<ActionResult<PhoneBookListResponse>> HandleAsync(CancellationToken cancellationToken)
        {

            var result = await _service.GetAllPhoneBookAsync();

            if (result.Status == Ardalis.Result.ResultStatus.Ok)
            {

                var phoneBookDtos = _mapper.Map<List<PhonebookDto>>(result.Value);

                var PhoneBookList = new PhoneBookListResponse
                {
                    PhonebookDtos = phoneBookDtos
                };
                
                return Ok(PhoneBookList);
            }
            else if (result.Status == Ardalis.Result.ResultStatus.Invalid)
            {
                return BadRequest(result.ValidationErrors);
            }
            else if (result.Status == Ardalis.Result.ResultStatus.NotFound)
            {
                return NotFound();
            }

            return BadRequest();
        }
    }

    public class PhoneBookListResponse
    {
        public List<PhonebookDto> PhonebookDtos { get; set; } = new();
    }
}
