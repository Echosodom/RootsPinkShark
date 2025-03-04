using System.Collections.Generic;
using cfg;
using Roots.Game;

namespace Roots.Event
{

    //继承新角色之后，前台需要更新头像动画等信息
    public struct ChooseNewCharacterEvent
    {
        public Character Character;
    }

    //随着年龄增长获得的新事件
    public struct GetNewEvent
    {
        public List<cfg.Event> Events;
    }
    //获得新道具
    public struct GetResourceEvent
    {
        public GameResource GameResource;
    }
    
    
}