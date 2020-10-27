using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Models
{
    public class PlayerCharacter : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _characterLevel;
        private int _gold;
        
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass
        { 
            get { return _characterClass; }
            set 
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints
        { 
            get { return _hitPoints; } 
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoints
        {
            get { return _experiencePoints; } 
            set
            { 
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int CharacterLevel
        {
            get { return _characterLevel; }
            set
            {
                _characterLevel = value;
                OnPropertyChanged("CharacterLevel");
            }
        }
        public int Gold
        { 
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
