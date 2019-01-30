﻿using ArithmeticCalcualitonAPI.Calculation;
using System.Web.Http;

namespace ArithmeticCalcualitonAPI.Controllers
{
    public class OperationController : ApiController
    {

        private IAddModel _AddModel;
        private IDifferenceModel _DifferenceModel;
        private IProductModel _IProductModel;
        private IDivideModel _DivideModel;
        
        public OperationController(IAddModel AddM, IDifferenceModel DiffM, IProductModel ProM, IDivideModel DivM)
        {
            _AddModel = AddM;
            _DifferenceModel = DiffM;
            _DivideModel = DivM;
            _IProductModel = ProM;
        }

        [HttpGet]
        [Route("api/Operation/add/{i}/{j}")]
        public IHttpActionResult add(int i, int j)
        {
            return Ok(_AddModel.add(i, j));
        }

        [HttpGet]
        [Route("api/Operation/sub/{i}/{j}")]
        public IHttpActionResult sub(int i, int j)
        {
            return Ok(_DifferenceModel.sub(i, j));
        }

        [HttpGet]
        [Route("api/Operation/mul/{i}/{j}")]
        public IHttpActionResult mul(int i, int j)
        {
            return Ok(_IProductModel.mul(i, j));
        }

        [HttpGet]
        [Route("api/Operation/div/{i}/{j}")]
        public IHttpActionResult div(int i, int j)
        {
            return Ok(_DivideModel.div(i, j));
        }


    }
}
