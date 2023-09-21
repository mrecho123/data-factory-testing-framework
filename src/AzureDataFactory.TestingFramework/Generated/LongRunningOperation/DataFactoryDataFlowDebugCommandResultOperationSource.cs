// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using AzureDataFactory.TestingFramework.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal class DataFactoryDataFlowDebugCommandResultOperationSource : IOperationSource<DataFactoryDataFlowDebugCommandResult>
    {
        DataFactoryDataFlowDebugCommandResult IOperationSource<DataFactoryDataFlowDebugCommandResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataFactoryDataFlowDebugCommandResult.DeserializeDataFactoryDataFlowDebugCommandResult(document.RootElement);
        }

        async ValueTask<DataFactoryDataFlowDebugCommandResult> IOperationSource<DataFactoryDataFlowDebugCommandResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataFactoryDataFlowDebugCommandResult.DeserializeDataFactoryDataFlowDebugCommandResult(document.RootElement);
        }
    }
}
