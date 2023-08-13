namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSpriteRendererProperties.h")]
///<summary>This enum decides how a sprite particle will orient its &quot;up&quot; axis. Must keep these in sync with NiagaraSpriteVertexFactory.ush</summary>
public enum ENiagaraSpriteAlignment {
	Unaligned=0,
	VelocityAligned=1,
	CustomAlignment=2,
}
