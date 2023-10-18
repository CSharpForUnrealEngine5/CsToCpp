namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/ParameterizeMeshProperties.h")]
public partial class UParameterizeMeshToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Automatic UV generation technique to use</summary>
	public EParameterizeMeshUVMethod Method;
}
