#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepAssetInstance.h")]
///<summary>A DataprepAssetInstance is an implementation of the DataprepAssetInterface sharing</summary>
public partial class UDataprepAssetInstance : UDataprepAssetInterface {
// DataprepAssetInstance
	public UDataprepAssetInterface Parent;
	public UDataprepParameterizationInstance Parameterization;
	public TArray<UDataprepActionAsset> ActionsFromDataprepAsset;
}
