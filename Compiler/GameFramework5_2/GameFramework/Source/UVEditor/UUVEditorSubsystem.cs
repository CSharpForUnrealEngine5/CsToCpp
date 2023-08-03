#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The subsystem is meant to hold any UV editor operations that are not UI related (those are</summary>
[CppInclude("UVEditorSubsystem.h")]
public partial class UUVEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Used to let the subsystem figure out whether targets are valid. New factories should be</summary>
	public UToolTargetManager ToolTargetManager;
}
