//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg
{ 

public sealed partial class TbEventEffect
{
    private readonly Dictionary<EffectType, EventEffect> _dataMap;
    private readonly List<EventEffect> _dataList;
    
    public TbEventEffect(JSONNode _json)
    {
        _dataMap = new Dictionary<EffectType, EventEffect>();
        _dataList = new List<EventEffect>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = EventEffect.DeserializeEventEffect(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.EventEffectType, _v);
        }
        PostInit();
    }

    public Dictionary<EffectType, EventEffect> DataMap => _dataMap;
    public List<EventEffect> DataList => _dataList;

    public EventEffect GetOrDefault(EffectType key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public EventEffect Get(EffectType key) => _dataMap[key];
    public EventEffect this[EffectType key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    
    partial void PostInit();
    partial void PostResolve();
}

}