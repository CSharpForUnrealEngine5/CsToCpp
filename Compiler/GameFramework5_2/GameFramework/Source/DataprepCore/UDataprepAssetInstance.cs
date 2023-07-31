#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DataprepAssetInstance is an implementation of the DataprepAssetInterface sharing</summary>
[CppInclude("DataprepAssetInstance.h")]
public partial class UDataprepAssetInstance : UDataprepAssetInterface {
	///<summary>Parent Dataprep asset&#39;s interface</summary>
	public UDataprepAssetInterface Parent;
	///<summary>Parameterization</summary>
	public UDataprepParameterizationInstance Parameterization;
	///<summary>ActionsFromDataprepAsset</summary>
	public TArray<UDataprepActionAsset> ActionsFromDataprepAsset;
}
