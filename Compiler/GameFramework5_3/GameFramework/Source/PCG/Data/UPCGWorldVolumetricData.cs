namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Queries volume for presence of world collision or not. Can be used to voxelize environment.</summary>
[CppInclude("Data/PCGWorldData.h")]
public partial class UPCGWorldVolumetricData : UPCGVolumeData {
	public static UClass StaticClass() {return default;}
	///<summary>World</summary>
	public TWeakObjectPtr<UWorld> World;
	///<summary>OriginatingComponent</summary>
	public TWeakObjectPtr<UPCGComponent> OriginatingComponent;
	///<summary>QueryParams</summary>
	public FPCGWorldVolumetricQueryParams QueryParams;
}
