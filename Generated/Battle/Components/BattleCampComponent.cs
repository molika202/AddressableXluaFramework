//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class BattleEntity {

    public CampComponent camp { get { return (CampComponent)GetComponent(BattleComponentsLookup.Camp); } }
    public bool hasCamp { get { return HasComponent(BattleComponentsLookup.Camp); } }

    public void AddCamp(CampType newValue) {
        var index = BattleComponentsLookup.Camp;
        var component = (CampComponent)CreateComponent(index, typeof(CampComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCamp(CampType newValue) {
        var index = BattleComponentsLookup.Camp;
        var component = (CampComponent)CreateComponent(index, typeof(CampComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCamp() {
        RemoveComponent(BattleComponentsLookup.Camp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class BattleMatcher {

    static Entitas.IMatcher<BattleEntity> _matcherCamp;

    public static Entitas.IMatcher<BattleEntity> Camp {
        get {
            if (_matcherCamp == null) {
                var matcher = (Entitas.Matcher<BattleEntity>)Entitas.Matcher<BattleEntity>.AllOf(BattleComponentsLookup.Camp);
                matcher.componentNames = BattleComponentsLookup.componentNames;
                _matcherCamp = matcher;
            }

            return _matcherCamp;
        }
    }
}
