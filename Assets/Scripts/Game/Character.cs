using System.Collections.Generic;
using cfg;
using MatchThree.System;
using QFramework;
using Unity.VisualScripting;

namespace Roots.Game
{

    public enum CharacterState
    {
        Die, Retired, Live, Children
    }
    public class Character : ICanGetSystem
    {
        #region BasicAttribute

        public string Name;
        public int Age;
        private int MaxAge;
        public bool Sex;
        public CharacterState CharacterState;
        
        #endregion
        
        #region ChooseAttribute

        public int Strength;
        public int Agility;
        public int Intelligence;
        
        #endregion

        #region Staff

        public List<GameResource> Resources;
        public List<GameTag> Tags;

        #endregion

        #region Relationship

        public Character MainParent;
        public Character SubParent;
        public List<Character> Children;

        #endregion


        public void Die()
        {
            CharacterState = CharacterState.Die;
        }


        public void Retired()
        {
            CharacterState = CharacterState.Retired;
        }

        public void IncreaseAge()
        {
            Age++;
            if (Age > MaxAge)
            {
                Die();
                return;
            }
            this.GetSystem<GameEventSystem>().DrawEvent(this);
            
        }

//TODO
        private List<Character> GetAllChildren()
        {
            return Children;
        }
        public void UseResource()
        {
            
        }

        public IArchitecture GetArchitecture()
        {
            return Roots.Interface;
        }

        public void AddToChildren(Character character)
        {
            Children.Add(character);
            if(MainParent!= null)
            {
                MainParent.AddToChildren(character);
            }
            if(SubParent!= null)
            {
                SubParent.AddToChildren(character);
            }
        }
    }
}