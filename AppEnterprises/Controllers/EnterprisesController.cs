using EnterprisesDataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppEnterprises.Controllers
{

    //[ApiVersion("1.0")]
    //[Produces("application/json")]

    [RoutePrefix("api/v1/enterprises")]
    public class EnterprisesController : ApiController
    {
        [HttpGet]
        public IEnumerable<enterprises> GetAll()
        {
            using (App_EnterprisesEntities entities = new App_EnterprisesEntities())
            {
                return entities.enterprises.ToList();
            }
        }

        [HttpGet]
        [Route("")]
        public enterprises GetByCodigoTipo(int enterprise_types, string name)
        {
            using (App_EnterprisesEntities entities = new App_EnterprisesEntities())
            {
                return entities.enterprises.Where(e => e.id == enterprise_types && e.enterprise_name.Equals(name)).FirstOrDefault();
            }
        }

        [HttpGet]
        [Route("{codigo}")]
        public enterprises GetByCodigo(int codigo)
        {
            using (App_EnterprisesEntities entities = new App_EnterprisesEntities())
            {
                return entities.enterprises.Where(e => e.id == codigo).FirstOrDefault();
            }
        }

    }
}
