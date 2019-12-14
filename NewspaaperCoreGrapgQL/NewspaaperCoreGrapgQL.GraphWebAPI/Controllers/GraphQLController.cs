using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using NewspaaperCoreGrapgQL.Business.GraphModels.Utilities;

namespace NewspaaperCoreGrapgQL.GraphWebAPI.Controllers
{
    [Route("[controller]")]
    public class GraphQLController : Controller
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _documentExecuter;
        public GraphQLController(ISchema schema, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }

        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if (query == null)
            {
                throw new ArgumentNullException();
            }
            var inputs = query.Variables?.ToInputs();
            var executionOptions = new ExecutionOptions
            {
                Inputs = inputs,
                Query = query.Query,
                Schema = _schema
            };

            var result = await _documentExecuter.ExecuteAsync(executionOptions);
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
