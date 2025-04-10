using Content.Shared.Chat.Prototypes;
using Content.Shared.Damage;
using Content.Shared.FixedPoint;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._RMC14.Xenonids.Pierce;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(XenoPierceSystem))]
public sealed partial class XenoPierceComponent : Component
{
    [DataField, AutoNetworkedField]
    public DamageSpecifier Damage;

    [DataField, AutoNetworkedField]
    public int AP = 20;

    [DataField, AutoNetworkedField]
    public int? MaxTargets = 4;

    [DataField, AutoNetworkedField]
    public EntProtoId AttackEffect = "RMCEffectExtraSlash";

    [DataField, AutoNetworkedField]
    public SoundSpecifier Sound = new SoundPathSpecifier("/Audio/_RMC14/Xeno/alien_tail_attack.ogg");

    [DataField, AutoNetworkedField]
    public ProtoId<EmotePrototype> Emote = "XenoRoar";

    [DataField, AutoNetworkedField]
    public TimeSpan? EmoteCooldown = TimeSpan.FromSeconds(5);

    [DataField, AutoNetworkedField]
    public FixedPoint2 Range = FixedPoint2.New(3);

    [DataField, AutoNetworkedField]
    public int RechargeTargetsRequired = 2;

    [DataField, AutoNetworkedField]
    public EntProtoId Blocker = "RMCEffectXenoTelegraphInvisible";
}
