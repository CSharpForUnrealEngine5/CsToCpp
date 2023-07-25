#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSpriteRendererProperties.h")]
///<summary>This enum decides how a sprite particle will orient its "up" axis. Must keep these in sync with NiagaraSpriteVertexFactory.ush</summary>
public enum ENiagaraSpriteAlignment {
	Unaligned=0,
	VelocityAligned=1,
	CustomAlignment=2,
}
