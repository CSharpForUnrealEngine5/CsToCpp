#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepAssetProducers.h")]
///<summary>Structure to hold on a producer and its configuration</summary>
public partial struct FDataprepAssetProducer {
// DataprepAssetProducer
	public UDataprepContentProducer Producer;
	public bool bIsEnabled;
	public int SupersededBy;
}
