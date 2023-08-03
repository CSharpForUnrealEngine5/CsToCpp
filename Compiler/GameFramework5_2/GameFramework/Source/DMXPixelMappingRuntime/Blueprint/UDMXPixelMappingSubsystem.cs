#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/DMXPixelMappingSubsystem.h")]
public partial class UDMXPixelMappingSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Get a DMX PixelMapping Subsystem, pure version</summary>
	public static UDMXPixelMappingSubsystem GetDMXPixelMappingSubsystem_Pure() { return default; }
	///<summary>Get a DMX PixelMapping Subsystem, callable version</summary>
	public static UDMXPixelMappingSubsystem GetDMXPixelMappingSubsystem_Callable() { return default; }
	///<summary>Load Pixel Mapping asset</summary>
	public  UDMXPixelMapping GetDMXPixelMapping(UDMXPixelMapping InPixelMapping) { return default; }
	///<summary>Get Renderer component. Only for K2 blueprint nodes</summary>
	public  UDMXPixelMappingRendererComponent GetRendererComponent(UDMXPixelMapping InDMXPixelMapping,string InComponentName) { return default; }
	///<summary>Get OutputDMX component. Only for K2 blueprint nodes</summary>
	public  UDMXPixelMappingOutputDMXComponent GetOutputDMXComponent(UDMXPixelMapping InDMXPixelMapping,string InComponentName) { return default; }
	///<summary>Get FixtureGroup component. Only for K2 blueprint nodes</summary>
	public  UDMXPixelMappingFixtureGroupComponent GetFixtureGroupComponent(UDMXPixelMapping InDMXPixelMapping,string InComponentName) { return default; }
	///<summary>Get Matrix component. Only for K2 blueprint nodes</summary>
	public  UDMXPixelMappingMatrixComponent GetMatrixComponent(UDMXPixelMapping InDMXPixelMapping,string InComponentName) { return default; }
}
