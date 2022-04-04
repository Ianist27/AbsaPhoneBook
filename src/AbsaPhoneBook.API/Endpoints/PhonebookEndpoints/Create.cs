using AbsaPhoneBook.Core.Interfaces;
using AbsaPhoneBook.Core.ProjectAggregate;
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
    public class Create : BaseAsyncEndpoint
     .WithRequest<PhonebookDto>
     .WithResponse<PhonebookDto>
    {
        private readonly IMapper _mapper;
        private readonly IPhoneBookService _service;

        public Create(IPhoneBookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost("/Phonebook")]
        [SwaggerOperation(
            Summary = "Creates Phonebook",
            Description = "Create a Phonebook entry",
            OperationId = "PhoneBookDto.Id",
            Tags = new[] { "PhoneBookEndpoints" })
        ]
        public override async Task<ActionResult<PhonebookDto>> HandleAsync([FromBody] PhonebookDto request,
          CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Request is null");
            }

            var phoneBook = _mapper.Map<PhoneBook>(request);

            var result = await _service.AddPhoneBookAsync(phoneBook); // TODO: pass cancellation token

            if (result.Status == Ardalis.Result.ResultStatus.Ok)
            {
                return Created("", result.Value);
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
}
