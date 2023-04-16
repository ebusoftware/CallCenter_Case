using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallCenter_Case.API.Controllers
{
    public class BaseController : ControllerBase
    {
        //Butun controller icin BaseController insa ettim. Bu controller'ı kalıtım alan diger controllerlar artik bunu kullancak.
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); //Mediator varsa onu donder yoksa IOC den Mediator 'ı cek.
        private IMediator? _mediator;
    }
}
