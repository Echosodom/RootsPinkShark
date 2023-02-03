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

public sealed partial class GameTag :  Bright.Config.BeanBase 
{
    public GameTag(JSONNode _json) 
    {
        { if(!_json["TagId"].IsNumber) { throw new SerializationException(); }  TagId = _json["TagId"]; }
        { if(!_json["TagName"].IsString) { throw new SerializationException(); }  TagName = _json["TagName"]; }
        { if(!_json["Desc"].IsString) { throw new SerializationException(); }  Desc = _json["Desc"]; }
        { if(!_json["TagGroupId"].IsNumber) { throw new SerializationException(); }  TagGroupId = _json["TagGroupId"]; }
        { if(!_json["IsGoodTag"].IsBoolean) { throw new SerializationException(); }  IsGoodTag = _json["IsGoodTag"]; }
        { if(!_json["IsInherit"].IsBoolean) { throw new SerializationException(); }  IsInherit = _json["IsInherit"]; }
        PostInit();
    }

    public GameTag(int TagId, string TagName, string Desc, int TagGroupId, bool IsGoodTag, bool IsInherit ) 
    {
        this.TagId = TagId;
        this.TagName = TagName;
        this.Desc = Desc;
        this.TagGroupId = TagGroupId;
        this.IsGoodTag = IsGoodTag;
        this.IsInherit = IsInherit;
        PostInit();
    }

    public static GameTag DeserializeGameTag(JSONNode _json)
    {
        return new GameTag(_json);
    }

    /// <summary>
    /// 特质Id
    /// </summary>
    public int TagId { get; private set; }
    /// <summary>
    /// 特质名称
    /// </summary>
    public string TagName { get; private set; }
    /// <summary>
    /// 描述
    /// </summary>
    public string Desc { get; private set; }
    /// <summary>
    /// 特质组Id
    /// </summary>
    public int TagGroupId { get; private set; }
    /// <summary>
    /// 是否好特质
    /// </summary>
    public bool IsGoodTag { get; private set; }
    /// <summary>
    /// 是否继承
    /// </summary>
    public bool IsInherit { get; private set; }

    public const int __ID__ = 1469036072;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "TagId:" + TagId + ","
        + "TagName:" + TagName + ","
        + "Desc:" + Desc + ","
        + "TagGroupId:" + TagGroupId + ","
        + "IsGoodTag:" + IsGoodTag + ","
        + "IsInherit:" + IsInherit + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
