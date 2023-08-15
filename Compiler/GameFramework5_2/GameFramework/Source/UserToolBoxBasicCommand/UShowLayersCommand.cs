namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ShowLayersCommand.h")]
public partial class UShowLayersCommand : UUTBBaseCommand {
	public static UClass StaticClass() {return default;}
	///<summary>Layers</summary>
	public TArray<FName> Layers;
	///<summary>bIsolate</summary>
	public bool bIsolate;
}
