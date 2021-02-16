using System;
namespace Core.Utilities.Results
{
    //Temel Voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
