using Amazon.Lambda.Core;
using ShowtimeImporterLambda.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ShowtimeImporterLambda;

public class Function
{
    public LambdaResponse FunctionHandler(LambdaParameters input, ILambdaContext context)
    {
        return new LambdaResponse
        {
            Result = input.Text.ToUpper()
        };
    }
}
