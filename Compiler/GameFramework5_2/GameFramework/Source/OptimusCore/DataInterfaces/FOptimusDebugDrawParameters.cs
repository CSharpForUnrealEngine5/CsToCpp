#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>User controllable debug draw settings.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceDebugDraw.h")]
public partial struct FOptimusDebugDrawParameters {
	public bool bForceEnable;
	public int MaxLineCount;
	public int MaxTriangleCount;
	public int MaxCharacterCount;
	public int FontSize;
}
