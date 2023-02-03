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

public sealed partial class TbResource
{
    private readonly Dictionary<int, GameResource> _dataMap;
    private readonly List<GameResource> _dataList;
    
    public TbResource(JSONNode _json)
    {
        _dataMap = new Dictionary<int, GameResource>();
        _dataList = new List<GameResource>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = GameResource.DeserializeGameResource(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.ResourceId, _v);
        }
        PostInit();
    }

    public Dictionary<int, GameResource> DataMap => _dataMap;
    public List<GameResource> DataList => _dataList;

    public GameResource GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GameResource Get(int key) => _dataMap[key];
    public GameResource this[int key] => _dataMap[key];

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