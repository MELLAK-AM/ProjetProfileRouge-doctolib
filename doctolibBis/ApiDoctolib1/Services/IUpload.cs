using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctolib1.Services
{
    public interface IUpload
    {
        string Upload(IFormFile image);
    }
}
