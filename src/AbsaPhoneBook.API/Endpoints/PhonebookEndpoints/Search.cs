using AbsaPhoneBook.Core.Interfaces;
using AbsaPhoneBook.SharedKernel.Dto;
using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AbsaPhoneBook.API.Endpoints.PhonebookEndpoints
{
    public class Search : BaseAsyncEndpoint
    .WithRequest<SearchPhoneBookByNameRequest>
    .WithResponse<List<PhonebookDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPhoneBookService _service;

        public Search(IPhoneBookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("/PhoneBook/Search/{Name}")]
        [SwaggerOperation(
            Summary = "Gets a PhoneBook by name",
            Description = "Gets a PhoneBook by name",
            OperationId = "PhoneBook.Id",
            Tags = new[] { "PhoneBookEndpoints" })
        ]
        public override async Task<ActionResult<List<PhonebookDto>>> HandleAsync([FromRoute] SearchPhoneBookByNameRequest request,
          CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Request is null");
            }

            var result = await _service.GetPhoneBookByNameAsync(request.Name); // TODO: pass cancellation token

            if (result.Status == Ardalis.Result.ResultStatus.Ok)
            {
                var phonebookDto = _mapper.Map<List<PhonebookDto>>(result.Value);

                return Ok(phonebookDto);
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

    public class SearchPhoneBookByNameRequest
    {
        public const string Route = "/PhoneBook/{name:string}";
        public static string BuildRoute(string name) => Route.Replace("{name:string}", name);

        [Required]
        public string Name { get; set; }
    }
}
