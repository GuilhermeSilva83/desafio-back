using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Seedwork.Domain
{

    public class OperationResult<TData> : OperationResult
    {
        public TData Data { get; set; }

    }


    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public OperationResult<TData> As<TData>(TData d = (default))
        {
            return new OperationResult<TData>()
            {
                Message = this.Message,
                Success = this.Success,
                Data = d
            };
        }

        public static OperationResult<TData> Ok<TData>(TData data)
        {
            return new OperationResult<TData>()
            {
                Success = true,
                Message = "Operação Realizada com Sucesso",
                Data = data
            };
        }

        public static OperationResult Ok()
        {
            return new OperationResult()
            {
                Success = true,
                Message = "Operação Realizada com Sucesso",
            };
        }



        public static OperationResult Fail(string message = null)
        {
            return new OperationResult()
            {
                Success = false,
                Message = message
            };
        }

        public static OperationResult<TData> Fail<TData>(string message = null, TData data = (default))
        {
            return new OperationResult<TData>()
            {
                Success = false,
                Message = message,
                Data = data
            };
        }
    }
}
