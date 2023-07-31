#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to configure which NetDriver is started with Iris enabled or not</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FIrisNetDriverConfig {
	public string NetDriverDefinition;
	public string NetDriverName;
	public string NetDriverWildcardName;
	public bool bEnableIris;
}
