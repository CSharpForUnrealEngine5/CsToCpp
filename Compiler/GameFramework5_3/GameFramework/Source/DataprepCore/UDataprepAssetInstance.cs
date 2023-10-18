namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DataprepAssetInstance is an implementation of the DataprepAssetInterface sharing</summary>
[CppInclude("DataprepAssetInstance.h")]
public partial class UDataprepAssetInstance : UDataprepAssetInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Parent Dataprep asset&#39;s interface</summary>
	public UDataprepAssetInterface Parent;
	///<summary>Parameterization</summary>
	public UDataprepParameterizationInstance Parameterization;
	///<summary>ActionsFromDataprepAsset</summary>
	public TArray<UDataprepActionAsset> ActionsFromDataprepAsset;
}
