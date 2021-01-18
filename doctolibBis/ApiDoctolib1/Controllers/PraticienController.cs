using ApiDoctolib1.Models;
using ApiDoctolib1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctolib1.Controllers
{
        [Route("api/v1/[controller]")]
        [ApiController]
        public class PraticienController : ControllerBase
        {
          private IUpload _upload;

           
        public PraticienController(IUpload upload)
            {
                _upload = upload;
            }




            [HttpGet("filter/{search}")]   
            public List<Praticien> Get(string search)
            {
                return Praticien.Search(search);
            }



            [HttpGet("{id}")]   
            public Praticien Get(int id)
            {
                return Praticien.GetPraticien(id);
            }



            [HttpPost]         
            public Praticien Post([FromForm] Praticien praticien, [FromForm] IFormFile image)
            {
                praticien.Images.Add(new Image() { Url = _upload.Upload(image) });
                praticien.Save();
                return praticien;
            }



            [HttpPut("{id}/images")]          
            public Praticien Put(int id, [FromForm] IFormFile image)
            {
                Praticien praticien = Praticien.GetPraticien(id);
                if (praticien != null)
                {
                praticien.Images.Add(new Image() { Url = _upload.Upload(image) });
                praticien.Update();
                }
                return praticien;
            }

        }
    }

