namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure to hold on a producer and its configuration</summary>
[CppInclude("DataprepAssetProducers.h")]
public partial struct FDataprepAssetProducer {
	public UDataprepContentProducer Producer;
	public bool bIsEnabled;
	public int SupersededBy;
}
